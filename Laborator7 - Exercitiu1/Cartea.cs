using System;

namespace Laborator7___Exercitiu1
{
    class Cartea
    {
        public enum Culori
        {
            InimaRosie, InimaNeagra, Romb, Trifoi,
        }

        public enum Valori
        {
            UNU, DOI, TREI, PATRU, CINCI, SASE, SAPTE, OPT, NOUA, ZECE, JUVETE, DAMA, POPA, AS
        }

        public Cartea(Culori TipCulori, Valori TipValori)
        {
            CuloriMana = TipCulori;
            ValoriMana = TipValori;
        }

        public Culori CuloriMana { get; set; }
        public Valori ValoriMana { get; set; }

        public string GetCard()
        {
           return CuloriMana.ToString() + "-" + ValoriMana.ToString();
        }

    }
}