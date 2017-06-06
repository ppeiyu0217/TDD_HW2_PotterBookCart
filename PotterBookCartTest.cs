using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class PotterBookCartTest
    {
        [TestMethod]
        public void BuyBookCount_1_0_0_0_0_Price_100()
        {
            //arrage
            List<int> bookCount = new List<int>() { 1, 0, 0, 0, 0 };

            //act
            var target = new GetBookPrice();
            var actual = target.CalculatePrice(bookCount);
            //assert
            var expect = 100;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void BuyBookCount_1_1_0_0_0_Price_190()
        {
            //arrage
            List<int> bookCount = new List<int>() { 1, 1, 0, 0, 0 };

            //act
            var target = new GetBookPrice();
            var actual = target.CalculatePrice(bookCount);
            //assert
            var expect = 190;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void BuyBookCount_1_1_1_0_0_Price_270()
        {
            //arrage
            List<int> bookCount = new List<int>() { 1, 1, 1, 0, 0 };

            //act
            var target = new GetBookPrice();
            var actual = target.CalculatePrice(bookCount);
            //assert
            var expect = 270;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void BuyBookCount_1_1_1_1_0_Price_320()
        {
            //arrage
            List<int> bookCount = new List<int>() { 1, 1, 1, 1, 0 };

            //act
            var target = new GetBookPrice();
            var actual = target.CalculatePrice(bookCount);
            //assert
            var expect = 320;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void BuyBookCount_1_1_1_1_1_Price_375()
        {
            //arrage
            List<int> bookCount = new List<int>() { 1, 1, 1, 1, 1 };

            //act
            var target = new GetBookPrice();
            var actual = target.CalculatePrice(bookCount);
            //assert
            var expect = 375;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void BuyBookCount_1_1_2_0_0_Price_370()
        {
            //arrage
            List<int> bookCount = new List<int>() { 1, 1, 2, 0, 0 };

            //act
            var target = new GetBookPrice();
            var actual = target.CalculatePrice(bookCount);
            //assert
            var expect = 370;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void BuyBookCount_1_2_2_0_0_Price_460()
        {
            //arrage
            List<int> bookCount = new List<int>() { 1, 1, 2, 2, 0 };

            //act
            var target = new GetBookPrice();
            var actual = target.CalculatePrice(bookCount);
            //assert
            var expect = 460;
            Assert.AreEqual(expect, actual);
        }
    }
}
