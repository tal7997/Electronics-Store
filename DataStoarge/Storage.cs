
using System.Collections.Generic;
using System.IO;
using WinFormsApp1.NewFolder;

namespace WinFormsApp1.DataStoarge
{
    public static class Storage
    {
        public static List<Item> Stock { get; set; }
        public static List<Item> Cart { get; set; }
        static Storage()
        {
            Stock = LoadData();
            Cart = new List<Item>();
        }

        public static void SaveData()
        {
            if (File.Exists("Temp_FILE.txt"))
                File.Delete("Temp_FILE.txt");
            foreach (Item item in Stock)
                File.AppendAllText("Temp_FILE.txt", item.ToString() + "\r\n");
        }
        public static List<Item> LoadData()
        {
            Stock = new List<Item>();
            if (File.Exists("Temp_FILE.txt"))
            {
                string[] lines = File.ReadAllLines("Temp_FILE.txt");
                foreach (string line in lines)
                {
                    string[] sublines = line.Split(" ");
                    if (line.Contains("Refrigetor"))
                        Stock.Add(new NewFolder.Refrigerator(sublines[6], int.Parse(sublines[10]), int.Parse(sublines[12]), int.Parse(sublines[14])));
                    else if (line.Contains("Kettle"))
                        Stock.Add(new NewFolder.Kettle(sublines[6], int.Parse(sublines[10]), double.Parse(sublines[12])));
                    else if (line.Contains("Oven"))
                        Stock.Add(new NewFolder.Oven(sublines[6], int.Parse(sublines[10]), int.Parse(sublines[12]), int.Parse(sublines[14])));
                    else if (line.Contains("PowerStrip"))
                        Stock.Add(new NewFolder.PowerStrip(int.Parse(sublines[6])));
                }
            }

            
            return Stock;
            //return new List<Item>();
        }
    }
}
