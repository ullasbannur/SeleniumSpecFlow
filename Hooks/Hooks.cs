using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowProject.Hooks
{
    [Binding]
    internal class Hooks
    {
        [BeforeScenario]
        public static void Setup()
        {

            Console.WriteLine("Running before every Scenario");
        }


        [AfterScenario]
        public static void TearDown()
        {

            Console.WriteLine("Running after every Scenario");
        }


        [BeforeTestRun]
        public static void BeforeTestRun()
        {

            TestContext.Progress.WriteLine("Running before test run");
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {

            TestContext.Progress.WriteLine("Running after test run");
        }


        [BeforeStep]
        public static void BeforeStep()
        {

            Console.WriteLine("Running before TestRun");
        }

        [AfterStep]
        public static void AfterStep()
        {

            Console.WriteLine("Running after step");
        }
    }
}
