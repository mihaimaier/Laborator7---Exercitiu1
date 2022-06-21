using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator7___Exercitiu1
{
    class Mana
    {
        public Cartea Cartea1 { get; set; }
        public Cartea Cartea2 { get; set; }
        public Cartea Cartea3 { get; set; }
        public Cartea Cartea4 { get; set; }
        public Cartea Cartea5 { get; set; }

        private int NumarDeInimaNeagra = 0;
        private int NumarDeInimaRosie = 0;

        public Mana(Cartea Cartea1, Cartea Cartea2, Cartea Cartea3, Cartea Cartea4, Cartea Cartea5)
        {
            this.Cartea1 = Cartea1;
            this.Cartea2 = Cartea2;
            this.Cartea3 = Cartea3;
            this.Cartea4 = Cartea4;
            this.Cartea5 = Cartea5;

            switch (Cartea1.CuloriMana)
            {
                case Cartea.Culori.InimaNeagra:
                    NumarDeInimaNeagra++;
                    break;
                case Cartea.Culori.InimaRosie:
                    NumarDeInimaRosie++;
                    break;
                default:
                    break;
            }
            switch (Cartea2.CuloriMana)
            {
                case Cartea.Culori.InimaNeagra:
                    NumarDeInimaNeagra++;
                    break;
                case Cartea.Culori.InimaRosie:
                    NumarDeInimaRosie++;
                    break;
                default:
                    break;
            }
            switch (Cartea3.CuloriMana)
            {
                case Cartea.Culori.InimaNeagra:
                    NumarDeInimaNeagra++;
                    break;
                case Cartea.Culori.InimaRosie:
                    NumarDeInimaRosie++;
                    break;
                default:
                    break;
            }
            switch (Cartea4.CuloriMana)
            {
                case Cartea.Culori.InimaNeagra:
                    NumarDeInimaNeagra++;
                    break;
                case Cartea.Culori.InimaRosie:
                    NumarDeInimaRosie++;
                    break;
                default:
                    break;
            }
            switch (Cartea5.CuloriMana)
            {
                case Cartea.Culori.InimaNeagra:
                    NumarDeInimaNeagra++;
                    break;
                case Cartea.Culori.InimaRosie:
                    NumarDeInimaRosie++;
                    break;
                default:
                    break;
            }
        }
        public void GetMana()
        {
            if (NumarDeInimaNeagra == 5)
            {
                Console.WriteLine("Royal Flush");
            }
            else if (NumarDeInimaRosie == 5)
            {
                Console.WriteLine("Straight Flush");
            }
            else if (Cartea1.ValoriMana == Cartea2.ValoriMana && Cartea1.ValoriMana == Cartea3.ValoriMana && Cartea1.ValoriMana == Cartea4.ValoriMana ||
              Cartea1.ValoriMana == Cartea2.ValoriMana && Cartea1.ValoriMana == Cartea3.ValoriMana && Cartea1.ValoriMana == Cartea5.ValoriMana ||
              Cartea1.ValoriMana == Cartea3.ValoriMana && Cartea1.ValoriMana == Cartea4.ValoriMana && Cartea1.ValoriMana == Cartea5.ValoriMana ||
              Cartea2.ValoriMana == Cartea3.ValoriMana && Cartea2.ValoriMana == Cartea4.ValoriMana && Cartea2.ValoriMana == Cartea5.ValoriMana)
            {
                Console.WriteLine("Four of a kind");
            }
            else
            {
                Console.WriteLine("Comuna");
            }
        }

        public void Tipareste()
        {
            string rezult = Cartea1.GetCard() + "\n" + Cartea2.GetCard() + "\n" + Cartea3.GetCard() + "\n" + Cartea4.GetCard() + "\n" + Cartea5.GetCard();
            Console.WriteLine(rezult);

        }
    }

}
