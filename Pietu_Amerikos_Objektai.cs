using System;
using System.Collections;
using System.Collections.Generic;

namespace kursinis

{
    public class funkcijapa 
    {
        public void rodyti(string pasirinkimas2)
        {
            if (pasirinkimas2 == "Brazilija")
            {
                Brazilija objektai = new Brazilija();
                objektai.Objekto_pavadinimas_istorija();
            }
            else if (pasirinkimas2 == "Argentina")
            {
                Argentina objektai = new Argentina();
                objektai.Objekto_pavadinimas_istorija();
            }
            else
            {
                Cile objektai = new Cile();
                objektai.Objekto_pavadinimas_istorija();
            }
        }
        public void rodyti(int pasirinkimas)
        {
            switch (pasirinkimas)
            {
                case 1: 
                Brazilija objektai = new Brazilija();
                objektai.Objekto_pavadinimas_istorija();
                break;

                case 2:
                Cile objektai1 = new Cile();
                objektai1.Objekto_pavadinimas_istorija();
                break;

                case 3:
                Argentina objektai2 = new Argentina();
                objektai2.Objekto_pavadinimas_istorija();
                break;
            }
        }
    }
    class Brazilija : pa_salys, IObjektas
    {
        public void Objekto_pavadinimas_istorija()
        {
            IDictionary<string, string> sarasas  = new Dictionary<string, string>(){
            {"1. Cristo Redentor and Corcovado", "709 metrų aukštis, ant kurio stovi, yra Tijuca nacionalinio parko dalis, o stelažų geležinkelis pakyla 3,5 kilometro į viršų, kur statulą supa plati aikštė. 30 metrų statula, pastatyta 1931 m., buvo lenkų ir prancūzų skulptoriaus Paulo Landowskio ir brazilų inžinieriaus Heitor da Silva Costa darbas, pastatyta iš gelžbetonio ir muilo akmens."}, 
            {"2. Sugar Loaf", "Lengvai atpažįstama Rio de Žaneiro emblema, apvali Cukraus kepalo uolos viršūnė, iškilusi iš medžiais apaugusio iškyšulio, iškilusi 394 metrus virš paplūdimių ir miesto. Jo viršukalnė yra viena iš pirmųjų lankytinų vietų turistams, iš kurios atsiveria vaizdai į Rio ir uostą ir važiuojant lynų keltuvu tarp Cukraus kepalo ir Morro da Urca – žemesnės viršukalnės, nuo kurios jungiasi antrasis lynų kelias. į miestą."},
            {"3. Copacabana", "Madingiausia ir žinomiausia Rio de Žaneiro centro atkarpa seka Avenida Nossa Senhora de Copacabana ir iš vienos pusės ribojasi su keturiais kilometrais balto smėlio ir banglenčių bangų. Paplūdimį nuo pastatų ir eismo skiria plati promenada, grįsta juodai balta mozaika banguotu raštu, primenančiu Lisabonos, Portugalijos gatves."}};
    
                foreach (var objektas in sarasas)
                { 
                    Console.WriteLine($"\n" + objektas.Key + " : " + objektas.Value);
                    Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");
                }            
        }
    }

    class Cile: pa_salys, IObjektas
    {
        public void Objekto_pavadinimas_istorija()
        {
            IDictionary<string, string> sarasas  = new Dictionary<string, string>(){
            {"1. Torres Del Paine Nacionalinis Parkas", "Viena iš svarbiausių Čilės gamtos zonų ir vis populiarėjanti kelionių kryptis yra įspūdingas Torres del Paine nacionalinis parkas. Įsikūręs daugiau nei 100 kilometrų į šiaurę nuo Puerto Natales miesto pietų Patagonijoje, ši nuostabiai graži vietovė apima kalnus, ledynus ir daugybę ežerų bei upių."}, 
            {"2. Santiago", "Santjagas yra ne tik Čilės finansų ir verslo sostinė, bet ir šalies kultūros ir pramogų centras. Todėl čia galima nuveikti begalę įdomių dalykų, įskaitant lankymąsi geriausiuose muziejuose ir galerijose, taip pat puikias apsipirkimo, maitinimo ir viešbučių galimybes."},
            {"3. Cape Horn", "Keliautojams laikomas Šventuoju Graliu – ir Everesto kalno atitikmeniu buriuotojams – Horno kyšulys yra vertas pastangų, jei ne pasigyrimo. Paskutinė stotelė prieš Antarktidą ir piečiausią pasaulio viršūnę, Horno kyšulys šimtmečius garsėjo kaip jūreivių kapinės dėl savo atokumo, pavojingos pakrantės ir čia vyraujančios banguotos jūros. Nors dabar Panamos kanalo dėka jis yra mažiau svarbus kaip prekybos maršrutas, jis išpopuliarėjo tarp rimtų buriavimo entuziastų ir dalyvauja daugelyje įdomių lenktyni"}};
    
                foreach (var objektas in sarasas)
                { 
                    Console.WriteLine($"\n" + objektas.Key + " : " + objektas.Value);
                    Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");
                }            
        }
    }
    class Argentina : pa_salys, IObjektas
    {
      public void Objekto_pavadinimas_istorija()
        {
            IDictionary<string, string> sarasas  = new Dictionary<string, string>(){
            {"1. Perito Moreno Glacier", "Pagrindinis turistų, lankančių į UNESCO pasaulio paveldo sąrašą įtrauktą Patagonijos Los Glaciares nacionalinį parką, centras, mažas El Calafate miestelis siūlo daugybę apgyvendinimo galimybių ir kitų patogumų lankytojams."}, 
            {"2. Tierra del Fuego Nacionalinis Parkas", "156 000 akrų Tierra del Fuego nacionalinis parkas tęsiasi nuo Biglio kanalo iki Čilės sienos ir į šiaurę iki Lago Kami. Tai žygeivių rojus su įvairaus lygio takais."},
            {"3. Ushuaia: The End of the World", "Pietiniame Argentinos gale esanti Patagonija garsėja įspūdingais kraštovaizdžiais: dramatišku Andų kalnų ir ilgų lygumų bei plokščiakalnių deriniu. Dauguma nuotykių čia prasideda Ušuaja, piečiausiame pasaulio mieste."}};
            
                foreach (var objektas in sarasas)
                { 
                    Console.WriteLine($"\n" + objektas.Key + " : " + objektas.Value);
                    Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");
                }            
        }
    }
}