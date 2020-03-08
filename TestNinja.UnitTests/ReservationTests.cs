using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    /// <summary>
    /// Summary description for ReservationTests
    /// </summary>
    [TestClass]
    public class ReservationTests
    {
        public ReservationTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
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

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void CancBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });


            //Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void CancBeCancelledBy_NoIsAdminOrUser_ReturnsFalse()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User());


            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CancBeCancelledBy_IsUser_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation
            {
                MadeBy = new User()
            };


            
            //Act
            bool result = reservation.CanBeCancelledBy(reservation.MadeBy);


            //Assert
            Assert.IsTrue(result);
        }
    }
}
