using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReceipeStoreServices.Models
{
    public class Receipe 
    {
        private string _name;
        private List<string> _ingredients;
        private List<string> _instructions;
        private int cookingTime;
        private int preparationTime;
        private int _reciepeTypeID;
        private string seasonal;
        private string festival;
        private int _cuisinetypeID;
        private bool _isHealthy;
        private bool _isDiabetic;


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
            this._name = Name;
            this._ingredients = Ingedients;
            this._instructions = Instructions;
            this.cookingTime = CookingTime;
            this.preparationTime = PreparationTime;
            this._isDiabetic = IsDiabetic;
            this._isHealthy = IsHealthy;
            this._reciepeTypeID = ReceipeTypeID;
            this._cuisinetypeID = cuisineType;
        }
        public Receipe(string Name, List<string> Ingedients, List<string> Instructions, int CookingTime, int PreparationTime, bool IsHealthy, bool IsDiabetic, string Seasonal)
        {
            this._name = Name;
            this._ingredients = Ingedients;
            this._instructions = Instructions;
            this.cookingTime = CookingTime;
            this.preparationTime = PreparationTime;
            this._isDiabetic = IsDiabetic;
            this._isHealthy = IsHealthy;
            this.seasonal = Seasonal;
        }
        public Receipe(string Name, List<string> Ingedients, List<string> Instructions, int CookingTime, int PreparationTime, string Festival, bool IsHealthy, bool IsDiabetic)
        {
            this._name = Name;
            this._ingredients = Ingedients;
            this._instructions = Instructions;
            this.cookingTime = CookingTime;
            this.preparationTime = PreparationTime;
            this._isDiabetic = IsDiabetic;
            this.festival = Festival;
            this._isHealthy = IsHealthy;
        }

        public Receipe()
        {
            // TODO: Complete member initialization
        }
    }
}