using Microsoft.VisualBasic.FileIO;
using Renci.SshNet.Security.Cryptography;
using System;

namespace ClubFromage
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConnect ClubFromage = new DBConnect();
            //string requete = "INSERT into Pays (Id,nom) VALUES(1,'France')";
            //string requete = "INSERT into Pays (Id,nom) VALUES(1,'Belgique')";
            //string requete = "INSERT into Fromage (Id,PaysOrigine_id,nom,creation,image) VALUES(2,2,'saintAlbray','2020/09/09','aa')";
            //string requete1 = "INSERT into Fromage (Id,PaysOrigine_id,nom,creation,image) VALUES(3,1,'Tomme','2020/09/01','bb')";

            //ClubFromage.Insert(requete);
            //string requete1 = "delete from fromage where Id=1";
            string requete1 = "Update Fromage set Id=78 where Id=5";
            ClubFromage.ExectQuery(requete1);
        }
    }
}
