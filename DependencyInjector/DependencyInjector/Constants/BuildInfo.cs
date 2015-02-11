using System.Reflection;

namespace DependencyInjector.Constants
{
    public static class BuildInfo
    {
#if DEBUG
        public const bool IsDebug = true;
#else
        public const bool IsDebug = false;
#endif

        public static readonly string Version = Assembly.GetAssembly(typeof (Contract)).GetName().Version.ToString();

    }
}