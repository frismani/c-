using System;
using System.Collections;
using System.Collections.Generic;

namespace kursinis

{
    public class funkcija
    {
        public void rodyti(string pasirinkimas2)
        {
            if (pasirinkimas2 == "Italija")
            {
                Italija objektai = new Italija();
                objektai.Objekto_pavadinimas_istorija();
            }
            else if (pasirinkimas2 == "Prancūzija")
            {
                Prancuzija objektai = new Prancuzija();
                objektai.Objekto_pavadinimas_istorija();
            }
            else
            {
                Ispanija objektai = new Ispanija();
                objektai.Objekto_pavadinimas_istorija();
            }
        }

        public void rodyti(int pasirinkimas)
        {
            switch (pasirinkimas)
            {
                case 1: 
                Italija objektai = new Italija();
                objektai.Objekto_pavadinimas_istorija();
                break;

                case 2:
                Prancuzija objektai2 = new Prancuzija();
                objektai2.Objekto_pavadinimas_istorija();
                break;

                case 3: 
                Ispanija objektai3 = new Ispanija();
                objektai3.Objekto_pavadinimas_istorija();  
                break;
            }
        }
    }
    class Italija : europos_salys, IObjektas
    {
        public void Objekto_pavadinimas_istorija()
    
        {
            IDictionary<string, string> sarasas  = new Dictionary<string, string>(){
            {"1. Koliziejus", "Tai didelis amfiteatras, didžiausias tokio tipo objektas, pastatytas Romos Imperijoje, ir geriausiai išsilaikęs. Pastatytas Vespasian imperatoriumi 72 AD. Šiame pastate vyko vieši spektakliai ir pasirodymai, kurių metu dažniausiai vyko kovos tarp gladiatorių bei gyvūnų. 83mx48m dydžio medinės grindys po savinimi slėpė istorijos pripildytus tunelius, kambarius bei kameras, kuriose buvo laikomi gladiatoriai, laukiai gyvūnai bei darbuotojai. Daugiau informacijos: https://www.planetware.com/rome/colosseum-i-la-rcl.htm"}, 
            {"2. Vatikanas", "Vatikane galima pamatyti įžymiausių meno kūrinių, tokių kaip Michelangelo sukurta 'Pieta' suklptūra. Daugiau informacijos https://www.planetware.com/tourist-attractions-/vatican-city-scv-scv-rvc.htm"},
            {"3. Didysis Venecijos Kanalas", "Kelionė gondola Venecijos kanalu labiausiai pamegta keliautojų pramoga. Didysis kanalas yra didžiausias tokio tipo kanalas, apsupantis visą miestą. Kanalo pakrantėse išsidėstę rūmai, kadaise priklausę turtingiausioms ir daugiausiai galios turinčioms šeimoms Venecijos Respublikoje. Daugiau informacijos: https://www.planetware.com/tourist-attractions-/venice-i-vn-v.htm"}};
    
                foreach (var objektas in sarasas)
                { 
                    Console.WriteLine($"\n" + objektas.Key + " : " + objektas.Value);
                    Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");
                }            
        }
    }

    class Ispanija : europos_salys, IObjektas
    {
        public void Objekto_pavadinimas_istorija()
        {
            IDictionary<string, string> sarasas  = new Dictionary<string, string>(){
            {"1. Sagrada Familia", "Žymaus architekto Antoni Gaudi pastatya bažnyčia, kuri iki šiol nėra pabaigta statyti (statybų pradžia - 1882 m). "}, 
            {"2. 'Plaza Mayor", "Pagrindinė Ispanijos sostinės aikštė, suprojektuota dar 16-tame amžiuje Filipo II įsakymu. Šioje aikštėje vyko įvairios ceremonijos - naujo karaliaus paskelbimas, šventųjų paskelbimas šventais, eretikų sudeginimas bei viešos pramokos, tokios kaip riteriški turnyrai ir bulių kautynės"},
            {"3. Sevilijos Katedra", "Ši katedra yra įrašyta į UNESCO Paveldo Sąrašą. Pagrindinis altorius yra 37 metrų, apsuptas statulų, pilnai padarytų iš aukso."}};
    
                foreach (var objektas in sarasas)
                { 
                    Console.WriteLine($"\n" + objektas.Key + " : " + objektas.Value);
                    Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");
                }            
        }
    }
    class Prancuzija: europos_salys, IObjektas
    {
      public void Objekto_pavadinimas_istorija()
        {
            IDictionary<string, string> sarasas  = new Dictionary<string, string>(){
            {"1. Eifelio Bokštas", "Tai Paryžiaus simbolis, sukurtas Gustav Eiffel ir sudarytas iš 8,000 metalinių detalių. Ši konstrukcija buvo sukurta kaip laikina ekspozicija 1889 metais, tačiau ji išliko iki šiol. Bokšto aukštis -  320 metrų. Antrame bokšto aukšte įsikūręs restoranas, o 276 metrų aukštyje - apžiūros aikštelė, iš kurios matosi visas Paryžiaus miestas"},
            {"2. Luvro Muziejus", "Kadaise tai buvusi karališka rezidencija, dabar tai vienas žymiausių muziejų, saugantis įvairas žymiausias meto kolekcijas. Muziejiuje galima aptikti tokius garsius kūrinius, kaip Leonardo Da Vinci nutapytą 'Mona Lisa' paveikslą. Iš viso muziejuje saugoma apie 35,000 meno kūrinių."},
            {"3. Chamonix-Mont-Blanc", "Kaimas, prie Alpių kalnų, šalia aukščiausio Europos taško, kurio aukštis - 4,810 metrų. Kaime galima rasti iš senovės likusių bažnyčių, tradicinių Alpių restoranų bei įstabių polsio namelių. Ši vieta yra labai pamėgta slidininkų, žmonių, ieškančių ramybės ar atvirkščiai - nuotykių."}};
    
                foreach (var objektas in sarasas)
                { 
                    Console.WriteLine($"\n" + objektas.Key + " : " + objektas.Value);
                    Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");
                }            
        }
    }
}