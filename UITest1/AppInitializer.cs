using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                       .Android
                       .EnableLocalScreenshots()
                       .ApkFile(@"C:\Users\Adam\AppData\Local\Xamarin\Mono for Android\Archives\2017-05-21\Sample.Droid 5-21-17 5.34 PM.apkarchive\com.Sample.apk")
                       .StartApp();
            }

            return ConfigureApp
                   .iOS
                   .StartApp();
        }
    }
}