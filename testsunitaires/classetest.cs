using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using M2LCSHARP;
using M2LCSHARP.DATA;

namespace testsunitaires
{
    public class classetest
    {

        
        [Fact]
        public void testadherent()
        {
            adherent adhtest = new adherent("Bertrand", "jean", "92130", "6 squares louis blé", "Issy-les-mx");
            Assert.Equal("Bertrand", adhtest.Nom);
            
        }
        [Fact]
        public void testtype_club()
        {
            type_club tc = new type_club(18, "foot");
            Assert.Equal(18, tc.id_type);
            Assert.Equal("foot", tc.libelle);
        }
        [Fact]
        public void testclub()
        {
            type_club tc = new type_club(20, "tennis");
            club club = new club("un club", "une url", "une adresse", "un CP", "une ville", "un mail", 012345679, tc);
            club cluba = club;
            Assert.Equal("tennis", club.type.libelle);
            Assert.Equal(club, cluba);
            Assert.Equal("un club", cluba.Titre_club);
        }
        [Fact]
        public void testnbradh()
        {

            type_club tc = new type_club(20, "tennis");
            club club = new club("un club", "une url", "une adresse", "un CP", "une ville", "un mail", 012345679, tc);
            adherent adhtest = new adherent("Bertrand", "jean", "92130", "6 squares louis blé", "Issy-les-mx");
            adherent adhtest1 = new adherent("Bertrand", "Paul", "92130", "6 squares louis blé", "Issy-les-mx");
            adherent adhtest2 = new adherent("Bertrand", "Romain", "92130", "6 squares louis blé", "Issy-les-mx");
            adhtest2.Id = 28;
            adherent adhtest3 = new adherent("Bertrand", "Romain", "92130", "6 squares louis blé", "Issy-les-mx");
            adhtest3.Id = 28;
            club.AjouterClubAdh(adhtest);
            club.AjouterClubAdh(adhtest3);
            club.AjouterClubAdh(adhtest2);
            Assert.Equal(2, club.adherents.Count);
        }

    }
}
