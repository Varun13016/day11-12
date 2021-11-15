using System;

namespace InventoryDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/81/Inventory.json";
            Console.WriteLine("Welcome to the Inventory Data Management!!!");
           
            ReadInventoryData readInventoryData = new ReadInventoryData();
            InventoryDataManagementModel data = readInventoryData.Read(path);
            for(int i=0; i< data.Rice.Count; i++)
            {
                int valueofRice = data.Rice[i].weight * data.Rice[i].price;
                Console.WriteLine("Rice Details");
                //Console.WriteLine(" Name: " + data.Rice[i].name + "  " + " Weight: " + data.Rice[i].weight + "  " + " Price: " + data.Rice[i].price);
                Console.WriteLine("The value of {0} is {1}", data.Rice[i].name, valueofRice);
            }
            for (int i = 0; i < data.Pulses.Count; i++)
            {
                int valueofpulses = data.Pulses[i].weight * data.Pulses[i].price;
                Console.WriteLine("Pulses Details");
                //Console.WriteLine(" Name: " + data.Pulses[i].name + "  " + " weight : " + data.Pulses[i].weight + " " + " Price :" + data.Pulses[i].price);
                Console.WriteLine("The value of {0} is {1}", data.Pulses[i].name, valueofpulses);
            }
            for (int i = 0; i < data.Wheat.Count; i++)
            {
                int valueofWheat = data.Wheat[i].weight * data.Wheat[i].price;
                Console.WriteLine("Wheat Details");
                //Console.WriteLine(" Name: " + data.Wheat[i].name + " " + " Weight: " + data.Wheat[i].weight + " " + " Price: " + data.Wheat[i].price);
                Console.WriteLine("The value of {0} is {1}", data.Wheat[i].name, valueofWheat);
            }
        }
    }
}
