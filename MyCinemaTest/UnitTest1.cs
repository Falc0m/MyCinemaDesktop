using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCinema;
using MyCinema2;

namespace MyCinemaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_DatabaseConnection()
        {

            List<Movie> movieList = Utils.AllDocumentsToList();

            Assert.AreNotEqual(movieList, null);
        }

        [TestMethod]
        public void Test_DatabaseInsertion()
        {

            Movie movie = new Movie("Test title", "Test category", 0, "Test description", DateTime.Now, DateTime.Now);

            Assert.AreEqual(Utils.InsertDocument(movie), true);
        }


    }
}
