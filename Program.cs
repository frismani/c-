using System;
using System.Collections;
using System.Collections.Generic;

namespace kursinis

{
    class Program
    {
        static void Main(string[] args)
        {   
            Vartotojas var1 = new Vartotojas();
            Console.Write("Įveskite vartotojo vardą: ");
            var1.vardas = Console.ReadLine();
            Console.Write("Įveskite slaptažodį: ");
            string slaptažodis = Console.ReadLine();
            var1.Prisijungimas(slaptažodis);
            var1.GautiAtpazinima();
            if (var1.GautiAtpazinima() == true)
                {
                    Console.WriteLine("\n\nLabas, {0}!", var1.vardas);
                    Console.WriteLine("\nTai tavo VIRTUALUS GIDAS, kuris kelionės metu padės rasti informaciją apie pačius žymiausius objektus\n");
                        
                    Console.Write("Įvesk dominantį žemyną: ");
                    string pasirinkimas1 = Console.ReadLine().ToUpper();

                    if (pasirinkimas1 == "EUROPA")
                        {
                            europos_salys eus = new europos_salys();
                            Console.WriteLine(eus.info(pasirinkimas1));
                            eus.Sarasas(pasirinkimas1);
                            Console.WriteLine("\nPasirink šalį, kad pamatytum įžymiausius objektus: ");
                            string pasirinkimas2 = Console.ReadLine();
                            if (eus.salys.Contains(pasirinkimas2))
                            {
                                funkcija naujas = new funkcija();
                                naujas.rodyti(pasirinkimas2);
                            }
                            else if (eus.salys.Count >= Convert.ToInt32(pasirinkimas2))
                            {  
                                funkcija naujas = new funkcija();
                                naujas.rodyti(Convert.ToInt32(pasirinkimas2));
                            }
                            else 
                            {
                                Console.WriteLine("Deja, informacijos apie ieškomą šalį neturime.");
                            }
                        }
                    else if (pasirinkimas1 == "AZIJA")
                        {
                            azijos_salys azijos_Salys = new azijos_salys();
                            Console.WriteLine(azijos_Salys.info(pasirinkimas1));
                            azijos_Salys.Sarasas(pasirinkimas1);
                            Console.WriteLine("\nPasirink šalį, kad pamatytum įžymiausius objektus: ");
                            string pasirinkimas2 = Console.ReadLine();
                            if (azijos_Salys.salys.Contains(pasirinkimas2))
                            {
                                Funkcijaaz naujas = new Funkcijaaz();
                                naujas.rodyti(pasirinkimas2);
                            }
                            else if (azijos_Salys.salys.Count >= Convert.ToInt32(pasirinkimas2))
                            {  
                                Funkcijaaz naujas = new Funkcijaaz();
                                naujas.rodyti(Convert.ToInt32(pasirinkimas2));
                            }
                            else 
                            {
                                Console.WriteLine("Deja, informacijos apie ieškomą šalį neturime.");
                            }
                        }
                    else if (pasirinkimas1 == "AFRIKA")
                        {
                            afrikos_salys afs = new afrikos_salys();
                            Console.WriteLine(afs.info(pasirinkimas1));
                            afs.Sarasas(pasirinkimas1);
                            Console.WriteLine("\nPasirink šalį, kad pamatytum įžymiausius objektus: ");
                            string pasirinkimas2 = Console.ReadLine();
                            if (afs.salys.Contains(pasirinkimas2))
                            {
                            funkcijaaf naujas = new funkcijaaf();
                            naujas.rodyti(pasirinkimas2);
                            }
                            else if (afs.salys.Count >= Convert.ToInt32(pasirinkimas2))
                            {  
                                funkcijaaf naujas = new funkcijaaf();
                                naujas.rodyti(Convert.ToInt32(pasirinkimas2));
                            }
                            else 
                            {
                                Console.WriteLine("Deja, informacijos apie ieškomą šalį neturime.");
                            }
                        }

                    else if (pasirinkimas1 == "PIETU AMERIKA" | pasirinkimas1 == "PIETŲ AMERIKA") 
                        {
                            pa_salys pa = new pa_salys();
                            Console.WriteLine(pa.info(pasirinkimas1));
                            pa.Sarasas(pasirinkimas1);
                            Console.WriteLine("\nPasirink šalį, kad pamatytum įžymiausius objektus: ");
                            string pasirinkimas2 = Console.ReadLine();
                            if (pa.salys.Contains(pasirinkimas2))
                            {
                                funkcijapa naujas = new funkcijapa();
                                naujas.rodyti(pasirinkimas2);
                            }
                            else if (pa.salys.Count >= Convert.ToInt32(pasirinkimas2))
                            {  
                                funkcijapa naujas = new funkcijapa();
                                naujas.rodyti(Convert.ToInt32(pasirinkimas2));
                            }
                            else 
                            {
                                Console.WriteLine("Deja, informacijos apie ieškomą šalį neturime.");
                            }
                        }
                        
                    else if (pasirinkimas1 == "SIAURES AMERIKA" | pasirinkimas1 == "ŠIAURĖS AMERIKA" )
                        {
                            sa_salys sas = new sa_salys();
                            Console.WriteLine(sas.info(pasirinkimas1));
                            sas.Sarasas(pasirinkimas1);
                            Console.WriteLine("\nPasirink šalį, kad pamatytum įžymiausius objektus: ");
                            string pasirinkimas2 = Console.ReadLine();
                            if (sas.salys.Contains(pasirinkimas2))
                            {
                               funkcijasas naujas = new funkcijasas();
                               naujas.rodyti(pasirinkimas2); 
                            }
                            else if (sas.salys.Count >= Convert.ToInt32(pasirinkimas2))
                            {  
                                funkcijasas naujas = new funkcijasas();
                                naujas.rodyti(Convert.ToInt32(pasirinkimas2));
                            }
                            else 
                            {
                                Console.WriteLine("Deja, informacijos apie ieškomą šalį neturime.");
                            }
                        }

                    else if (pasirinkimas1 == "OKEANIJA")
                        {
                            okeanijos_salys ok = new okeanijos_salys();
                            Console.WriteLine(ok.info(pasirinkimas1));
                            ok.Sarasas(pasirinkimas1);
                            Console.WriteLine("\nPasirink šalį, kad pamatytum įžymiausius objektus: ");
                            string pasirinkimas2 = Console.ReadLine();
                            if (ok.salys.Contains(pasirinkimas2))
                            {
                                funkcijaok naujas = new funkcijaok();
                                naujas.rodyti(pasirinkimas2);
                            }
                            else if (ok.salys.Count >= Convert.ToInt32(pasirinkimas2))
                            {  
                                funkcijaok naujas = new funkcijaok();
                                naujas.rodyti(Convert.ToInt32(pasirinkimas2));
                            }
                            else 
                            {
                                Console.WriteLine("Deja, informacijos apie ieškomą šalį neturime.");
                            }
                        }

                    else if (pasirinkimas1 == "ANTARKTIDA")
                        {
                            antarktidos_salys ant = new antarktidos_salys();
                            Console.WriteLine(ant.info(pasirinkimas1));
                            ant.Sarasas();
                        }
                    else
                        {
                            Console.WriteLine("Neteisingas pasirinkimas. Bandyk dar kartą.");
                        }
                }
            else
                {
                    Console.WriteLine("Neteisingai įvestas slaptažodis. Bandyk dar kartą.");
                }
        }
    }
}