using MongoDB.Bson;

namespace ReceipeStoreServices.DatabaseEntities
{
    public class DbReceipeType
    {
        public ObjectId _id { get; set; }
        public int ReciepeID { get; set; }
        public string Name { get; set; }


        public DbReceipeType(int Id, string name)
        {
            ReciepeID = Id;
            Name = name;
           
        }
   
        
    }
}