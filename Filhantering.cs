using System;
using System.IO;
using System.ComponentModel;

namespace KassaSystem
{
    public class Filhantering
    {
        Controller co;

        public void ControllerConnection(Controller controll)
        {
            co = controll;
        }
        //Läser från "Inventory.csv"
        public void ReadFromFile()
        {
            if (File.Exists("Inventory.csv"))
            {
                StreamReader reader = new StreamReader("Inventory.csv");
                while (!reader.EndOfStream)
                {
                    string data = reader.ReadLine();
                    co.loadCsvFile(data);
                }
                reader.Close();
            }
        }

        public void WriteToFile(BindingList<Product> productList)
        {
            using (StreamWriter writer = new StreamWriter("Inventory.csv", false))
            {
                foreach (Product p in productList)
                {
                    writer.WriteLine(String.Join(",", p.ID, p.Amount, p.Name, p.Price, p.Type,
                                                      p.Format, p.Genre, p.Author, p.Language,
                                                      p.Platform, p.Playtime));

                }
                writer.Close();
            }
        }
    }
}




