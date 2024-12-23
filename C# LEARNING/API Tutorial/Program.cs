using System;
using System.Linq;
using System.Numerics;
using APITutorial.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using APITutorial.Data;

namespace APITutorial
{
    public class Program 
    {
        static void Main(string [] args)
        {
            DataContextDapper dapper = new DataContextDapper();
            DataContexEF entityFramework = new DataContextEF();

            DateTime rightNow = dapper.LoadDataSingle<DateTime>("SELECT GETDATE()");
            //Console.WriteLine(rightNow);


            //instance of the model class
            Computer myComputer = new Computer()
            {
                Motherboard = "A2400",
                HasWifi = true,
                HasLTE = false,
                ReleaseDate = DateTime.Now,
                Price = 500,
                VideoCard = "RTX 2060"
            };

            entityFramework.Add(myComputer);
            entityFramework.SaveChanges();

            //Sequel statment passed into the execute statment
            string sql = @"INSERT INTO TutorialAppSchema.Computer (
                Motherboard,
                HasWifi,
                HasLTE,
                ReleaseDate,
                Price,
                VideoCard
            )VALUES ('" + myComputer.Motherboard 
                    + "','" + myComputer.HasWifi 
                    + "','" + myComputer.HasLTE  
                    + "','" + myComputer.ReleaseDate  
                    + "','" + myComputer.Price 
                    + "','" + myComputer.VideoCard 
            + "')";

            //Console.WriteLine(sql);

            //int result = dapper.ExecuteSqlWithRowCount(sql);            //execute statment running with dapper
            bool result = dapper.ExecuteSql(sql);

            //Console.WriteLine(result);

            string sqlSelect = @"
            SELECT 
                Computer.ComputerId,
                Computer.Motherboard,
                Computer.HasWifi,
                Computer.HasLTE,
                Computer.ReleaseDate,
                Computer.Price,
                Computer.VideoCard
             FROM TutorialAppSchema.Computer";

            IEnumerable<Computer> computers = dapper.LoadData<Computer>(sqlSelect);

            Console.WriteLine("'ComputerId', 'Motherboard','HasWifi','HasLTE','ReleaseDate','Price','VideoCard'");

            foreach (Computer singleComputer in computers)
            {
                Console.WriteLine("'" + singleComputer.ComputerId
                    + "','" + singleComputer.Motherboard  
                    + "','" + singleComputer.HasWifi 
                    + "','" + singleComputer.HasLTE  
                    + "','" + singleComputer.ReleaseDate  
                    + "','" + singleComputer.Price 
                    + "','" + singleComputer.VideoCard + "'");
            }

            IEnumerable<Computer>? computersEf = entityFramework.Computer?.ToList<Computer>();

            if (computersEf != null)
            {
                Console.WriteLine("'ComputerId','Motherboard','HasWifi','HasLTE','ReleaseDate','Price','VideoCard'");

                foreach (Computer singleComputer in computersEf
                )
                {
                    Console.WriteLine("'" + singleComputer.ComputerId
                        + "','" + singleComputer.Motherboard 
                        + "','" + singleComputer.HasWifi 
                        + "','" + singleComputer.HasLTE  
                        + "','" + singleComputer.ReleaseDate  
                        + "','" + singleComputer.Price 
                        + "','" + singleComputer.VideoCard + "'");
                }
            }


            //myComputer.HasWifi = false;
            // Console.WriteLine(myComputer.Motherboard);
            // Console.WriteLine(myComputer.HasWifi);
            // Console.WriteLine(myComputer.VideoCard);
            // Console.WriteLine(myComputer.ReleaseDate);
        }
    }
}
