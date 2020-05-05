using System;
using Xunit;
using Fisher.Bookstore.Models;

namespace Fisher.Bookstore.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AddBookPrice()
        {
            //Arrange
            var Book = new Book()
            {
                Id = 1,
                Title = "My Test Book",
                Price = 9.99
            };

            //Act
            Book.ApplyMemberDiscount();

            //Assert
            var discountPrice = 9.99 * .9;
            Assert.Equal(discountPrice, Book.Price);
        }
    }
}
