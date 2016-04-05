using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReceipeStoreServices.Models
{
    public class ReceipeType
    {
        public int ReciepeID { get; set; }
        public string Name { get; set; }

        public ReceipeType(int id, string name)
        {
            
            Name = name;
            ReciepeID = id;
        }
    }
}