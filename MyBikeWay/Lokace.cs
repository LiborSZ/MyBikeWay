using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikeWay
{
    internal class Lokace
    {
        /// <summary>
        /// Název lokace
        /// </summary>
        public string Nazev { get; private set; }
        /// <summary>
        /// Sořadnice X v desetinných stupních (ve formátu xx.xxxxx)
        /// </summary>
        public double SouradniceX { get; private set; }
        /// <summary>
        /// Sořadnice Y v desetinných stupních (ve formátu yy.yyyyy)
        /// </summary>
        public double SouradniceY { get; private set; }
        /// <summary>
        /// Počet Km nejlibší trasy z výchozí polohy
        /// </summary>
        public int VzdalenostOdVychozi { get; private set; }
        /// <summary>
        /// Kontruktor lokace inicializující její vlastnosti
        /// </summary>
        /// <param name="nazev"></param>
        /// <param name="souradniceX"></param>
        /// <param name="souradniceY"></param>
        /// <param name="vzdalenost"></param>
        public Lokace(string nazev, double souradniceX, double souradniceY, int vzdalenost)
        {
            Nazev = nazev;
            SouradniceX = souradniceX;
            SouradniceY = souradniceY;
            VzdalenostOdVychozi = vzdalenost;
        }
        /// <summary>
        /// Vypíše jméno lokace a její vzdálenost od výchozí hodnoty
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format($"{Nazev} je vzdálený od výchozí lokace o {VzdalenostOdVychozi}");
        }
    }
}
