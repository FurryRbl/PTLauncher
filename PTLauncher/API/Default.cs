namespace PTLauncher.API
{
    internal interface Default
    {
        public static void Config() /* 创建默认配置文件  */ /* Create Default Config File */
        {
            Util.PTLauncher.Write("Lang", "zh_cn");
            Util.PTLauncher.Write("MxRam", "2048");
        }
    }
}
