using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuisOpdrachtTDD
{
    public class Persoon
    {
        private List<string> voornamen;
        public Persoon(List<string> voornamen)
        {
            this.voornamen = voornamen;
            if (voornamen==null)
                throw new ArgumentException();

            string voornaamStart;



           if ( voornamen.Count != voornamen.Distinct().Count())
            {
                throw new ArgumentException();
            }


            foreach (var voornaam in voornamen)
            {
                var aantalNamen = 0;
                voornaamStart = voornaam;

                if (voornaam == " ")
                    throw new ArgumentException();
                if (voornaam == "")
                    throw new ArgumentException();

                //foreach (var voornaamVergelijk in voornamen)
                //{

                //    if (voornaamStart == voornaamVergelijk)
                //    {
                //        aantalNamen++;
                //        if (aantalNamen > 1)
                //            throw new ArgumentException();
                //    }
                //}
            }


        }
        public override string ToString()
        {
            //string namenLijst = voornamen[0];

            //for (var lijst = 1;lijst < voornamen.Count;lijst++)
            //{
            //    namenLijst += $" {voornamen[lijst]}";
            //}
            //return namenLijst.ToString();

            return string.Join(" ", voornamen);
        }
    }
}
