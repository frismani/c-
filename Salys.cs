using System;
using System.Collections;
using System.Collections.Generic;

namespace kursinis

{
    public class europos_salys : europa
    {
        public ArrayList salys = new ArrayList() {"Italija", "Prancūzija", "Ispanija"};
        public string Sarasas(string pasirinkimas)
            {   
                Console.Write("\n" + pasirinkimas + " žemyno kelionei siūlomos šalys: ");
                foreach (object salis in salys)
                {
                    Console.Write(salis + "-");
                }
                return pasirinkimas;
            }
        }
    public class afrikos_salys : afrika
    {
        public ArrayList salys = new ArrayList() {"Pietų Afrikos Respublika", "Madagaskaras", "Tanzanija"};
        public string Sarasas(string pasirinkimas)
            {   
                Console.Write("\n" + pasirinkimas + " žemyno kelionei siūlomos šalys: ");
                foreach (object salis in salys)
                {
                    Console.Write(salis + "-");
                }
                return pasirinkimas;
            }
        }
    public class sa_salys : siaures_amerika
    {
        public ArrayList salys = new ArrayList() {"JAV", "Kanada", "Panama"};
        public string Sarasas(string pasirinkimas)
            {   
                Console.Write("\n" + pasirinkimas + " žemyno kelionei siūlomos šalys: ");
                foreach (object salis in salys)
                {
                    Console.Write(salis + "-");
                }
                return pasirinkimas;
            }
        }
    public class pa_salys : pietu_amerika
    {
        public ArrayList salys = new ArrayList() {"Brazilija", "Čilė", "Argentina"};
        public string Sarasas(string pasirinkimas)
            {   
                Console.Write("\n" + pasirinkimas + " žemyno kelionei siūlomos šalys: ");
                foreach (object salis in salys)
                {
                    Console.Write(salis + "-");
                }
                return pasirinkimas;
            }
        }
    public class azijos_salys : azija
    {
        public ArrayList salys = new ArrayList() {"Rusija", "Kinija", "Indija"};
        public string Sarasas(string pasirinkimas)
            {   
                Console.Write("\n" + pasirinkimas + " žemyno kelionei siūlomos šalys: ");
                foreach (object salis in salys)
                {
                    Console.Write(salis + "-");
                }
                return pasirinkimas;
            }
        }
    public class okeanijos_salys : okeanija
    {
        public ArrayList salys = new ArrayList() {"Australija", "Naujoji Zelandija"};
        public string Sarasas(string pasirinkimas)
            {   
                Console.Write("\n" + pasirinkimas + " žemyno kelionei siūlomos šalys: ");
                foreach (object salis in salys)
                {
                    Console.Write(salis + "-");
                }
                return pasirinkimas;
            }
        }
    public class antarktidos_salys : antarktida
    {
        public void Sarasas()
            {   
                Console.WriteLine("Deja, neturime pasiūlymų");
            }
        }
}