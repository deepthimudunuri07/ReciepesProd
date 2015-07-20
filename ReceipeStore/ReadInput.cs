using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using ReceipeStoreServices.Models;

namespace ReceipeStoreServices
{
    public class ReadInput
    {

        private void ReadfromInput(string fileName)
        {
            if (System.IO.Directory.Exists(fileName))
            {
                var fullFileName = string.Format("{0}@\\" + fileName, Directory.GetCurrentDirectory());
                var connectionString =
                    string.Format("Provider=Microsoft.Jet.OLEDB.4.0;datasource={0};Extended Properties=Excel 8.0;",
                        fullFileName);
                var ds = new DataSet();
                var adapter = new OleDbDataAdapter("Select * from [TestFile]", connectionString);
                adapter.Fill(ds, "MyTest");
                var data = ds.Tables["TestTables"].AsEnumerable();

                var query = data.Where(x => x.Field<string>("seasonal") == string.Empty).Select(x =>
                    new Receipe(x.Field<string>("Name"), new List<string>(new String[] { "first", "second" }), new List<string>(new String[] { "first", "second" }), x.Field<int>("CookingTime"), x.Field<int>("PreparationTime"), x.Field<bool>("IsHealthy"), x.Field<bool>("IsDiabetic"), x.Field<int>("ReceipeTypeID"), x.Field<int>("CuisineTyepID"))
                    {
                        
                        
                        Name = x.Field<string>("Name"),
                        Ingredients = new List<string>(new String[]{"first","second"}),
                        Instructions = new List<string>(new String[] { "first" }),
                        CookingTime = x.Field<int>("CookingTime"),
                        PreparationTime = x.Field<int>("PreparationTime"),
                        IsHealthy = x.Field<bool>("IsHealthy"),
                        IsDiabetic = x.Field<bool>("IsDiabetic"),
                        ReceipeTypeID = x.Field<int>("ReceipeTypeID"),
                        CuisineTypeID =x.Field<int>("CuisineTyepID")

                    });

            }
        }
    }
}