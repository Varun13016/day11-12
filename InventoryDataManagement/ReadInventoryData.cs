using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace InventoryDataManagement
{
   public class ReadInventoryData
    {
        public InventoryDataManagementModel Read(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoryDataManagementModel>(json);
                }catch(Exception e)
                {
                    Console.WriteLine("problem in getting data {0}", e);
                    return null;
                }
            }
        }
    }
}
