using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegEx.Video.JobRunner;
using Moq;

namespace RegEx.Video.JobRunner.Tests
{
    [TestClass]
    public class ConsoleHostTest
    {

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            // Executes once before the test run. (Optional)
        }
        [ClassInitialize]
        public static void TestFixtureSetup(TestContext context)
        { 
           // Executes once for the test class. (Optional)
        }
      
        [TestInitialize]
        public void Setup()
        {
             // Runs before each test. (Optional)
        }
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
           // Executes once after the test run. (Optional)
        }
        
        [ClassCleanup]
        public static void TestFixtureTearDown()
        {
            // Runs once after all tests in this class are executed. (Optional)
            // Not guaranteed that it executes instantly after all tests from the class.
        }
        
        [TestCleanup]
        public void TearDown()
        { 
            // Runs after each test. (Optional)
        }

        
        [TestMethod]
        public void TestMethodMainRunsWithoutExceptionWithNoArgs()
        {
            ConsoleHost.Main(null);
            
        }

        [TestMethod]
        public void TestMethodMainRunsWithoutExceptionWithNullArgsAndIConsoleSupplied(){
            IConsole console = IConsoleFactory.GetIConsoleInstance();
            ConsoleHost.Main(null,console);
        }

        [TestMethod]
        public void TestMethodMainRunsWithoutExceptionWithNullArgsCallsThroughIConsole(){
            //https://github.com/Moq/moq4/wiki/Quickstart
            var mockConsole = new Mock<IConsole>();
            mockConsole.Setup(x => x.WriteLine(It.IsAny<string>()));
          
            ConsoleHost.Main(null,mockConsole.Object);
            ConsoleHost.Main(null);

            mockConsole.Verify(x => x.WriteLine(It.IsAny<string>()), Times.Exactly(2));

        }
    }
}
