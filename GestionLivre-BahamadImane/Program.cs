using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionLivre_BahamadImane
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        /// 
        public static List<Livre> livresRetires = new List<Livre>();
        public static List<Etagere> etageres = new List<Etagere>();

        public static Livre Rechercher_livre_retires(string code)
        {
            foreach (Livre livre in livresRetires)
                if (livre.Code == code)
                    return livre;
            return null;
        }

        public static Livre Rechercher_livre(string code)
        {
            foreach(Etagere etagere in etageres)
            {
                foreach(Livre livre in etagere.Livres)
                {
                    if (livre.Code == code)
                        return livre;
                }
            }
            return null;
        }

        public static Etagere Rechercher_etagere(string num)
        {
            foreach (Etagere etagere in etageres)
            {
                if (etagere.Numero == num)
                    return etagere;
            }
            return null;
        }

        public static void ajout_livre(Livre livre,string num)
        {
            bool existe = false;
            foreach (Etagere etagere in etageres)
            {
                if (etagere.Numero == num && !etagere.Livres.Contains(livre))
                {
                    foreach (Livre l in etagere.Livres)
                        if (l.Code == livre.Code)
                            throw new ExistenceException("Ce code existe déjà !");

                    etagere.Livres.Add(livre);
                    existe = true;
                }
                else if (etagere.Livres.Contains(livre)) throw new ExistenceException("Ce livre existe déjà !");
            }
            if (!existe)
                throw new ExistenceException("Cette étagère n'existe pas !");
        }

        public static void ajout_etagere(string num)
        {
            if (Rechercher_etagere(num) != null) throw new ExistenceException("Cette étagère existe déjà !");
            etageres.Add(new Etagere(num));
        }

        public static void Remettre_livre_etagere(string code,string num)
        {
            bool existe = false;
            foreach (Etagere etagere in etageres)
            {
                if (etagere.Numero == num)
                {
                    etagere.Remettre_livre(Rechercher_livre_retires(code));
                    existe = true;
                }
            }

            if(!existe)
                throw new ExistenceException("Cette étagère n'existe pas !");
        }

        public static void Retirer_livre_etagere(string code, string num)
        {
            bool existe = false;
            foreach (Etagere etagere in etageres)
            {
                if (etagere.Numero == num)
                {
                    Livre livre = Rechercher_livre(code);
                    etagere.retirer_livre(livre);
                    livresRetires.Add(livre);
                    existe = true;
                }
            }
            if (!existe)
                throw new ExistenceException("Cette étagère n'existe pas !");
        }

        public static void remplacer_livre_etagere(string code_ancien, Livre nouveau, string num)
        {
            bool existe = false;
            foreach (Etagere etagere in etageres)
            {
                if (etagere.Numero == num)
                {
                    etagere.remplacer(Rechercher_livre(code_ancien), nouveau);
                    existe = true;
                }
            }
            if (!existe)
                throw new ExistenceException("Cette étagère n'existe pas !");
        }

        public static List<Livre> lister_livre_etagere(string num)
        {
            foreach (Etagere etagere in etageres)
            {
                if (etagere.Numero == num)
                {
                    return etagere.Livres;
                }
            }
            return null;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
