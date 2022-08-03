using System.Runtime.InteropServices;

namespace PTLauncher.API.Dos
{
    internal interface Dos
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll")]
        public static extern IntPtr ShowWindow(IntPtr hWnd, int nCmdShow);
        public static void Show()
        {
            /* 显示控制台 */
            /* Show Console */
            ShowWindow(GetConsoleWindow(), 5);
        }
        public static void Hide()
        {
            /* 隐藏控制台 */
            /* Hide Console */
            ShowWindow(GetConsoleWindow(), 0);
        }
    }
}
