using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanThatCode.Community.Repositories;

namespace CleanThatCode.Community.Tests {

    [TestClass]
    public class CommentRepositoryTests {
        
        [TestMethod]
        public void GetAllCommentsByPostId_GivenWrongPostId_ShouldReturnNoComments() {
            //Ef að er gefið invalid post ID, asserta result á lengd 0
            

        }

        [TestMethod]
        public void GetAllCommentsByPostId_GivenValidPostId_ShouldReturnTwoComments() {
            //Ef að gefið er valid post ID, asserta result á lengd 2
        }

    }
}