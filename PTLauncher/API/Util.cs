using System.Resources;
using System.Runtime.InteropServices;
using System.Reflection;
namespace PTLauncher.API
{
    public class Util
    {
        public static ResourceManager GetLangFunc = new ResourceManager("PTLauncher.Lang." + Util.PTLauncher.Read("Lang"), Assembly.GetExecutingAssembly()); /* 多国语言文件初始化 */ /* Multilingual Initalization */
        public static ResourceManager DefaultLang = new ResourceManager("PTLauncher.Lang.zh_cn", Assembly.GetExecutingAssembly()); /* 初始化默认语言 */ /* Initalizes the default language */
        public static Config PTLauncher = new Config(AppDomain.CurrentDomain.BaseDirectory + @"Config\Config.ini"); /* 初始化配置文件 */ /* Initalizes default file */
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll")]
        public static extern IntPtr ShowWindow(IntPtr hWnd, int nCmdShow);
        public static void DosShow()
        {
            /* 显示控制台 */
            /* Show Console */
            ShowWindow(GetConsoleWindow(), 5);
        }
        public static void DosHide()
        {
            /* 隐藏控制台 */
            /* Hide Console */
            ShowWindow(GetConsoleWindow(), 0);
        }
        public static string GetLang(string LangID)
        {
            if (GetLangFunc.GetString(LangID) == null)
            {
                return DefaultLang.GetString(LangID);
            }
            else
            {
                return GetLangFunc.GetString(LangID);
            }
        }
    }
}
