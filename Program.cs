using System;
using System.Threading;
using System.Windows.Forms;

namespace Text.To.Speech
{
    //  Developer   :- Gehan Fernando.
    //  Application :- Text To Speech
    //  Date        :- 10 Mar 2012
    //  Contact     :- f.gehan@gmail.com, +94772269625 (M)

    static class Program
    {
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException +=
                                                new UnhandledExceptionEventHandler(Speech_UnhandledException);

            Application.ThreadException +=
                                        new System.Threading.ThreadExceptionEventHandler(Speech_ThreadException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSpeech());
        }

        public static void Speech_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = (Exception)e.ExceptionObject;

                MessageBox.Show("Whoops! Please contact the developers with the following"
                      + " information:\n\n" + ex.Message + ex.StackTrace,
                      "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                Application.Exit();
            }
        }
        public static void Speech_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                MessageBox.Show("Whoops! Please contact the developers with the"
                    + " following information:\n\n" + e.Exception.Message + e.Exception.StackTrace,
                    "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                Application.Exit();
            }
        }
    }
}
