using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;


namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();


            List<clsStock> TestList = new List<clsStock>();


            clsStock TestItem = new clsStock();

            TestItem.GameID = 6;
            TestItem.GameName = "Test Name";
            TestItem.Price = 12;
            TestItem.Availability = true;
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.AgeRating = 12;

            TestList.Add(TestItem);

            AllStock.StockList = TestList;

            Assert.AreEqual(AllStock.StockList, TestList);
        }

        

        [TestMethod]
        public void ThisStockOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestStock = new clsStock();

            TestStock.GameID = 6;
            TestStock.GameName = "Test Name";
            TestStock.Price = 12;
            TestStock.Availability = true;
            TestStock.ReleaseDate = DateTime.Now.Date;
            TestStock.AgeRating = 12;

            AllStock.ThisStock = TestStock;

            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();


            List<clsStock> TestList = new List<clsStock>();


            clsStock TestItem = new clsStock();

            TestItem.GameID = 6;
            TestItem.GameName = "Test Name";
            TestItem.Price = 12;
            TestItem.Availability = true;
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.AgeRating = 12;

            TestList.Add(TestItem);

            AllStock.StockList = TestList;

            Assert.AreEqual(AllStock.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestItem = new clsStock();

            Int32 PrimaryKey = 0;

            TestItem.GameID = 6;
            TestItem.GameName = "Test Name";
            TestItem.Price = 12;
            TestItem.Availability = true;
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.AgeRating = 12;

            AllStock.ThisStock = TestItem;

            PrimaryKey = AllStock.Add();

            TestItem.GameID = PrimaryKey;

            AllStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethdOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestItem = new clsStock();

            Int32 PrimaryKey = 0;

            TestItem.GameID = 6;
            TestItem.GameName = "Test Name";
            TestItem.Price = 12;
            TestItem.Availability = true;
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.AgeRating = 12;

            AllStock.ThisStock = TestItem;

            PrimaryKey = AllStock.Add();

            TestItem.GameID = PrimaryKey;

            TestItem.GameID = 7;
            TestItem.GameName = "Test Name Two";
            TestItem.Price = 13;
            TestItem.Availability = true;
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.AgeRating = 13;

            AllStock.ThisStock = TestItem;

            AllStock.Update();

            AllStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethdOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestItem = new clsStock();

            Int32 PrimaryKey = 0;

            TestItem.GameID = 6;
            TestItem.GameName = "Test Name";
            TestItem.Price = 12;
            TestItem.Availability = true;
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.AgeRating = 12;

            AllStock.ThisStock = TestItem;

            PrimaryKey = AllStock.Add();

            TestItem.GameID = PrimaryKey;

            AllStock.ThisStock.Find(PrimaryKey);

            AllStock.Delete();

            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportbyGameNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection AllStock = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a blank string (should return all records);
            FilteredStock.ReportByGameName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByGameNameNoneFound()
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a game name that doesnt exist
            FilteredStock.ReportByGameName("xxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStock.Count);
        }























































    }
}
