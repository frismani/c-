using System;
using System.Collections;
using System.Collections.Generic;

namespace kursinis

{
        public abstract class zemynai
        {
            public virtual string info(string pasirinkimas)
            {
                
                return "\nŽemė skirstoma į 7 žemynus: Europą, Aziją, Afriką, Šiaurės Ameriką, Pietų Ameriką, Okeaniją ir Antarktidą.";
            }
        }
        
        public class europa : zemynai
        {
            public override string info(string pasirinkimas)
            {
                string info = base.info(pasirinkimas);
                info += $"\n\nTavo pasirinktas žemynas: {pasirinkimas} \nŠis žemynas antras mažiausias pagal plotą žemynas, bet taip pat jis yra trečioje vietoje pagal populiacijos dydį";
                return info;
            }
        }
        public class afrika : zemynai
        {
            public override string info(string pasirinkimas)
            {
                string info = base.info(pasirinkimas);
                info += $"\n\nTavo pasirinktas žemynas: {pasirinkimas} \nŠis žemynas antras pagal dydį žemynas. Jis taip pat laikomas pačiu karščiausiu žemynų pasaulyje";
                return info;
            }
        }
        public class siaures_amerika : zemynai
        {
            public override string info(string pasirinkimas)
            {
                string info = base.info(pasirinkimas);
                info += $"\n\nTavo pasirinktas žemynas: {pasirinkimas} \nŠis žemynas trečias mažiausias pagal plotą žemynas, bet taip pat jis yra ketvirtoje vietoje pagal populiacijos dydį";
                return info;
            }
        }
        public class pietu_amerika : zemynai
        {
            public override string info(string pasirinkimas)
            {
                string info = base.info(pasirinkimas);
                info += $"\n\nTavo pasirinktas žemynas: {pasirinkimas} \nŠiame žemyne naudojame daugiau nei 300 skirtingų kalbų. Anksčiau jis buvo sujungtas su Afrikos žemynu";
                return info;
            }
        }
        public class azija : zemynai
        {
            public override string info(string pasirinkimas)
            {
                string info = base.info(pasirinkimas);
                info += $"\n\nTavo pasirinktas žemynas: {pasirinkimas}\nDidžiausias žemynas pasaulyje, turintys aukščiausius kalnus bei didžiausią kiekį milijardierių.";
                return info;
            }
        }
        public class okeanija : zemynai
        {
            public override string info(string pasirinkimas)
            {
                string info = base.info(pasirinkimas);
                info += $"\n\nTavo pasirinktas žemynas: {pasirinkimas} \nMažiausias pagal plotą žemynas pasaulyje. Tačiau jo plotis yra didesnis už Mėnulio.";
                return info;
            }
        }
        public class antarktida : zemynai
        {
            public override string info(string pasirinkimas)
            {
                string info = base.info(pasirinkimas);
                info += $"\n\nTavo pasirinktas žemynas: {pasirinkimas}\nŠalčiausias žemynas žemėje, turintys 90 procentų visos žemės ledo";
                return info;
            }
        }

}