using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace MVVM
{
    internal class JsonFileService : IFileServis
    {
        public List<Phone> Open(string filename)
        {
            List<Phone> phones = new List<Phone>();
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                phones = JsonSerializer.Deserialize<List<Phone>>(fs);
            }
            return phones;
        }

        public void Save(string filename, List<Phone> phonesList)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                JsonSerializer.Serialize<List<Phone>>(fs,phonesList);
            }
        }
    }
}