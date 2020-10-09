using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;
using Ubiety.Dns.Core.Records;

namespace ClubFromage
{
    class DAOpays
    {
        private Dbal _dbal ;

        public DAOpays(Dbal dbal)
            {
            _dbal = dbal;
            }
        public void Insert(Pays unPays)
        {
            string query = " Pays VALUES " + "(" + unPays.getIdPays() + ",'" + unPays.getNom().Replace("'", "''") + "');";
            this._dbal.Insert(query);
        }
        public void Update(Pays unPays)
        {
            string query = "Pays SET ID = " + unPays.getIdPays() + ", nomPays = '" + unPays.getNom().Replace("'", "''") + "' WHERE ID = " + unPays.getIdPays() + " ;";
            this._dbal.Update(query);
        }

        public void Delete(Pays unPays)
        {
            string query = "Pays WHERE ID = " + unPays.getIdPays() + ";";
            this._dbal.Delete(query);
        }
        public void InsertByFile(string Chemin)
        {
            using (var reader = new StreamReader(Chemin))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            { 
                csv.Configuration.Delimiter = ";";
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
            
                var record = new Pays();
                var records = csv.EnumerateRecords(record);
                foreach (Pays pays in records)
                {
                    Insert(pays);
                }
            }
        }
    }
}
