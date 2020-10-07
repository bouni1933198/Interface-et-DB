using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace retour_poox
{
    class Moto : Vehicule
    {
        private Moteur moteur;
        private Roue[] roueMoto;
        private string style;
        private int tailleReservoir;
        private double distanceParcouru;
        public Moteur Moteur
        {
            get => moteur;
            set => moteur = value;

        }
        public Roue[] RoueMoto
        {
            get => roueMoto;
            set => roueMoto = value;

        }
        public string Style
        {
            get => style;
            set => style = value;

        }
        public int TailleReservoir
        {
            get => tailleReservoir;
            set => tailleReservoir = value;

        }
        public double DistanceParcouru
        {
            get => distanceParcouru;
            set => distanceParcouru = value;

        }


        public Moto(int tailleReservoir, string style, double DistanceParcouru, Moteur moteur, Roue roue,string couleur,string marque,string model):base(tailleReservoir, style, tailleReservoir, moteur,roue,couleur,marque,model)
        {
            this.DistanceParcouru = DistanceParcouru;
            this.moteur = moteur;
            this.tailleReservoir = tailleReservoir;
            
            Couleur = couleur;
            RoueMoto = new Roue[2];
            for (int i = 0; i < RoueMoto.Length; i++)
            {
                RoueMoto[i] =new Roue(roue);
                RoueMoto[i].Pression = roue.Pression;
            }
        }

        public void Rouler(double DistanceRouler)
        {
            do
            {
                DistanceRouler = DistanceRouler - DistanceParcouru;
                


                Console.WriteLine("vous avez parcouru "+ DistanceParcouru +" km vous devez faire le plein il reste " + DistanceRouler+"Km");
                
                Faireleplein();


            }
            while (DistanceRouler != 0);
            Console.WriteLine(" Votre moto a depasse sa durer de vie elle peut vous lacher a tout moment" );


        }

        public void Faireleplein()
        {
           if (tailleReservoir ==0)
            {
                Tournerserrer();
                DiminuerPression();
                tailleReservoir = 100;
            }
            Console.WriteLine("vous venez de faire le plein");
            AjouterPression();

        }
        public virtual void Tournerserrer()
        {
            Console.WriteLine("Pour fait le tournant serrer vous avez du inccliner la moto");
        }
        public void AjouteUsure()
        {

           

        }

        public void Demarrer()
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Couleur);
            Moteur.demmarrer();
            Console.WriteLine("La moto a demarrer !");
        }

        public void AjouterPression()
        {
            for (int i = 0; i < RoueMoto.Length; i++)
            {
               if( RoueMoto[i].Pression < 25)
                {
                    RoueMoto[i].Pression = 35;
                }
            }
            Console.WriteLine("le pneu a ete gonfler");
            
        }

        public void DiminuerPression()
        {
            roueMoto[0].Pression = roueMoto[0].Pression - 1;
            roueMoto[1].Pression = roueMoto[1].Pression - 1;

        }
    }
}
