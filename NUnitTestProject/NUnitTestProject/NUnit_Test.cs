namespace NUnitTestProject
{
    public class NUnit_Demo
    {

        string test1 = "Test1";
        string test2 = "Test2";
        string test3 = "Test3";
        [SetUp]
        public void Initialize()
        {
            Console.WriteLine("Inside SetUp");
        }

        [TearDown]
        public void DeInitialize()
        {
            Console.WriteLine("Inside TearDown");
        }

        public class TestClass1
        {
            [OneTimeSetUp]
            public static void ClassInitialize()
            {
                Console.WriteLine("Inside OneTimeSetUp");
            }

            [OneTimeTearDown]
            public static void ClassCleanup()
            {
                Console.WriteLine("Inside OneTimeTearDown");
            }
        }

        [Test, Order(1)]
        public void Test_1()
        {
            Console.WriteLine("Inside TestMethod Test_1");
            Assert.That(test1, Is.EqualTo("Test1"));
        }

        [Test, Order(2)]
        public void Test_2()
        {
            Console.WriteLine("Inside TestMethod Test_2");
            Assert.That(test2, Is.EqualTo("Test2"));
        }
        [Test, Order(3)]
        public void Test_3()
        {
            Console.WriteLine("Inside TestMethod Test_3");
            Assert.That(test3, Is.EqualTo("Test3"));

        }
    }
}
