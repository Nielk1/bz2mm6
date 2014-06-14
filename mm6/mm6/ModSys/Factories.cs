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

        public static ModEntry MakeModEntry(string filename)
        {
            JObject obj = JObject.Parse(File.ReadAllText(filename));
            try
            {
                JProperty type = obj.Property("type");
                switch (type.Value.Value<string>())
                {
                    case "BasicConfigModEntry":
                        {
                            string name = obj.Property("name").Value.Value<string>();
                            string instance = obj.Property("instance").Value.Value<string>();
                            string config = null;
                            try
                            {
                                config = obj.Property("config").Value.Value<string>();
                            }
                            catch { }
                            return new BasicConfigModEntry(instance, filename, name, config);
                            //break;
                        }
                    default:
                        Console.Error.WriteLine("Unknown instance type: {0}", obj.ToString());
                        return null;
                }
            }
            catch { }
            Console.Error.WriteLine("Error reading instance:\n{0}", obj.ToString());
            return null;
        }
    }
}
