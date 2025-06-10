namespace Text.To.Speech
{
    partial class FormSpeech
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSpeech));
            this.textBoxWords = new System.Windows.Forms.TextBox();
            this.labelVoices = new System.Windows.Forms.Label();
            this.comboBoxVoices = new System.Windows.Forms.ComboBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.progressBarComplete = new System.Windows.Forms.ProgressBar();
            this.comboBoxEmphasis = new System.Windows.Forms.ComboBox();
            this.labelEmphasis = new System.Windows.Forms.Label();
            this.labelNowReading = new System.Windows.Forms.Label();
            this.labelPercantage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxWords
            // 
            this.textBoxWords.Location = new System.Drawing.Point(12, 83);
            this.textBoxWords.Multiline = true;
            this.textBoxWords.Name = "textBoxWords";
            this.textBoxWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxWords.Size = new System.Drawing.Size(474, 227);
            this.textBoxWords.TabIndex = 0;
            this.textBoxWords.TextChanged += new System.EventHandler(this.textBoxWords_TextChanged);
            // 
            // labelVoices
            // 
            this.labelVoices.AutoSize = true;
            this.labelVoices.BackColor = System.Drawing.Color.Transparent;
            this.labelVoices.Location = new System.Drawing.Point(9, 379);
            this.labelVoices.Name = "labelVoices";
            this.labelVoices.Size = new System.Drawing.Size(49, 15);
            this.labelVoices.TabIndex = 7;
            this.labelVoices.Text = "Voices";
            // 
            // comboBoxVoices
            // 
            this.comboBoxVoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVoices.FormattingEnabled = true;
            this.comboBoxVoices.Location = new System.Drawing.Point(12, 397);
            this.comboBoxVoices.Name = "comboBoxVoices";
            this.comboBoxVoices.Size = new System.Drawing.Size(128, 23);
            this.comboBoxVoices.TabIndex = 8;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labelSpeed.Location = new System.Drawing.Point(12, 313);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(42, 15);
            this.labelSpeed.TabIndex = 1;
            this.labelSpeed.Text = "Speed";
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.BackColor = System.Drawing.Color.White;
            this.trackBarSpeed.Location = new System.Drawing.Point(12, 331);
            this.trackBarSpeed.Minimum = -10;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(128, 45);
            this.trackBarSpeed.TabIndex = 2;
            this.trackBarSpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarSpeed.Value = -2;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.BackColor = System.Drawing.Color.White;
            this.trackBarVolume.Location = new System.Drawing.Point(146, 331);
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(128, 45);
            this.trackBarVolume.TabIndex = 4;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarVolume.Value = 10;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.BackColor = System.Drawing.Color.Transparent;
            this.labelVolume.Location = new System.Drawing.Point(146, 313);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(49, 15);
            this.labelVolume.TabIndex = 3;
            this.labelVolume.Text = "Volume";
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlay.Image")));
            this.buttonPlay.Location = new System.Drawing.Point(283, 379);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(55, 55);
            this.buttonPlay.TabIndex = 9;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPause.Enabled = false;
            this.buttonPause.Image = ((System.Drawing.Image)(resources.GetObject("buttonPause.Image")));
            this.buttonPause.Location = new System.Drawing.Point(344, 379);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(55, 55);
            this.buttonPause.TabIndex = 10;
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonStop.Enabled = false;
            this.buttonStop.Image = ((System.Drawing.Image)(resources.GetObject("buttonStop.Image")));
            this.buttonStop.Location = new System.Drawing.Point(405, 379);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(55, 55);
            this.buttonStop.TabIndex = 11;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // progressBarComplete
            // 
            this.progressBarComplete.Location = new System.Drawing.Point(12, 426);
            this.progressBarComplete.Name = "progressBarComplete";
            this.progressBarComplete.Size = new System.Drawing.Size(128, 16);
            this.progressBarComplete.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarComplete.TabIndex = 12;
            this.progressBarComplete.Visible = false;
            // 
            // comboBoxEmphasis
            // 
            this.comboBoxEmphasis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmphasis.FormattingEnabled = true;
            this.comboBoxEmphasis.Items.AddRange(new object[] {
            "Moderate",
            "None",
            "NotSet",
            "Reduced",
            "Strong"});
            this.comboBoxEmphasis.Location = new System.Drawing.Point(283, 331);
            this.comboBoxEmphasis.Name = "comboBoxEmphasis";
            this.comboBoxEmphasis.Size = new System.Drawing.Size(128, 23);
            this.comboBoxEmphasis.TabIndex = 6;
            this.comboBoxEmphasis.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmphasis_SelectedIndexChanged);
            // 
            // labelEmphasis
            // 
            this.labelEmphasis.AutoSize = true;
            this.labelEmphasis.BackColor = System.Drawing.Color.Transparent;
            this.labelEmphasis.Location = new System.Drawing.Point(280, 313);
            this.labelEmphasis.Name = "labelEmphasis";
            this.labelEmphasis.Size = new System.Drawing.Size(63, 15);
            this.labelEmphasis.TabIndex = 5;
            this.labelEmphasis.Text = "Emphasis";
            // 
            // labelNowReading
            // 
            this.labelNowReading.AutoSize = true;
            this.labelNowReading.BackColor = System.Drawing.Color.Transparent;
            this.labelNowReading.Location = new System.Drawing.Point(12, 448);
            this.labelNowReading.Name = "labelNowReading";
            this.labelNowReading.Size = new System.Drawing.Size(119, 15);
            this.labelNowReading.TabIndex = 13;
            this.labelNowReading.Text = "Now reading ... ";
            this.labelNowReading.Visible = false;
            // 
            // labelPercantage
            // 
            this.labelPercantage.AutoSize = true;
            this.labelPercantage.BackColor = System.Drawing.Color.Transparent;
            this.labelPercantage.Location = new System.Drawing.Point(146, 427);
            this.labelPercantage.Name = "labelPercantage";
            this.labelPercantage.Size = new System.Drawing.Size(28, 15);
            this.labelPercantage.TabIndex = 14;
            this.labelPercantage.Text = "00%";
            this.labelPercantage.Visible = false;
            // 
            // FormSpeech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(498, 472);
            this.Controls.Add(this.labelPercantage);
            this.Controls.Add(this.labelNowReading);
            this.Controls.Add(this.comboBoxEmphasis);
            this.Controls.Add(this.labelEmphasis);
            this.Controls.Add(this.progressBarComplete);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.comboBoxVoices);
            this.Controls.Add(this.labelVoices);
            this.Controls.Add(this.textBoxWords);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormSpeech";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text To Speech";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.FormSpeech_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWords;
        private System.Windows.Forms.Label labelVoices;
        private System.Windows.Forms.ComboBox comboBoxVoices;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ProgressBar progressBarComplete;
        private System.Windows.Forms.ComboBox comboBoxEmphasis;
        private System.Windows.Forms.Label labelEmphasis;
        private System.Windows.Forms.Label labelNowReading;
        private System.Windows.Forms.Label labelPercantage;


    }
}

