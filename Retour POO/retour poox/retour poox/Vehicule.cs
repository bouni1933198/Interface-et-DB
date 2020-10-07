using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retour_poox
{
    class Vehicule
    {
        private int dureeVieKm;
        private int autonomieKm;
        private string couleur;
        private int anneeProduction;
        private string marque;
        private string modele;

        public int DureeVieKm
        {
            get => dureeVieKm;
            set => dureeVieKm = value;

        }
        public int AutonomieKm
        {
            get => autonomieKm;
            set => autonomieKm = value;

        }
        public string Couleur
        {
            get => couleur;
            set => couleur = value;

        }
        public int AnneeProduction
        {
            get => anneeProduction;
            set => anneeProduction = value;

        }
        public string Modele
        {
            get => modele;
            set => modele = value;

        }
        public string Marque
        {
            get => marque;
            set => marque = value;

        }
        public Vehicule()
        {

        }

        public Vehicule(int dureeVieKm, string style, int autonomieKm, Moteur moteur, Roue roue, string couleur, string marque, string model)
        {
          
            


        }

        public void Demarrer()
        {
          
        }

    }
}
