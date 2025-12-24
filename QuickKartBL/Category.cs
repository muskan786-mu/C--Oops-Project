using System;
using System.Collections.Generic;
using System.Text;

namespace QuickKartBL
{
    public class Category
    {
        //private byte categoryId;
        //private string categoryName;
        public byte CategoryId { get; set; } = 1;
        public string CategoryName { get; set; } = "No value assigned";
        public Category(byte categoryId, string categoryName)
        {
            this.CategoryId = categoryId;
            this.CategoryName = categoryName;
        }
        //Indexer allows array-like access to class data keeping the data private and protected
        public object this[int indexNumber]
        {
            get
            {
                if (indexNumber == 0)
                    return this.CategoryId;
                else if (indexNumber == 1)
                    return this.CategoryName;
                else
                    return 0;
            }
            set
            {
                if(indexNumber == 0)
                    this.CategoryId = Convert.ToByte(value);
                else if(indexNumber == 1)
                    this.CategoryName = Convert.ToString(value);
            }
        }
        
        //public string CategoryName
        //{
        //    get { return this.categoryName; }
        //    set
        //    {
        //        if (value != null)
        //        {
        //            this.categoryName = value;
        //        }
        //        else
        //        {
        //            this.categoryName = "No Name Assigned";
        //        }
        //    }
        //}
        //public byte CategoryId
        //{
        //    get { return this.categoryId; }
        //    set
        //    {
        //        if (value != 0)
        //        {
        //            this.categoryId = value;
        //        }
        //        else
        //        {
        //            this.categoryId = 1;
        //        }
        //    }
        //}
    }
}