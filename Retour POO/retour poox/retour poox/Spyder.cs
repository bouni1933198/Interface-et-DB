using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retour_poox
{
    class Spyder:Moto
    {
        
        public Spyder(int dureeVieKm, int distanceParcouru, Moteur moteur, Roue roue, string couleur, string marque, string model):base(dureeVieKm,"spyder", distanceParcouru, moteur, roue, couleur, marque, model)
        {

            RoueMoto = new Roue[3];
            for (int i = 0; i < RoueMoto.Length; i++)
            {
                RoueMoto[i] = new Roue(roue);
                RoueMoto[i].Pression = roue.Pression;
            }
        }

        public void Demarrer()
        {
            Console.WriteLine("");
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Couleur);
            Moteur.demmarrer();
            Console.WriteLine("La Spyder a demarrer !");
        }

        public override void Tournerserrer()
        {
            Console.WriteLine("Pour fait le tournant serrer vous avez du inccliner la spyder");
        }

    }
}
