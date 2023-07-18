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
        public void Width_GetWidth_Int()
        {
            Parcel myParcel = new Parcel(34);
            int Width = myParcel.Width;
            Assert.AreEqual(myParcel.Width, 34);
        }

        [TestMethod]
        public void ParcelContact_MakeContactForParcel_Contact()
        {
            Parcel myParcel = new Parcel(34);

            Contact expectedContact = new Contact("Sarah Smith", "sarah@gmail.com", "123-456-5678");
            string expectedValue = JsonSerializer.Serialize(myParcel.ParcelContact);
            string realValue = JsonSerializer.Serialize(expectedContact);
            Assert.AreEqual(expectedValue, realValue);
            // Parcel myParcel = new Parcel(34);
            // int Width = myParcel.Width;
            // Assert.AreEqual(myParcel.Width, 34);
        }
    }
}
