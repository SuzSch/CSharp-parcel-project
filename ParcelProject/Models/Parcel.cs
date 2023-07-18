using System.Collections.Generic;
using ParcelProject.Models;

namespace ParcelProject.Models
{
    public class Parcel
    {
        public Parcel(int width, int length, int height, int weight)
        {
            Width = width;
            Length = length;
            Height = height;
            Weight = weight;
        }
        public int Width
        {
            get; set;
        }
        public int Length
        {
            get; set;
        }
        public int Height
        {
            get; set;
        }

        public int Weight
        {
            get; set;
        }

        public Contact ParcelContact { get; set; } = new Contact("Sarah Smith", "sarah@gmail.com", "123-456-5678");

    }
}
