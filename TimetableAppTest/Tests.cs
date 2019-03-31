using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace TimetableAppTest
{


    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        readonly Platform platform;

        readonly Func<AppQuery, AppQuery> _welcomeLabel = e => e.Marked("WelcomeLabel");
        Func<AppQuery, AppQuery> _listItem(int index) => e => e.Marked("ListItem").Index(index);

       
        public Tests(Platform platform)
        {
            this.platform = platform;
        }

    

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            app.Screenshot("Welcome screen.");

            Assert.IsTrue(results.Any());

        }

       



        


        //TEST IF WIFI OR DATA TURNED OFF WHEN SEARCH, ERROR MESSAGE "CONNECTIVITY ERROR, NO INTERNET ACCESS"
        [Test]
        public void Test1()     
        {
            AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            app.Screenshot("Welcome screen.");

            Assert.IsTrue(results.Any());
        }


        //TEST IF ROOM NUMBER SEARCHED FOR THAT IS NOT IN DB, ERROR MESSSAGE "ROOM NOT FOUND" APPEARS
        [Test]
        public void Test2()     
        {
            AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            app.Screenshot("Welcome screen.");

            Assert.IsTrue(results.Any());
        }

        //My tests
        [Test]
        public void Addition()
        {
            var num1 = 2;
            var num2 = 4;

            var sum = num1 + num2;
            Assert.AreEqual(sum, 6);
        }
        [Test]
        public Tests WaitForloadFab(int fab)
        {
            app.Tap(_listItem(fab));
            return this;
        }
        [Test]
        public Tests WaitForLoad()
        {
            app.WaitForElement(_welcomeLabel);
            return this;
        }

    }
}
