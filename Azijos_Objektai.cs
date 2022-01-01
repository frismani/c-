using System;
using System.Collections;
using System.Collections.Generic;

namespace kursinis

{
    public class Funkcijaaz
    {
        public void rodyti(string pasirinkimas2)
        {
            if (pasirinkimas2 == "Rusija")
            {
                Rusija objektai = new Rusija();
                objektai.Objekto_pavadinimas_istorija();
            }
            else if (pasirinkimas2 == "Kinija")
            {
                Kinija objektai = new Kinija();
                objektai.Objekto_pavadinimas_istorija();
            }
            else
            {
                Indija objektai = new Indija();
                objektai.Objekto_pavadinimas_istorija();
            }
        }

        public void rodyti(int pasirinkimas)
        {
            switch (pasirinkimas)
            {
                case 1: 
                Rusija objektai = new Rusija();
                objektai.Objekto_pavadinimas_istorija();
                break;

                case 2:
                Kinija objektai1 = new Kinija();
                objektai1.Objekto_pavadinimas_istorija();
                break;

                case 3: 
                Indija objektai2 = new Indija();
                objektai2.Objekto_pavadinimas_istorija(); 
                break;
            }
        }
    }
    class Rusija : azijos_salys, IObjektas
    {
        public void Objekto_pavadinimas_istorija()
        {
            IDictionary<string, string> sarasas  = new Dictionary<string, string>(){
            {"1. Ežeras Baikal", "Tai seniausias ir giliausias ežeras pasaulyje, jo didžiausias gylis siekia 1642 metrus, o amžius apie 25 milijonus metų. Šiame ežere yra daugiau nei 20 procentų viso pasaulio gėlo vandends. Vasarą čia susirenka daug baidarių, plaukiojimo laisvais ir šiuolių į salas megėjų."}, 
            {"2. Maskva", "Tai Rusijos sostinė, turinti daug žalumos, architektūros bei istorinių palikimų. Pačiame miesto centre yra žymūs objektai, tokie kaip Kremlius, Raudonoji aikštė bei Šv. Bazilijaus katedra."},
            {"3. Peterburgas", "Šis miestas labiau panašus į Europos miestus, turintis taip pat daug architektūrinio paveldo, 300 kilometrų kanalus, kertančius miestą bei daug muziejų, iš kurių žymiausias - Ermitažas. Beje, šis muziejus yra antras pagal dydį visame pasaulyje."}};
    
                foreach (var objektas in sarasas)
                { 
                    Console.WriteLine($"\n" + objektas.Key + " : " + objektas.Value);
                    Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");
                }            
        }
    }

    class Kinija: azijos_salys, IObjektas
    {
        public void Objekto_pavadinimas_istorija()
        {
            IDictionary<string, string> sarasas  = new Dictionary<string, string>(){
            {"1. Didžioji Kinų Siena", "Jos ilgis yra daugiau nie 6000 kilometrų, vidutiniškai 6-8 metrų aukščio ir tokio pločio, kad per ją galėtų praeiti penki arkliai ar 10 vyrų. Per visą sienos ilgį yra išdestyti sargybos bokštai bei stulpai."}, 
            {"2. Uždraustas Miestas ir Karališki Rūmai", "Tai didžiausias ir svarbiausias pastatas šalyje, kitaip vadinamas Imperatoriškais Rūmais, yra pačiame Pekino centre. Pradėtas statyti dar 1271 metais, tačiau didžioji dalis buvo pastatyta 1406-1420 metais. Šis kompleksas buvo 24 Mingų ir Čingų imperatorių rezidencija, į kurią įeiti galėjo tik imperatoriška šeima ir jų pagalbininkai."},
            {"3. Terracotta Armija", "Aštuntajame dešimtmetyje Siano pakraštyje kasdami šulinius ūkininkai atsitiktinai aptiko svarbiausią Kinijos archeologinį radinį – Terakotos armiją. Išskirstytame trijose didelėse požeminėse duobėse ir pastatytame saugoti Pirmojo imperatoriaus kapą, radinyje buvo daugiau nei 8000 natūralaus dydžio karių, apie 520 žirgų ir daugiau nei 100 vežimų, taip pat daugybė kitų nekarinių veikėjų, datuojamų maždaug 280 m. pr. Kr."}};
    
                foreach (var objektas in sarasas)
                { 
                    Console.WriteLine($"\n" + objektas.Key + " : " + objektas.Value);
                    Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");
                }            
        }
    }
    class Indija : azijos_salys, IObjektas
    {
      public void Objekto_pavadinimas_istorija()
        {
            IDictionary<string, string> sarasas  = new Dictionary<string, string>(){
            {"1. Taj Mahal", "Turbūt labiausiai atpažįstamas Indijos pastatas, Tadžmahalas, taip pat yra garsiausias pasaulyje meilės galios liudijimas. Pavadintas Mumtaz Mahal, mėgstamiausios imperatoriaus Šacho Džahano žmonos vardu, šis gražiausias mauzoliejus buvo pradėtas kurti jai mirus 1631 m., o iki 1648 m. jį užbaigti prireikė 20 000 darbininkų."}, 
            {"2. Šventas Varanasi Miestas", "Varanasis, datuojamas 8 amžiuje prieš Kristų, yra vienas seniausių vis dar apgyvendintų miestų pasaulyje. Šis šventasis miestas, pagrindinis induistų piligrimystės centras, ilgą laiką buvo siejamas su galinga Gango upe, vienu iš svarbiausių tikėjimo religinių simbolių."}};

                foreach (var objektas in sarasas)
                { 
                    Console.WriteLine($"\n" + objektas.Key + " : " + objektas.Value);
                    Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");
                }            
        }
    }
}