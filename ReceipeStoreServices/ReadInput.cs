using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

using ReceipeStoreServices.Models;


namespace ReceipeStore
{
    public class ReadInput
    {

        public List<Receipe> ReadfromInput(string fileName)
        {

            List<Receipe> myReceipes = new List<Receipe>();
            if (System.IO.File.Exists(fileName))
            {
                var fullFileName = string.Format("{0}@\\" + fileName, Directory.GetCurrentDirectory());
                OleDbConnection connectionString =
                    new OleDbConnection(
                        string.Format(
                            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0; HDR = Yes';",
                            fileName));

                var ds = new DataSet();
                var adapter = new OleDbDataAdapter("SELECT * from [Name$]", connectionString);
                connectionString.Open();
                adapter.Fill(ds);

                DataTable dt = new DataTable();
                dt = ds.Tables[0];
              //  var data = ds.Tables[0].AsEnumerable();
              //(data.Where(x => x.Field<string>("seasonal") == string.Empty).Select(x =>
              //      new Receipe(x.Field<string>("Name"), new List<string>(new String[] { "first", "second" }), new List<string>(new String[] { "first", "second" }), x.Field<int>("CookingTime"), x.Field<int>("PreparationTime"), x.Field<bool>("IsHealthy"), x.Field<bool>("IsDiabetic"), x.Field<int>("ReceipeTypeID"), x.Field<int>("CuisineTyepID"))
              //      {


              //      }));



                foreach (DataRow row in dt.Rows)
                {

                    myReceipes.Add(new Receipe(Convert.ToInt16(row["ReciepeID"]),row["Name"].ToString(), new List<string>(new String[] { "first", "second" }),
                              new List<string>(new String[] { "first", "second" }), Convert.ToInt16(row["CookingTime"]),
                              Convert.ToInt16(row["PreparationTime"]), (bool)row["IsHealthy"], (bool)row["IsDiabetic"], Convert.ToInt16(row["ReciepeType"]),
                              Convert.ToInt16(row["CusineTypeID"])));
                    
                    }

              
                
            }

            return myReceipes;
        }

    }
}