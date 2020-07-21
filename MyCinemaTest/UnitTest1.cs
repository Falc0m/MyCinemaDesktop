using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCinema;

namespace MyCinemaTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test method testing fetching documents from database
        /// </summary>
        [TestMethod]
        public void Test_DatabaseConnection()
        {

            List<Movie> movieList = Utils.AllDocumentsToList();

            Assert.AreNotEqual(movieList, null);
        }

        /// <summary>
        /// Test method testing inserting documents into database
        /// </summary>
        [TestMethod]
        public void Test_DatabaseInsertion()
        {

            Movie movie = new Movie("Test title", "Test category", 0, "Test description", DateTime.Now, DateTime.Now);

            Assert.AreEqual(Utils.InsertDocument(movie), true);
        }


    }
}
