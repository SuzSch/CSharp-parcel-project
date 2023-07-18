using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ParcelProject.Models;
using System;

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
    }
}
