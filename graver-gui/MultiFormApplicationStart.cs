using System;
using System.Windows.Forms;

namespace graver_gui
{
    internal class MultiFormApplicationStart : ApplicationContext
    {
        static int WindowCount;

        private readonly DrawWindow _draw;
        private readonly ControllWindow _control;

        public MultiFormApplicationStart()
        {
            WindowCount = 0;
            _draw = new DrawWindow
            {
                WindowState = FormWindowState.Normal,
                StartPosition = FormStartPosition.Manual
            };
            _draw.FormClosed += OnFormClosed;
            _draw.Location = new System.Drawing.Point(30, 30);
            WindowCount += 1;

            _control = new ControllWindow
            {
                WindowState = FormWindowState.Normal,
                StartPosition = FormStartPosition.Manual
            };
            _control.FormClosed += OnFormClosed;
            _control.Location = new System.Drawing.Point(900, 200);
            WindowCount += 1;

            MessageControl.GetInstance().SetDrawWindow(_draw);

            _draw.Show();
            _control.Show();
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            WindowCount -= 1;
            if (WindowCount == 0)
            {
                ExitThread();
            }
        }
    }
}
