using System;
using System.Collections.Generic;
using System.Text;

namespace ClubFromage
{
    class Fromage
    {
        #region Attributs privés
        private int _id;
        private int _PaysOrigineID;
        private string _nom;
        private DateTime _creation;
        private string _image;
        #endregion

        #region Constructeurs
        public Fromage(int idfromage, int PaysOrigineIdFromage, string nomFromage, DateTime creationFromage, string imageFromage)
        {
            _id = idfromage;
            _PaysOrigineID = PaysOrigineIdFromage;
            _nom = nomFromage;
            _creation = creationFromage;
            _image = imageFromage;

        }


        #endregion;

        #region getteurs/setteurs
        public int Id { get => _id; set => _id = value; }
        public int PaysOrigineID { get => _PaysOrigineID; set => _PaysOrigineID = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public DateTime Creation { get => _creation; set => _creation = value; }
        public string Image { get => _image; set => _image = value; }
        #endregion
    }
}
