using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retour_poox
{
    class Moteur
    {
        private int taille;
        private int nbCylindre;
        private int puissanceChevaux;
        private double consommationParKm;

        public int Taille
        {
            get => taille;
            set => taille = value;

        }
        public int NbCylindre
        {
            get => nbCylindre;
            set => nbCylindre = value;

        }
        public int PuissanceChevaux
        {
            get => puissanceChevaux;
            set => puissanceChevaux = value;

        }
        public double ConsommationParKm
        {
            get => consommationParKm;
            set => consommationParKm = value;

        }
        public Moteur()
        {

        }
        public Moteur(int taille, int nbCylindre, int puissanceChevaux, int consommationParKm)
        {
            this.taille = taille;
            this.nbCylindre = nbCylindre;
            this.puissanceChevaux = puissanceChevaux;
            this.consommationParKm = consommationParKm;
        }
        public void demmarrer()
        {
            Console.WriteLine("Vrooooom !");
        }
    }

   

 


}
