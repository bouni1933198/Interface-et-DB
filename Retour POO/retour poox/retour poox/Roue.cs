using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retour_poox
{
    class Roue
    {
        private int largeur;
        private int pourcentageHauteur;
        private int diametreJante;
        private  int indiceCharge;
        private char indiceVitesse;
        private int pression;
        private string type;

        public string Type
        {
            get => type;
            set => type = value;

        }
        public char IndiceVitesse
        {
            get => indiceVitesse;
            set => indiceVitesse = value;

        }
        public int IndiceCharge
        {
            get => indiceCharge;
            set => indiceCharge = value;

        }
        public int DiametreJante
        {
            get => diametreJante;
            set => diametreJante = value;

        }
        public int PourcentageHauteur
        {
            get => pourcentageHauteur;
            set => pourcentageHauteur = value;

        }
        public int Largeur
        {
            get => largeur;
            set => largeur = value;

        }
        public int Pression
        {
            get => pression;
            set => pression = value;

        }
       
        public Roue( Roue roue)
        {

        }
        public Roue(int largeur, int pourcentageHauteur, int diametreJante, int indiceCharge, char indiceVitesse, int pression, string type)
        {
            this.largeur = largeur;
            this.pourcentageHauteur = pourcentageHauteur;
            this.diametreJante = diametreJante;
            this.indiceCharge = indiceCharge;
            this.indiceVitesse = indiceVitesse;
            this.pression = pression;
            this.type = type;
            
        }
       

        public void GonflerPneu(int pression)
        { 
            if (pression < 25)
            {
               pression = 32;
            }
        }

    }
}
