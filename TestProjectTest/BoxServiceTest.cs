using TestProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjectTest
{
    
    
    /// <summary>
    ///Это класс теста для BoxServiceTest, в котором должны
    ///находиться все модульные тесты BoxServiceTest
    ///</summary>
    [TestClass()]
    public class BoxServiceTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Дополнительные атрибуты теста
        // 
        //При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        //ClassInitialize используется для выполнения кода до запуска первого теста в классе
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //TestInitialize используется для выполнения кода перед запуском каждого теста
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //TestCleanup используется для выполнения кода после завершения каждого теста
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        ///Тест для GetVolume
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void GetVolumeTestExeption()
        {
            BoxService target = new BoxService(); 
            Box box = null; 
            double actual = target.GetVolume(box);
        }

        /// <summary>
        ///Тест для GetVolume
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void GetSurfaceSquareTestExeption()
        {
            BoxService target = new BoxService();
            Box box = null;
            double actual = target.GetSurfaceSquare(box);
        }

        /// <summary>
        ///Тест для GetVolume
        ///</summary>
        [TestMethod()]
        public void GetSurfaceSquareTest()
        {
            BoxService target = new BoxService();
            Box box = new Box(1, 2, 3);
            double expected = 1 * 2 * 2 + 1 * 3 * 2 + 2 * 3 * 2;
            double actual = target.GetSurfaceSquare(box);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для GetVolume
        ///</summary>
        [TestMethod()]
        public void GetVolumeTest()
        {
            BoxService target = new BoxService(); 
            Box box = new Box(1, 2, 3); 
            double expected = 6F; 
            double actual;
            actual = target.GetVolume(box);
            Assert.AreEqual(expected, actual);
        }
    }
}
