using Moq;
using SchoolLibrary;

namespace TestProject
{
    [TestFixture]
    public class SchoolDataTests
    {
        [Test]
        public void Teacher_GetName_ShouldReturnCorrectName()
        {
            // Arrange
            var teacher = new Teacher { TeacherId = 1, Name = "John Doe" };

            // Act
            var result = teacher.Name;

            // Assert
            Assert.AreEqual("John Doe", result);
        }

        

        [Test]
        public void GetAllBooksForCategory_returns_list_of_available_books()
        {
            //1
            var bookServiceStub = new Mock<IBookService>();
            //2
            bookServiceStub
                .Setup(x => x.GetBooksForCategory("UnitTesting"))
                .Returns(new List<string>
                {
            "The Art of Unit Testing",
            "Test-Driven Development",
            "Working Effectively with Legacy Code"
                });
            //3
            var accountService = new AccountService(bookServiceStub.Object);
            IEnumerable<string> result = accountService.GetAllBooksForCategory("UnitTesting");
            Assert.AreEqual(3, result.Count());
        }
    }
}