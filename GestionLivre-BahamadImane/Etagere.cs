using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLivre_BahamadImane
{
    class Etagere
    {
        private string numero;
        private List<Livre> livres;

        public Etagere(string numero)
        {
            this.numero = numero;
            livres = new List<Livre>();
        }

        public string Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }

        public List<Livre> Livres
        {
            get
            {
                return livres;
            }
            set
            {
                livres = value;
            }
        }

        public override string ToString()
        {
            return numero + "\t [ "+ livres + "]";
        }

        public void Remettre_livre(Livre livre)
        {
            if (Position_livre(livre) != -1) throw new ExistenceException("Ce livre existe déjà dans l'étagère !");
            foreach (Livre l in livres)
                if (l.Code == livre.Code)
                    throw new ExistenceException("Ce code existe déjà !");

            livres.Add(livre);
        }

        public int Position_livre(Livre livre)
        {
            for(int i=0;i<livres.Count;i++)
            {
                if (livres[i] == livre)
                    return i;
            }
            return -1;
        }

        public Livre livres_a_une_position(int position)
        {
            if (position >= livres.Count) throw new IndexOutOfRangeException("Indice incorrecte !");
            return livres[position];
        }

        public void retirer_livre(Livre livre)
        {
            if (Position_livre(livre) == -1) throw new ExistenceException("Ce livre n'existe pas dans l'étagère !");
            livres.Remove(livre);
        }

        public void remplacer(Livre ancien_livre, Livre nouveau_livre)
        {
            int position_ancien = Position_livre(ancien_livre);
            int position_nouveau = Position_livre(nouveau_livre);

            if (position_ancien == -1) throw new ExistenceException("Le livre"+ ancien_livre.Titre + " n'existe pas dans l'étagère !");
            if (position_nouveau != -1) throw new ExistenceException("Le livre " + nouveau_livre.Titre + " existe déjà dans l'étagère !");

            livres[position_ancien] = nouveau_livre;
        }

        public int nbre_livres()
        {
            return livres.Count;
        }
    }
}
