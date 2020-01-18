using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyTogether
{
   public class CommonThings
    {
        public T CSVToModel<T>(string filePath, char seperator)
        {
            string lines = File.ReadAllText(filePath);

            return CSVToModelFromString<T>(lines, seperator);
        }
        public T CSVToModelFromString<T>(string fileContent, char seperator)
        {
            JArray array = new JArray();
            try
            {
                fileContent = System.Text.RegularExpressions.Regex.Replace(fileContent, @"\r\n?|\n", "\r");
                string[] lines = fileContent.Split('\r');
                string[] objProperties = GetCSVHeader(seperator, lines[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(lines[i]))
                        continue;
                    JObject obj = new JObject();
                    string[] values = lines[i].Split(seperator);

                    for (int j = 0; j < values.Length; j++)
                    {

                        obj.Add(objProperties[j], values[j]);
                    }

                    array.Add(obj);
                }
            }
            catch (Exception ex)
            {

            }

            return JsonConvert.DeserializeObject<T>(array.ToString());
        }
        private string[] GetCSVHeader(char seperator, string line)
        {
            return line.Split(seperator);
        }
    }
}
