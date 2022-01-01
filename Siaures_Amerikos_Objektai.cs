using System;
using System.Collections;
using System.Collections.Generic;

namespace kursinis

{
    public class funkcijasas 
    {
        public void rodyti(string pasirinkimas2)
        {
            if (pasirinkimas2 == "JAV")
            {
                JAV objektai = new JAV();
                objektai.Objekto_pavadinimas_istorija();
            }
            else if (pasirinkimas2 == "Kanada")
            {
                Kanada objektai = new Kanada();
                objektai.Objekto_pavadinimas_istorija();
            }
            else
            {
                Panama objektai = new Panama();
                objektai.Objekto_pavadinimas_istorija();
            }
        }
        public void rodyti(int pasirinkimas)
        {
            switch (pasirinkimas)
            {
                case 1: 
                JAV objektai = new JAV();
                objektai.Objekto_pavadinimas_istorija();
                break;

                case 2:
                Kanada objektai1 = new Kanada();
                objektai1.Objekto_pavadinimas_istorija();
                break;

                case 3:
                Panama objektai3 = new Panama();
                objektai3.Objekto_pavadinimas_istorija();
                break;
            }
        }
    }
    class JAV : sa_salys, IObjektas
    {
        public void Objekto_pavadinimas_istorija()
        {
            IDictionary<string, string> sarasas  = new Dictionary<string, string>(){
            {"1. Didysis Kanjonas", "Ši neįtikėtina gamtos atrakcija yra viena iš labiausiai lankomų vietų Jungtinėse Amerikos Valstijose. Kolorado upės išraižytas Didysis kanjonas giliai įsirėžia į kraštovaizdį, sukurdamas dramatiškas uolos sienas ir briaunas. Lankytojai, stovintys ant kanjono krašto, gali pamatyti žemyn iki kanjono grindų, esančių už mylios žemiau, ir žiūrėti į kalnagūbrius ir uolas, besitęsiančias tiek, kiek užmato akys."}, 
            {"2. Niagaros Krioklys", "Prie Kanados ir JAV sienos esantis Niagaros krioklys yra vienas garsiausių krioklių pasaulyje. Vanduo iš Erie ežero įteka į Ontarijo ežerą virš šių didžiulių krioklių, žinomų dėl didžiulio vandens kiekio, kuris nuolat krenta ant vertikalaus kritimo."},
            {"3. Laisvės Statula", "Universalus laisvės simbolis, Laisvės statula yra labiausiai žinoma Amerikos ikona ir didžiausia statula pasaulyje. Išdidžiai stovėdami Niujorko uoste lankytojai gali grožėtis statula iš įvairių miesto vietų, ypač Battery parko, arba plaukti keltu tiesiai prie statulos."}};
    
                foreach (var objektas in sarasas)
                { 
                    Console.WriteLine($"\n" + objektas.Key + " : " + objektas.Value);
                    Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");
                }            
        }
    }

    class Kanada: sa_salys, IObjektas
    {
        public void Objekto_pavadinimas_istorija()
        {
            IDictionary<string, string> sarasas  = new Dictionary<string, string>(){
            {"1. Old Quebec", "Senasis Kvebekas yra įtrauktas į UNESCO pasaulio paveldo sąrašą ir vienas iš Kanados istorinių brangakmenių. Aukštutiniame ir žemutiniame Kvebeko miestelyje išsidėsčiusioje vietovėje yra istoriniai miesto pastatai. Žemutinis miestas, esantis palei Šv. Lauryno upę, yra pradinės gyvenvietės vieta, kurioje yra išskirtinis Fairmont Le Château Frontenac, taip pat daugybė kitų lobių. Aukštutinis miestas yra ant 100 metrų aukščio uolų ir jame yra citadelė, Abraomo lygumos, Place d'Armes ir Artillerie istorinis parkas."}, 
            {"2. Ottawwa Parlamento Kalnas", "Otavos Parlamento kalva yra aukštai virš Otavos upės ir ją puošia neogotikinio stiliaus parlamento pastatai, pastatyti paskutinėje XIX amžiaus pusėje. Ryškiausias objektas yra Taikos bokštas, kuris iš abiejų pusių skiria Bendruomenių rūmus ir Senatą. Priešais Parlamento pastatus yra Šimtmečio liepsna, uždegta 1966 m., minint Kanados konfederacijos šimtmetį, o už pastatų yra skulptūrų sodas."},
            {"3. Senasis Montrealis", "Senasis Monrealis, išklotas gražiais istoriniais pastatais, yra vieta, kur galima puikiai apsipirkti ir pavalgyti. Nors pats Monrealis yra gyvybingas modernus miestas, senasis Monrealis, esantis prie krantinės, yra vieta, kur norėsite pasimėgauti atmosfera."}};
    
                foreach (var objektas in sarasas)
                { 
                    Console.WriteLine($"\n" + objektas.Key + " : " + objektas.Value);
                    Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");
                }            
        }
    }
    class Panama : sa_salys, IObjektas
    {
      public void Objekto_pavadinimas_istorija()
        {
            IDictionary<string, string> sarasas  = new Dictionary<string, string>(){
            {"1. Saulėlydis", "Viena iš nedaugelio vietų Panamoje, kur galite stebėti saulėlydį virš Ramiojo vandenyno, Saulėlydžio pakrantė yra neatrasta vietovė su mažais miesteliais, plačiais atvirais paplūdimiais ir nedideliu skaičiumi namelių ir užeigų, kur galite pabėgti nuo turistinė scena."}, 
            {"2. San Blas sala", "Jei tikrai norite ištrūkti iš vėžių ir paragauti nuotykių, kelionė į San Blas salas gali būti kaip tik tai, ko ieškote. Šioje vietovėje yra tobulos atvirukų salos su palmėmis ir krištolo skaidrumo vandeniu, švelniai besidriekiančiomis balto smėlio paplūdimius."}};
            
                foreach (var objektas in sarasas)
                { 
                    Console.WriteLine($"\n" + objektas.Key + " : " + objektas.Value);
                    Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");
                }            
        }
    }
}