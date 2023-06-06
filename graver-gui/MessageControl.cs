namespace graver_gui
{
    internal class MessageControl
    {
        private static MessageControl instance = null;
        private static readonly object obj = new object();

        private MessageControl()
        {

        }

        public static MessageControl GetInstance()
        {
            lock (obj)
            {
                if (instance == null)
                {
                    instance = new MessageControl();
                }
                return instance;
            }
        }

        private DrawWindow DrawWindow;

        public void SetDrawWindow(DrawWindow drawWindow)
        {
            DrawWindow = drawWindow;
        }

        public void SendMessage(string message)
        {
            DrawWindow.HandleMessage(message);
        }
    }
}
