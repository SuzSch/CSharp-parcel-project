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
