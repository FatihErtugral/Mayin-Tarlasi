using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Serialization;
using System.Data;
using System.Reflection;

namespace MMayinTarlasi
{
   

    public class ScoreEntities
    {
        public struct ScoreModel
        {
            public string   PlayerName  { get; set; }
            public int      Score   { get; set; }
            public string   Date    { get; set; }
        }
        public string Version { get; set; }
        public List<ScoreModel> BillLists { get; set; } = new List<ScoreModel>();
    }

    class ScoreSystem
    {
        private static ScoreSystem _;
        private ScoreEntities model;
        private FileStream  fs;
        private static readonly object _lockObject = new object();


        public static ScoreSystem GetInstance()
        {
            if(_ == null)
                lock (_lockObject)
                    if (_ == null)
                        _ = new ScoreSystem();

            return _;
        }

        public ScoreSystem()
        {
            // Klasör yoksa klasörü oluştur.
            if (!Directory.Exists(Application.StartupPath + "\\Skor"))
                System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Skor");

            // Skor.json yoksa veya silindiyse yenisini oluştur.
            if (!File.Exists(Application.StartupPath + "\\Skor\\Skor.json"))
            {
                fs = File.Create(Application.StartupPath + "\\Skor\\Skor.json");
                fs.Close();
                var model = new ScoreEntities
                {
                    Version = "1.0.0123",
                    BillLists = {}
                };
                var serializerSettings = new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                };
                var json = JsonConvert.SerializeObject(model, serializerSettings);
                File.WriteAllText(Application.StartupPath + @"\\Skor\\Skor.json", json);
                
            }
            // Dosyayı oku model nesnesine yerleştir hafızaya al
            this.model = JsonConvert.DeserializeObject<ScoreEntities>
                    (
                        File.ReadAllText(Application.StartupPath + "\\Skor\\Skor.json")
                    );
        }

        public void Add(string playerName, int score)
        {
            // Skor tabelasını 6 ile sınırla, listenin en düşük skorunu silip alttan ekle.
            if( model.BillLists.Count >= 6 && model.BillLists[5].PlayerName != null )
            {
                model.BillLists.RemoveAll(k => k.Score ==  model.BillLists.Min(xa => xa.Score));
            }
            
            model.BillLists.Add(new ScoreEntities.ScoreModel {
                PlayerName = playerName,
                Score = score,
                Date = DateTime.Now.ToString("MMMM dd, yyyy"), 
            });

            // Dosyaya yazma işlemleri ve json formatına çevirim.
            var serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            var json = JsonConvert.SerializeObject(model, serializerSettings);
            File.WriteAllText(Application.StartupPath + @"\\Skor\\Skor.json", json);
        }

        public DataTable GetScoreDateTable()
        {
            if (File.Exists(Application.StartupPath + "\\Skor\\Skor.json"))
            {
                var model = JsonConvert.DeserializeObject<ScoreEntities>(
                File.ReadAllText(Application.StartupPath + "\\Skor\\Skor.json"));

                var sort = (from ks in model.BillLists
                            orderby ks.Score descending
                            select new
                            {
                                ks.Score,
                                ks.PlayerName,
                                ks.Date
                            }
                          ).ToList();
                return ToDataTable(sort);
            }
            return null;
        }

        ////////////////////////////////////////////////////////////////////////
        // list türünden datatable türüne dönüşüm
        private DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
    }
    
}
