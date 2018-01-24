using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThuisOpdrachtTDD1;
using System.Collections.Generic;

namespace OpdrachtTDDTest
{
    [TestClass]
    public class PersoonTest
    {
        private List<string> namen;
        [TestInitialize]
        public void Initialize()
        {
            namen = new List<string>();
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void GeenLijstMoetEenFoutGenereren()
        {
            namen = null;
            new Persoon(namen);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void GeenVoornaamMoetEenFoutGenereren()
        {
            namen.Add("");
            new Persoon(namen);
        }


        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void TweeDezelfdeVoornamenMoetEenFoutGenereren()
        {
            namen.Add("Jan");
            namen.Add("Jan");
            new Persoon(namen);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void MeerdereNamenMetTweeDezelfdeVoornamenMoetEenFoutGenereren()
        {
            namen.Add("Jan");
            namen.Add("Jef");
            namen.Add("Jan");
            namen.Add("Piet");
            new Persoon(namen);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EnkelSpatieInVoornaamMoetEenFoutGenereren()
        {
            namen.Add(" ");
            new Persoon(namen);
        }

        [TestMethod]
        public void DeToStringMoetAlleVoornamenTeruggeven()
        {
            namen.Add("Jan");
            namen.Add("Piet");
            namen.Add("John");
            var personen = new Persoon(namen);
            Assert.AreEqual("Jan Piet John", personen.ToString());

        }

    }
}
