namespace Resturant.UnitTesting
{
    [TestClass]
    public class ReservationUnitTest
    {
        [TestMethod]
        public void CancelReservation_CancelByAdmin_ReturnTrue()
        {
            //Arrange
            var resturantOwner = new User
            {
                Id = 1,
                Name = "Hanaa",
                Email = "hanaa@test.com",
                IsAdmin = true,
            }; 

            var order = new ReservationOrder
            {
                Id = 1,
                MadeBy = resturantOwner,
                Table = new Table
                {
                    Id = 1,
                    ChairsNumber = 3
                }
            };

            //Act
            var result = order.CancelReservation(new User
            {
                Id = 1,
                Name = "Mohammed", 
                Email = "mohammed@test.com", 
                IsAdmin = true
            });

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CancelReservation_CancelBySameUser_ReturnTrue()
        {
            //Arrange
            var resturantOwner = new User
            {
                Id = 1,
                Name = "Hanaa",
                Email = "hanaa@test.com",
                IsAdmin = false,
            };

            var order = new ReservationOrder
            {
                Id = 1,
                MadeBy = resturantOwner,
                Table = new Table
                {
                    Id = 1,
                    ChairsNumber = 3
                }
            };

            //Act
            var result = order.CancelReservation(resturantOwner);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CancelReservation_CancelByAnotherUser_ReturnFalse()
        {
            //Arrange
            var order = new ReservationOrder
            {
                Id = 1,
                MadeBy = new User
                {
                    Id = 1,
                    Name = "Hanaa",
                    Email = "hanaa@test.com",
                    IsAdmin = true,
                },
                Table = new Table
                {
                    Id = 1,
                    ChairsNumber = 3
                }
            };

            //Act
            var result = order.CancelReservation(new User
            {
                Id = 1,
                Name = "Mohammed",
                Email = "mohammed@test.com",
                IsAdmin = false
            });

            //Assert
            Assert.IsFalse(result);
        }
    }
}