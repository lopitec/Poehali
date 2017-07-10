using System;
using System.Text;
using System.Threading.Tasks;

namespace Poehali
{
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization.Json;

    internal class DataContracting : IStorageService
    {
        public void WriteData(ICollection workers, string filename)
        {
            List<Worker> workerlist = workers.Cast<Worker>().ToList();
            var formatter = new DataContractJsonSerializer(typeof(List<Worker>));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.WriteObject(fs, workerlist);
            }
        }


        public ICollection ReadData(string filename)
        
        {
            if (!File.Exists(filename))
            {
                return null;
            }
            var formatter = new DataContractJsonSerializer(typeof(List<Worker>));
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                List<Worker> workerList = (List<Worker>)formatter.ReadObject(fs);
                return workerList;
            }
        }
    }
}
