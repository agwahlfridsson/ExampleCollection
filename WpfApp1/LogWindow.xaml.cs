using System.Windows;

namespace WpfApp1
{
    public partial class LogWindow : Window
    {
        private static LogWindow? _logWindow = null;
        private LogWindow()
        {
            InitializeComponent();
        }
        public static LogWindow CreateLogWindow()
        {
            if (_logWindow == null)
            {
                _logWindow = new LogWindow();
                _logWindow.Closing += (s, e) => 
                {
                    _logWindow = null;
                };
            }
            return _logWindow;
        }
    }
}
