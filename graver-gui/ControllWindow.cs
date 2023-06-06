using System;
using System.Windows.Forms;

namespace graver_gui
{
    public partial class ControllWindow : Form
    {

        private static readonly NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        public ControllWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log.Info("send message");
            MessageControl.GetInstance().SendMessage("draw something");
        }

        private void ControllWindow_Load(object sender, EventArgs e)
        {
        }
    }
}
