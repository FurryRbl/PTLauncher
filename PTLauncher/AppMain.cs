using PTLauncher.API.Dos;
using System.Windows;
using System.IO;
using PTLauncher.API.Log;
using PTLauncher.API;

namespace PTLauncher
{
    public static class AppMain
    {
        [STAThread]
        public static void Main(string[] args)
        {
            ConfigLoader(); /* 初始化配置文件 */ /* Initializes the configuration file */
            if (args.Length == 0)
            {
                Dos.Hide();
            }
            else
            {
                if (args[0] != "--debug")
                {
                    Console.WriteLine("仅支持“--debug”参数");
                    Environment.Exit(0);
                }
            }
            StartApp(); /* 启动程序 */ /* Start App */
        }
        private static void ConfigLoader()
        {
            if (!Directory.Exists("Config"))
            {
                Directory.CreateDirectory("Config");
            }

            if (!File.Exists(@"Config\Config.ini"))
            {
                Default.Config();
            }
        }
        [STAThread]
        private static void StartApp()
        {
            try
            {

                Application app = new Application();
                UI.Home UIHome = new UI.Home();
                app.Run(UIHome);
            }
            catch (Exception e)
            {
                Logger.Fail(e.ToString());
            }
        }
    }
}