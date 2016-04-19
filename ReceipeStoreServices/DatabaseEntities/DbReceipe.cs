using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace ReceipeStoreServices.DatabaseEntities
{
    public class DbReceipe
    {
        


        public ObjectId id { get; set; }
        public int ReciepeID { get; set; }


        public string Name
        {
            get;
            set;
        }
        public List<string> Ingredients
        {
            get;
            set;
        }
        public List<string> Instructions
        {
            get;
            set;
        }
        public int CookingTime
        {
            get;
            set;
        }
        public int PreparationTime
        {
            get;
            set;
        }
        public bool IsSeasonal
        {
            get;
            set;
        }
        public bool IsFestive
        {
            get;
            set;
        }
        public bool IsHealthy
        {
            get;
            set;
        }
        public bool IsDiabetic
        {
            get;
            set;
        }

        public string ImageUrl { get; set; }

        public int CuisineType { get; set; }

        public int ReciepeType { get; set; }

        public DbReceipe(int id,string Name, List<string> Ingedients, List<string> Instructions, int CookingTime, int PreparationTime, bool IsHealthy, bool IsDiabetic, int receipeTypeID, int cuisineType,string _imageurl)
        {
            this.ReciepeID = id;
            this.CookingTime = CookingTime;
            CuisineType = cuisineType;
            this.Name = Name;
            Ingredients = Ingedients;
            this.PreparationTime = PreparationTime;
            this.IsDiabetic = IsDiabetic;
            ReciepeType = receipeTypeID;
            this.Instructions = Instructions;
            this.IsHealthy = IsHealthy;
            this.ImageUrl = _imageurl;
        }
        public DbReceipe(int Id,string Name, List<string> Ingedients, List<string> Instructions, int CookingTime, int PreparationTime, bool IsHealthy, bool IsDiabetic, bool Seasonal,string _imageUrl)
        {
            this.ReciepeID = Id;
            this.CookingTime = CookingTime;
           this.IsSeasonal = Seasonal;
            this.Name = Name;
            Ingredients = Ingedients;
            this.PreparationTime = PreparationTime;
            this.IsDiabetic = IsDiabetic;
           
            this.Instructions = Instructions;
            this.IsHealthy = IsHealthy;
            this.ImageUrl = _imageUrl;
        }
        public DbReceipe(string Name, List<string> Ingedients, List<string> Instructions, int CookingTime, int PreparationTime, bool Festival, bool IsHealthy, bool IsDiabetic)
        {
            this.CookingTime = CookingTime;
            this.IsFestive = Festival;
            this.Name = Name;
            Ingredients = Ingedients;
            this.PreparationTime = PreparationTime;
            this.IsDiabetic = IsDiabetic;
           
            this.Instructions = Instructions;
            this.IsHealthy = IsHealthy;
        }

        public DbReceipe()
        {
            // TODO: Complete member initialization
        }
    }
}
   