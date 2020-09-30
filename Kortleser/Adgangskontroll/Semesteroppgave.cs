using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Adgangskontroll
{
    public static class Semesteroppgave
    {
        /// <summary>
        /// Behandler data fra simsim
        /// </summary>
        /// <param name="simsimData"></param>
        /// <returns></returns>
        public static List<object> BehandleSimsimData(string simsimData)
        {
            List<object> simsimDataList = new List<object>();
            char[] split = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            char[] trim = { '$', '#' };
            // Trimmer vekk $ og #
            simsimData = simsimData.Trim(trim);
            // Splitter opp strengen ved starten av hvert datafelt
            string[] simsimDatafelt = simsimData.Split(split, StringSplitOptions.RemoveEmptyEntries);
            // Begynner å legge til objekter i datalisten:
            simsimDataList.Add(Convert.ToInt16(simsimDatafelt[0]));
            // Konverterer dato og klokkeslett til datetime objekter og legger til i listen:
            string[] formats = { "yyyyMMdd", "HHmmss" };
            string date = simsimDatafelt[1];
            string time = simsimDatafelt[2];
            DateTime _date = DateTime.ParseExact(date, formats[0], CultureInfo.InvariantCulture);
            simsimDataList.Add(_date);
            DateTime _time = DateTime.ParseExact(time, formats[1], CultureInfo.InvariantCulture);
            simsimDataList.Add(_time);
            // Konverterer til bool array vha LINQ og legger i datalisten:
            bool[] DI = simsimDatafelt[3].Select(c => c == '1').ToArray();
            simsimDataList.Add(DI);
            bool[] DO = simsimDatafelt[4].Select(c => c == '1').ToArray();
            simsimDataList.Add(DO);
            // Legger til termistor, potmeter og temperaturfølere
            for (int i = 5; i < simsimDatafelt.Length; i++)
            {
                simsimDataList.Add(Convert.ToInt16(simsimDatafelt[i]));
            }
            return simsimDataList;
        }

        public static bool[] ToBoolArray(string simsimDatafelt)
        {
            var string2Bool = simsimDatafelt.Select(c => c == '1').ToArray();
            return string2Bool;
        }
    }
}