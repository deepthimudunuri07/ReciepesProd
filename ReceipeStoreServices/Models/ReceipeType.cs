using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReceipeStoreServices.Models
{
    public class ReceipeType
    {
        private string _category;
        private string _cuisine;



        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }

        public string Cuisine
        {
            get
            {
                return _cuisine;
            }
            set
            {
                _cuisine = value;
            }
        }



        public ReceipeType(string Category, string Cuisine, bool ishealthy)
        {
            this._category = Category;
            this._cuisine = Cuisine;

        }
    }
}