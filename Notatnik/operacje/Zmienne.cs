using System;
using System.Collections.Generic;
using System.Text;

namespace Notatnik.operacje
{
    public class Zmienne
    {
        public Zmienne()
        { 
           
        }


        #region Generowanie loginu i hasła do zabezpieczenia aplikacji (login i hasło są generowane podczas zdarzenia logowania)

        /// <summary>
        /// Generuje nowy login na podstawie schematu
        /// </summary>
        /// <returns></returns>
        public string GenerujNowyLogin()
        {

            string NowyLogin = "";

            DateTime data = new DateTime();
            var a = data.Day.ToString();
            var b = "nexio";
            var c = data.Hour.ToString();

            return NowyLogin = (a + b + c).ToString();
        }

        /// <summary>
        /// Generuje nowe hasło na podstawie schematu
        /// </summary>
        /// <returns></returns>
        public string GenerujNoweHaslo()
        {
            DateTime data = new DateTime();

            string NoweHaslo = "";

            var a = data.Year.ToString();
            var b = data.Month.ToString();
            var c = data.Day.ToString();

            return NoweHaslo = (a.Replace("0", "a") + b.Replace("1", "c") + c.Replace("2", "c")).ToString();
        }
        #endregion




    }
}
