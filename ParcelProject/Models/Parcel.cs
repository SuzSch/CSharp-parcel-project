using System.Collections.Generic;
using ParcelProject.Models;

namespace ParcelProject.Models
{
    public class Parcel
    {
        public Parcel(int width)
        {
            Width = width;
        }
        public int Width
        {
            get; set;
        }

        public Contact ParcelContact { get; set; } = new Contact("Sarah Smith", "sarah@gmail.com", "123-456-5678");

    }
}
