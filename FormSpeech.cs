using System;
using System.Collections.Generic;
using System.Globalization;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Text.To.Speech
{
    //  Developer   :- Gehan Fernando.
    //  Application :- Text To Speech
    //  Date        :- 10 Mar 2012
    //  Contact     :- f.gehan@gmail.com, +94772269625 (M)

    public partial class FormSpeech : Form
    {
        #region Variables

        private PromptBuilder builder;
        private SpeechSynthesizer synth;
        private PromptEmphasis emp;

        private Double res;
        private Double counter;
        private int pos;

        private String preword;

        #endregion

        #region Events

        public FormSpeech()
        {
            InitializeComponent();
        }
        private void FormSpeech_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxEmphasis.SelectedIndex = 0;
                this.ResetControls(false);
                this.LoadVoices();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxWords_TextChanged(object sender, EventArgs e)
        {
            if (textBoxWords.Text.Trim().Length != 0)
                this.ResetControls(true);
            else
                this.ResetControls(false);
        }
        private void comboBoxEmphasis_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxEmphasis.SelectedIndex)
            {
                case 0:
                    emp = PromptEmphasis.Moderate;
                    break;
                case 1:
                    emp = PromptEmphasis.None;
                    break;
                case 2:
                    emp = PromptEmphasis.NotSet;
                    break;
                case 3:
                    emp = PromptEmphasis.Reduced;
                    break;
                default:
                    emp = PromptEmphasis.Strong;
                    break;
            }
        }
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxWords.Text.Trim().Length == 0)
                    return;

                if (synth == null)
                {
                    this.ResetControls(false);
                    this.SetVisible(true);
                    this.Speak();
                }
                else
                    if (synth.State == SynthesizerState.Paused)
                        synth.Resume();

                buttonPlay.Enabled = false;
                buttonPause.Enabled = true;
                buttonStop.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.ResetControls(true);
                this.SetVisible(false);

                buttonPlay.Enabled = true;
                buttonPause.Enabled = false;
                buttonStop.Enabled = false;
            }
        }
        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (synth != null)
            {
                if (synth.State == SynthesizerState.Speaking)
                {
                    synth.Pause();

                    buttonPlay.Enabled = true;
                    buttonPause.Enabled = false;
                    buttonStop.Enabled = true;
                }
            }
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (synth != null)
            {
                this.ResetValues();
                this.ResetControls(true);
                this.SetVisible(false);

                buttonPlay.Enabled = true;
                buttonPause.Enabled = false;
                buttonStop.Enabled = false;
            }
        }

        void synth_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            this.ResetValues();
            this.ResetControls(true);
            this.SetVisible(true);
        }
        void synth_SpeakProgress(object sender, SpeakProgressEventArgs e)
        {
            if (preword != e.Text.Trim())
            {
                labelNowReading.Text = String.Concat("Now reading ... ", e.Text);

                textBoxWords.SelectionStart = textBoxWords.Text.IndexOf(e.Text, pos, StringComparison.InvariantCulture);
                textBoxWords.SelectionLength = e.CharacterCount;
                textBoxWords.Select();

                pos += (e.CharacterCount + 1);
                counter = pos;
                res = (counter / textBoxWords.Text.Trim().Length) * 100;

                if ((int)res > 100)
                    progressBarComplete.Value = 100;
                else
                    progressBarComplete.Value = (int)(res);

                labelPercantage.Text = String.Format("{0}{1}", progressBarComplete.Value, "%");

                preword = e.Text.Trim();
            }
        }

        #endregion

        #region Methods

        private void LoadVoices()
        {
            List<Speak> voices = new List<Speak>();

            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                foreach (InstalledVoice voice in synth.GetInstalledVoices())
                {
                    VoiceInfo info = voice.VoiceInfo;
                    
                    Speak voiceinfo = new Speak()
                    {
                        VoiceID = info.Id,
                        VoiceName = info.Name
                    };

                    voices.Add(voiceinfo);
                }
            }

            comboBoxVoices.DisplayMember = "VoiceName";
            comboBoxVoices.ValueMember = "VoiceID";
            comboBoxVoices.DataSource = voices;
        }
        private void Speak()
        {
            synth = new SpeechSynthesizer();

            synth.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(synth_SpeakCompleted);
            synth.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(synth_SpeakProgress);

            synth.SetOutputToDefaultAudioDevice();

            PromptStyle style = new PromptStyle(emp)
            {
                Rate = PromptRate.NotSet,
                Volume = PromptVolume.NotSet
            };

            synth.Rate = trackBarSpeed.Value;
            synth.Volume = (trackBarVolume.Value * 10);
            synth.SelectVoice(comboBoxVoices.Text);

            builder = new PromptBuilder();

            builder.Culture = CultureInfo.CurrentUICulture;
            builder.StartStyle(style);
            builder.AppendText(textBoxWords.Text.Trim());
            builder.EndStyle();

            synth.SpeakAsync(builder);
        }

        private void ResetValues()
        {
            builder = null;

            synth.Dispose();
            synth = null;

            res = 0;
            pos = 0;

            preword = String.Empty;

            textBoxWords.Select(0, 0);
        }
        private void ResetControls(Boolean value)
        {
            buttonPlay.Enabled = value;
            trackBarSpeed.Enabled = value;
            trackBarVolume.Enabled = value;
            comboBoxEmphasis.Enabled = value;
            comboBoxVoices.Enabled = value;

            buttonPause.Enabled = false;
            buttonStop.Enabled = false;
        }
        private void SetVisible(Boolean value)
        {
            progressBarComplete.Visible = value;
            labelPercantage.Visible = value;
            labelNowReading.Visible = value;

            progressBarComplete.Value = 0;
            labelPercantage.ResetText();
            labelNowReading.ResetText();
        }

        #endregion 
    }
}