using System;
using System.Collections;
using System.Collections.Generic;

namespace kursinis

{
    public class funkcijaok 
    {
        public void rodyti(string pasirinkimas2)
        {
            if (pasirinkimas2 == "Australija")
            {
                Australija objektai = new Australija();
                objektai.Objekto_pavadinimas_istorija();
            }
            else
            {
                Naujoji_Zelandija objektai = new Naujoji_Zelandija();
                objektai.Objekto_pavadinimas_istorija();
            }
        }

        public void rodyti(int pasirinkimas)
        {
            switch (pasirinkimas)
            {
                case 1: 
                Australija objektai = new Australija();
                objektai.Objekto_pavadinimas_istorija();
                break;

                case 2:
                Naujoji_Zelandija objektai1 = new Naujoji_Zelandija();
                objektai1.Objekto_pavadinimas_istorija();
                break;
            }
        }
    }
    class Australija : okeanijos_salys , IObjektas
    {
        public void Objekto_pavadinimas_istorija()
        {
            IDictionary<string, string> sarasas  = new Dictionary<string, string>(){
            {"1. Sidnėjaus Operos Namai", "Mention 'Sydney, Australia' and most people think of the Opera House. Shaped like huge shells or billowing sails, this famous building on Sydney's Bennelong Point graces the list of UNESCO World Heritage Sites and is one of the world's great architectural icons. The location is stunning. Water surrounds the structure on three sides, and the Royal Botanic Gardens border it to the south."}, 
            {"2. Uluru-Kata Tjuta Nacionalinis Parkas", "Giliai Australijos Raudonojo centro širdyje esantis Uluru (buvęs Ayers Rock) yra vienas labiausiai fotografuojamų gamtos stebuklų šalyje. Įspūdingas raudonas monolitas yra Uluru-Kata Tjuta nacionalinio parko, Pasaulio paveldo objekto, kurį kartu valdo Australijos parkai ir tradiciniai žemės savininkai Aṉangu žmonės, dalis."},
            {"3. Sidnėjaus Uosto Tiltas", "Kartu su operos teatru Sidnėjaus uosto tiltas yra viena geriausių Australijos architektūros ikonų. Šis įspūdingas konstrukcijos žygdarbis, švelniai vadinamas „dangteliu“, yra didžiausias plieninis arkinis tiltas pasaulyje. Jis buvo baigtas 1932 m., likus 40 metų iki Sidnėjaus operos teatro."}};
    
                foreach (var objektas in sarasas)
                { 
                    Console.WriteLine($"\n" + objektas.Key + " : " + objektas.Value);
                    Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");
                }            
        }
    }

    class Naujoji_Zelandija: okeanijos_salys , IObjektas
    {
        public void Objekto_pavadinimas_istorija()
        {
            IDictionary<string, string> sarasas  = new Dictionary<string, string>(){
            {"1. Salų įlanka", "A three-hour drive north of Auckland, the beautiful Bay of Islands is one of the most popular vacation destinations in the country. More than 144 islands dot the glittering bay, making it a haven for sailing and yachting. Penguins, dolphins, whales, and marlin live in these fertile waters, and the region is a popular sport-fishing spot. Visitors can sea kayak along the coast, hike the many island trails, bask in secluded coves, tour Cape Brett and the famous rock formation called Hole in the Rock, and explore subtropical forests where Kauri trees grow. The quaint towns in the area such as Russell, Opua, Paihia, and Kerikeri are great bases for exploring this scenic bay."}, 
            {"2. Queenstown", "Kvinstaunas, įsitaisęs tarp mirgančio Wakatipu ežero krantų ir snieguotų Remarkables viršūnių, yra Naujosios Zelandijos nuotykių sostinė ir viena iš populiariausių šalies krypčių tarptautiniams lankytojams. Šuoliai su guma, plaukiojimas vandens motociklais, plaukimas plaustais, skraidymas parasparniais, kopimas uolomis, kalnų dviračiais ir kalnų slidinėjimas – tai tik dalis adrenalino kupinų dalykų, kuriuos čia galima nuveikti, o lankytojai gali apžiūrėti nuostabius Alpių kraštovaizdžius puikiame pėsčiųjų takų tinkle."},
            {"3. Rotorua", "Audringame Ramiojo vandenyno ugnies žiede Rotorua yra vienas aktyviausių geoterminių regionų pasaulyje. Tai žemė, kurioje kalba žemė. Verdantys purvo baseinai, šnypštantys geizeriai, ugnikalnių krateriai ir garuojančios šiluminės versmės išduoda jėgas, kurios sukūrė didžiąją dalį dramatiškos Naujosios Zelandijos topografijos."}};
    
                foreach (var objektas in sarasas)
                { 
                    Console.WriteLine($"\n" + objektas.Key + " : " + objektas.Value);
                    Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");
                }            
        }
    }
}