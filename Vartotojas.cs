using System;
using System.Collections;
using System.Collections.Generic;

namespace kursinis

{
    class Vartotojas
        {   
            public string vardas;
            private string slaptazodis = "admin";
            private bool atpazinimas;

            public bool Prisijungimas(string Slaptazodis)
            {
                if (slaptazodis==Slaptazodis)
                {
                    atpazinimas = true;
                }
                else 
                {
                    atpazinimas = false;
                }
                return atpazinimas;
            }
            public bool GautiAtpazinima()
            {
                return atpazinimas;
            }
        }
}