﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SokolovaAA.Sprint2.Task5.V3.Lib;
namespace Tyuiu.SokolovaAA.Sprint2.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindDayNameValid()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Понедельник", ds.FindDayName(1));
            Assert.AreEqual("Вторник", ds.FindDayName(2));
            Assert.AreEqual("Среда", ds.FindDayName(3));
            Assert.AreEqual("Четверг", ds.FindDayName(4));
            Assert.AreEqual("Пятница", ds.FindDayName(5));
            Assert.AreEqual("Суббота", ds.FindDayName(6));
            Assert.AreEqual("Воскресенье", ds.FindDayName(7));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(8);
            });
        }
    }
}
