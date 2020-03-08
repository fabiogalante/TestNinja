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
        public void CancBeCancelledBy_AnotherUser_ReturnsFalse()
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
