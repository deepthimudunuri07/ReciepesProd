using MongoDB.Bson;

namespace ReceipeStoreServices.DatabaseEntities
{
    public class DbReceipeType
    {
        public ObjectId _id { get; set; }
        public int ReciepeID { get; set; }
        public string Name { get; set; }


        public DbReceipeType( ObjectId _id, int Id, string name)
        {
            this._id = _id;
            ReciepeID = Id;
            Name = name;
           
        }
   
        
    }
}