using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLivre_BahamadImane
{
    class Livre
    {
        private string code;
        private string titre;
        private double prix;

        public Livre(string code,string titre,double prix)
        {
            if (prix <= 0) throw new SaisieException("Le prix doit etre supérieur à 0 !");
            if (titre.Length < 4) throw new SaisieException("Le titre doit comporter au moins 4 caractères !");
            this.code = code;
            this.titre = titre;
            this.prix = prix;
        }

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public string Titre
        {
            get
            {
                return titre;
            }
            set
            {
                titre = value;
            }
        }

        public double Prix
        {
            get
            {
                return prix;
            }
            set
            {
                prix = value;
            }
        }

        public override string ToString()
        {
            return code + "\t" + titre + "\t" + prix;
        }
    }
}
