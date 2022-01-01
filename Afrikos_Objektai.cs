using System;
using System.Collections;
using System.Collections.Generic;

namespace kursinis

{
    public class funkcijaaf 
    {
        public void rodyti(string pasirinkimas2)
        {
            if (pasirinkimas2 == "Pietų Afrikos Respublika")
            {
                PAR objektai = new PAR();
                objektai.Objekto_pavadinimas_istorija();
            }
            else if (pasirinkimas2 == "Tanzanija")
            {
                Tanzanija objektai = new Tanzanija();
                objektai.Objekto_pavadinimas_istorija();
            }
            else
            {
                Madagaskaras objektai = new Madagaskaras();
                objektai.Objekto_pavadinimas_istorija();
            }
        }

        public void rodyti(int pasirinkimas)
        {
            switch (pasirinkimas)
            {
                case 1: 
                PAR objektai = new PAR();
                objektai.Objekto_pavadinimas_istorija();
                break;

                case 2:
                Madagaskaras objektai1 = new Madagaskaras();
                objektai1.Objekto_pavadinimas_istorija();
                break;

                case 3: 
                Tanzanija objektai2 = new Tanzanija();
                objektai2.Objekto_pavadinimas_istorija();
                break;
            }
        }
    }
    
    class PAR : afrikos_salys, IObjektas
    {
        public void Objekto_pavadinimas_istorija()
        {
            IDictionary<string, string> sarasas  = new Dictionary<string, string>(){
            {"1. Krugerio Nacionalinis Parkas", "Šis parkas yra vienas geriausių medžiojamųjų gyvūnų rezervatų Afrikoje ir vienas seniausių Pietų Afrikoje. Jei esate laukinės gamtos mylėtojas, šis garsusis parkas tikrai turi būti jūsų Pietų Afrikos maršrute."}, 
            {"2. Cape Town", "Vienas iš geriausių dalykų, kuriuos reikia padaryti Keiptaune, yra aplankyti Stalo kalną, plokščią viršukalnę, kuri vadovauja miestui. Norėdami pamatyti įspūdingą apžvalgą, žygiuokite į viršukalnę arba užsukite lynų keliu. Valandą trunkantis žygis į Liūto galvą taip pat suteikia panoraminius miesto vaizdus."},
            {"3. Johannesburg", "Johanesburgas, taip pat žinomas kaip Jo'burgas, yra didžiausias Pietų Afrikos miestas pagal gyventojų skaičių ir vartai daugeliui keliautojų safaryje. „Aukso miestu“ pavadintas dėl turtingų tauriųjų metalų telkinių, jis taip pat yra ekonomikos variklis ir gyvybinga šalies širdis. Populiariausios Johanesburgo lankytinos vietos yra Apartheido muziejus, jaudinantis žvilgsnis į apartheido priespaudą iki demokratijos gimimo; Konstitucijos kalnas; ir Gold Reef City, kuriame regiono istorija atsekama per kalnakasybos tematikos lankytinas vietas."}};
    
                foreach (var objektas in sarasas)
                { 
                    Console.WriteLine($"\n" + objektas.Key + " : " + objektas.Value);
                    Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");
                }            
        }
    }

    class Madagaskaras: afrikos_salys, IObjektas
    {
        public void Objekto_pavadinimas_istorija()
        {
            IDictionary<string, string> sarasas  = new Dictionary<string, string>(){
            {"1. Ifaty", "Ifaty yra pavadinimas, suteiktas dviem dulkėtiems žvejų kaimams pietvakarių Madagaskaro pakrantėje. Atviroje jūroje 60 mylių ilgio koralinis rifas yra natūrali kliūtis banguotoms jūros bangoms, sukurianti pakrantės vandenis, kurie idealiai tinka nardymui, nardymui ir žvejybai. Dykumos vidaus teritorija yra žinoma dėl savo dygliuoto miško, kuriame keistos formos baobabai klestėjo šimtmečius."}, 
            {"2. Nosy Be", "Maža Nosy Be sala yra viena iš svarbiausių Madagaskaro turistinių vietų, pritraukianti tūkstančius turistų iš viso pasaulio ištisus metus. Nors Nosy Be paplūdimiai atrodo ne taip tobulai kaip kai kurie kiti atogrąžų paplūdimiai, jie pelno taškų už ramybę, skaidrų turkio spalvos vandenį ir puikius jūros gėrybių restoranus, kuriuose patiekiami jūros gėrybių pietūs ant smėlio."},
            {"3. Isalo Nacionalinis Parkas", "Isalo nacionalinis parkas pasižymi įvairiu reljefu. Įsikūręs centriniame pietiniame Madagaskaro regione, parke yra pievų, stačių kanjonų ir smiltainio darinių, kuriuos retkarčiais apsodina palmėmis apsodinti baseinai. Kaip ir daugelyje šalies nacionalinių parkų, reikalingi gidai. Ekskursijos gali būti suplanuotos taip, kad jos truktų kelias valandas arba kelias dienas."}};
    
                foreach (var objektas in sarasas)
                { 
                    Console.WriteLine($"\n" + objektas.Key + " : " + objektas.Value);
                    Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");
                }            
        }
    }
    class Tanzanija : afrikos_salys, IObjektas
    {
      public void Objekto_pavadinimas_istorija()
        {
            IDictionary<string, string> sarasas  = new Dictionary<string, string>(){
            {"1. Kilimanjaro Kalnas", "Kilimandžaro kalnas yra aukščiausia Afrikos viršukalnė (5 895 m) ir garsiausias Tanzanijos vaizdas. Kilimandžaro kalno nacionalinis parkas, skirtingai nei kiti šiaurinės Tanzanijos parkai, yra lankomas ne dėl laukinės gamtos, o dėl galimybės stebėti šį nuostabų snieguotą kalną ir daugeliui užkopti į viršūnę. Į Kilimandžaro kalną galima įkopti bet kuriuo metu, nors geriausias laikotarpis yra nuo birželio pabaigos iki spalio, sausojo sezono metu."}, 
            {"2. Serengeti Nacionalis Parkas", "Serengečio nacionalinis parkas yra didžiulė bemedžių lyguma, kurioje gyvena milijonai gyvūnų arba eina pro šalį ieškoti šviežių pievų. Jis labiausiai žinomas dėl kasmetinės gnu migracijos, tačiau čia taip pat galite pamatyti Didįjį penketą, o Serengetyje užregistruota beveik 500 paukščių rūšių."},
            {"3. Zanzibaro pakrantės", "Zanzibaro sala, dar vadinama Ungudža, yra pagrindinė atostogų vieta Tanzanijoje ir žinoma dėl nuostabių paplūdimių. Dalis Zanzibaro archipelago, kurį sudaro Zanzibaro ir Pembos salos, yra vieni geriausių paplūdimių pasaulyje. Naršymas banglente skiriasi priklausomai nuo to, kurioje salos pusėje esate, tačiau lankytojai ras minkšto balto smėlio ir skaidraus sekliojo vandens bei tradicinių laivelių."}};
            
                foreach (var objektas in sarasas)
                { 
                    Console.WriteLine($"\n" + objektas.Key + " : " + objektas.Value);
                    Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");
                }            
        }
    }
}