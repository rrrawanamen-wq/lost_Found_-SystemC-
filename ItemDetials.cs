using System;

namespace WinFormsApp6 
{
    public enum ItemCategory { Electronics, Books, Tools,Clothes, Oth ers }

    public class LostItem
    {
        public ItemCategory Category { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public DateTime DateFound { get; set; }
        public string ImagePath { get; set; } 

        public LostItem(ItemCategory cat, string desc, string phone, string loc, DateTime date, string img)
        {
            Category = cat;
            Description = desc;
            Phone = phone;
            Location = loc;
            DateFound = date;
            ImagePath = img;
        }
    }
}
