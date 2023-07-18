using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ParcelProject.Models;
using System;
using System.Text.Json;

namespace ParcelProject.Test
{
    [TestClass]
    public class ParcelTests
    {
        // public void Dispose()
        // {
        //     // Parcel.ClearAll();
        // }
        [TestMethod]
        public void Dimensions_GetDimensions_Int()
        {
            Parcel myParcel = new Parcel(34, 20, 10, 50);
            int Width = myParcel.Width;
            int Lenght = myParcel.Length;
            int Height = myParcel.Height;
            int Weight = myParcel.Weight;
            Assert.AreEqual(myParcel.Width, 34);
            Assert.AreEqual(myParcel.Length, 20);
            Assert.AreEqual(myParcel.Height, 10);
            Assert.AreEqual(myParcel.Weight, 50);
        }

        [TestMethod]
        public void Volume_CalculateVolume_Int()
        {
            Parcel myParcel = new Parcel(2, 3, 4, 10);
            int expectedVolume = 24;
            int actualVolume = myParcel.GetVolume();
            Assert.AreEqual(expectedVolume, actualVolume);
        }

        [TestMethod]
        public void CostToShip_CalculateCost_Int()
        {
            Parcel myParcel = new Parcel(2, 3, 4, 10);
            int expectedCostSmVolume = 48;
            int actualCostSmVolume = myParcel.CostToShip();
            Assert.AreEqual(expectedCostSmVolume, actualCostSmVolume);
        }

        [TestMethod]
        public void ParcelContact_MakeContactForParcel_Contact()
        {
            Parcel myParcel = new Parcel(34, 20, 10, 50);

            Contact expectedContact = new Contact("Sarah Smith", "sarah@gmail.com", "123-456-5678");
            string expectedValue = JsonSerializer.Serialize(myParcel.ParcelContact);
            string realValue = JsonSerializer.Serialize(expectedContact);
            Assert.AreEqual(expectedValue, realValue);
        }
    }
}
