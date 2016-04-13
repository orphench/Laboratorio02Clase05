using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02Clase05
{
    class Estacionamiento
    {
        public string nombre;
        public List<Auto> ListaDeAutos;
        public int cocheras;
        public Stack<Auto> pilaDeAutos;
        public Queue<Auto> colaDeAutos;

        public Estacionamiento(int cocheras, string nombre)
        {
            this.cocheras = cocheras;
            this.nombre = nombre;
            this.ListaDeAutos = new List<Auto>(cocheras);
            this.pilaDeAutos = new Stack<Auto>(cocheras);
            this.colaDeAutos = new Queue<Auto>(cocheras);
        }

        public void AgregarAuto(Auto auto1)
        {
            this.ListaDeAutos.Add(auto1);
            this.pilaDeAutos.Push(auto1);
            this.colaDeAutos.Enqueue(auto1);
        }

        public bool CompararPatente(string autopatente)
        {
            bool comparar = false;

            foreach (Auto recorriendo  in this.ListaDeAutos)
            {
                if(autopatente == autopatente)
                {
                    comparar = true;
                    break;
                }
            }

            

            return comparar;
        }

        public static bool operator ==(Estacionamiento unEstacionamiento, Auto unAuto)
        {
            bool estaElAuto = false;

            foreach (Auto recorriendo in unEstacionamiento.ListaDeAutos)
            {
                if (recorriendo == unAuto)
                {
                    estaElAuto = true;
                    break;
                }
            }

            return estaElAuto;
        }

        public static bool operator !=(Estacionamiento unEstacionamiento, Auto unAuto)
        {
            return !(unEstacionamiento == unAuto);
        }
    }
}
