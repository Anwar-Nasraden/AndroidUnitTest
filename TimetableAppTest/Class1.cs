using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace TimetableAppTest
{
    [TestFixture(Platform.Android)]
    [Category("Smoke")]
    class Class1 : Tests
    {
        IApp app;
        public Class1(Platform platform): base (platform)
        {

        }

        [Test]
        public void AppLaunches() {
            app.Screenshot("Smoke testing screenshot");
        }
    }
}
