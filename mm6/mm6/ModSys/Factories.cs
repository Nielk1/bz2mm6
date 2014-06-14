using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using mm6_controls.Data;

namespace MM6.ModSys
{
    class Factories
    {
        private Factories() { }

        public static GameInstance MakeGameInstance(string filename)
        {
            JObject obj = JObject.Parse(File.ReadAllText(filename));
            try
            {
                JProperty type = obj.Property("type");
                switch (type.Value.Value<string>())
                {
                    case "BasicGameInstance":
                        {
                            string name = obj.Property("name").Value.Value<string>();
                            return new BasicGameInstance(filename) { Name = name };
                            //break;
                        }
                    default:
                        Console.Error.WriteLine("Unknown instance type: {0}", obj.ToString());
                        return null;
                }
            }
            catch {}
            Console.Error.WriteLine("Error reading instance:\n{0}", obj.ToString());
            return null;
        }
    }
}
