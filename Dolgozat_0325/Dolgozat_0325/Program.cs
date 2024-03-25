using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_0325
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kolcsonzok> kolcsonzok = new List<Kolcsonzok>();
            List<Kolcsonzesek> kolcsonzesek = new List<Kolcsonzesek>();
            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/diak/Documents/Plesovszki Iszvan/dolgozat/Forras/csv/Kolcsonzok.csv"))
                {
                    string line = sr.ReadLine();
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        string[] splited = line.Split(';');
                        DateTime date = Convert.ToDateTime(splited[1]);
                        string name = splited[0];
                        kolcsonzok.Add(new Kolcsonzok(name, date));
                        line = sr.ReadLine();
                    }
                    sr.Close();

                }
                
                using (StreamReader sr = new StreamReader("C:/Users/diak/Documents/Plesovszki Iszvan/dolgozat/Forras/csv/Kolcsonsesek.csv"))
                {
                    string line = sr.ReadLine();
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        string[] splited = line.Split(';');
                        int kolcsonzoid = Convert.ToInt32(splited[0]);
                        string name = splited[0];
                        kolcsonzesek.Add(new Kolcsonzesek(kolcsonzoid, splited[1], splited[2], splited[3]));
                        line = sr.ReadLine();
                    }
                    sr.Close();

                }

            }
            catch (Exception)
            {

                Console.WriteLine("Hibás file");
            }

            try
            {
                string conectionString = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection mySql = new MySqlConnection(conectionString);
                foreach (var kolcsonzo in kolcsonzok)
                {
                    string query = "insert into konyvtar.kolcsonzok(nev,szulido) values('" + kolcsonzo.nev + "','" + kolcsonzo.szulIdo + "');";
                    MySqlCommand command = new MySqlCommand(query, mySql);
                    mySql.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    mySql.Close();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

            try
            {
                string conectionString = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection mySql = new MySqlConnection(conectionString);
                foreach (var kolcsonzes in kolcsonzesek)
                {
                    string query = "insert into konyvtar.kolcsonzesek(kolcsonzokId ,iro, mufaj, cim) values('" + kolcsonzes.kolcsonzoId + "','" + kolcsonzes.iro + "','" + kolcsonzes.mufaj + "','" + kolcsonzes.cim + "');";
                    MySqlCommand command = new MySqlCommand(query, mySql);
                    mySql.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    mySql.Close();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }
    }
}
