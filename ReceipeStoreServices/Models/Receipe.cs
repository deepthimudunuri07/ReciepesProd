using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReceipeStoreServices.Models
{
    public class Receipe 
    {
        


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
        public string Seasonal
        {
            get;
            set;
        }
        public string Festival
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

        public int CuisineTypeID { get; set; }

        public int ReceipeTypeID { get; set; }

        public Receipe(string Name, List<string> Ingedients, List<string> Instructions, int CookingTime, int PreparationTime, bool IsHealthy, bool IsDiabetic, int receipeTypeID, int cuisineType)
        {
            this.CookingTime = CookingTime;
            CuisineTypeID = cuisineType;
            this.Name = Name;
            Ingredients = Ingedients;
            this.PreparationTime = PreparationTime;
            this.IsDiabetic = IsDiabetic;
            ReceipeTypeID = receipeTypeID;
            this.Instructions = Instructions;
            this.IsHealthy = IsHealthy;
        }
        public Receipe(string Name, List<string> Ingedients, List<string> Instructions, int CookingTime, int PreparationTime, bool IsHealthy, bool IsDiabetic, string Seasonal)
        {
            this.CookingTime = CookingTime;
           this.Seasonal = Seasonal;
            this.Name = Name;
            Ingredients = Ingedients;
            this.PreparationTime = PreparationTime;
            this.IsDiabetic = IsDiabetic;
           
            this.Instructions = Instructions;
            this.IsHealthy = IsHealthy;
        }
        public Receipe(string Name, List<string> Ingedients, List<string> Instructions, int CookingTime, int PreparationTime, string Festival, bool IsHealthy, bool IsDiabetic)
        {
            this.CookingTime = CookingTime;
            this.Festival = Festival;
            this.Name = Name;
            Ingredients = Ingedients;
            this.PreparationTime = PreparationTime;
            this.IsDiabetic = IsDiabetic;
           
            this.Instructions = Instructions;
            this.IsHealthy = IsHealthy;
        }

        public Receipe()
        {
            // TODO: Complete member initialization
        }
    }
}