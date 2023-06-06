using System;
using System.Windows.Forms;

namespace graver_gui
{
    public partial class DrawWindow : Form
    {
        private static readonly NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        public DrawWindow()
        {
            InitializeComponent();
        }

        internal void HandleMessage(string message)
        {
            log.Info("accept message");
            log.Info(message);

        }

        private void DrawWindow_Load(object sender, EventArgs e)
        {
        }
    }
}
