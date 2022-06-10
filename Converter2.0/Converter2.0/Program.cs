using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCollection;

namespace Converter2._0
{
    static class Program
    {
        public static BiTable valori = new BiTable();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ValoriSetup();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void ValoriSetup()
        {
            valori.Add("a", "Afo4");
            valori.Add("b", "zeba");
            valori.Add("c", "1fRb");
            valori.Add("d", "0aNw");
            valori.Add("e", "8AoR");
            valori.Add("f", "D3g4");
            valori.Add("g", "(DaW");
            valori.Add("h", "FRd5");
            valori.Add("i", "Haj*");
            valori.Add("l", "Rgs8");
            valori.Add("m", "Jar(");
            valori.Add("n", "Ka%e");
            valori.Add("o", "Mef6");
            valori.Add("p", "gh5e");
            valori.Add("q", "hcv$");
            valori.Add("r", "sde4");
            valori.Add("s", "s7af");
            valori.Add("t", "07aw");
            valori.Add("u", "Fgr4");
            valori.Add("v", "Qea8");
            valori.Add("z", "R54s");
            valori.Add("k", "Zp4R");
            valori.Add("j", "RtfD");
            valori.Add("x", "asd$");
            valori.Add("y", "Lot%");
            valori.Add("w", "Az£3");
            valori.Add(".", "d()z");
            valori.Add(",", "E()f");
            valori.Add("?", "k[]e");
            valori.Add("!", "s[]w");
            valori.Add(" ", "flrZ");
            valori.Add("\"", "Ds{}");
        }
    }
}
