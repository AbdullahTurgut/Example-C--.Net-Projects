using Amazon.EC2.Model;
//using Microsoft.VisualStudio.TestTools.UnitTesting; Assert için kaldırdık
using NUnit.Framework;
using System;
using static TestExample.Reservation;

namespace TestExample.UnitTests
{
    [TestFixture]
    public class ReservationTests   
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange 
            var reservation = new Reservation();
            
            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCalledBy_SameUserCancellingTheReservation_ReturnTrue()
        {
            var user = new User();
            //Arrange
            var reservation = new Reservation { MadeBy = user };
            //Act
            var result = reservation.CanBeCancelledBy(user);
            //Assert
            Assert.IsTrue(result);

        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnFalse()
        {
            //Arrange
            var reservation = new Reservation { MadeBy = new User() };
            //Act
            var result = reservation.CanBeCancelledBy(new User());
            //Assert
            Assert.IsFalse(result);
        }
    }
}
