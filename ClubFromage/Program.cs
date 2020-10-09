using Microsoft.VisualBasic.FileIO;
using Renci.SshNet.Security.Cryptography;
using System;
using System.Globalization;

namespace ClubFromage
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConnect ClubFromage = new DBConnect(); 
            Dbal clubfromage = new Dbal();
           
            DAOpays undaoPays = new DAOpays(clubfromage);
           
            undaoPays.InsertByFile("D:\\hugoCOMBET\\visualStudio\\ClubFromage\\ClubFromage\\bin\\Debug\\pays.csv");

            //String delete = "Pays";
            //ClubFromage.Delete(delete);
        }
    }
}
