using System.Collections.Generic;

namespace Parcel.Models
{
    public class Item
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public int Volume { get; set; }
        public int Cost { get; set; }

        public Item (int weight, int height, int width, int length)
        {
            Weight = weight;
            Height = height;
            Width = width;
            Length = length;
            Volume = 0;
            Cost = 0;
        }

        public int GetVolume()
        {
            int findVolume = (Height * Width * Length);
            Volume = findVolume;
            return Volume;
        }

        public int GetCost()
        {
            if (Volume > 30000)
            {
                Cost = Weight + (Volume/1000);
            }
            else
            {
                Cost = Weight + (Volume/2000);
            }
            return Cost;
        }
    }
}