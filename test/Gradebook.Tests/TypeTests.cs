using System;
using Xunit;
using GradeBook;

namespace Gradebook.Tests
{
    public class TypeTests
    {
       
         [Fact]
        public void StringsBehaveLikeValueTypes()
        {
           string name = "Scott";
           var upper = MakeUppercase(name);
           MakeUppercase(name); 

           Assert.Equal("Scott", name);
           Assert.Equal("SCOTT", upper);
        }

        private string MakeUppercase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void Test1()
        {
            var x = Getint();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int z)
        {
            z = 42;
        }

        private int Getint()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
           var book1 = GetBook("Book1");
           GetBookSetName(ref book1, "New Name");

           Assert.Equal("New Name", book1.Name);
           
        }
        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpISPAssByValue()
        {
           var book1 = GetBook("Book1");
           GetBookSetName(book1, "New Name");

           Assert.Equal("Book1", book1.Name);
           
        }
        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
           var book1 = GetBook("Book1");
           SetName(book1, "New Name");

           Assert.Equal("New Name", book1.Name);
           
        }
        private void SetName(Book book, string name)
        {
            book.Name = name;
        }
        
        [Fact]
        public void BookCalculatesDifferentObject()
        {
           var book1 = GetBook("Book1");
           var book2 = GetBook("Book2");

           Assert.Equal("Book1", book1.Name);
           Assert.Equal("Book2", book2.Name);
        }
        [Fact]
        public void TwoVarSCanReferenceSameObject()
        {
           var book1 = GetBook("Book1");
           var book2 = book1;

           Assert.Same(book1, book2);
           Assert.True(Object.ReferenceEquals(book1, book2));
        }
        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
