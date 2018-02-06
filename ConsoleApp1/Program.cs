using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Objects;
using System.Data.Odbc;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{

    class Program
    {
        private static void GetProducts()
        {
            using (FarmadContainer farmad = new FarmadContainer())
            {
               
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            using (var farmad = new FarmadContainer())
            {
                var qryExpSis1 = from sis1 in farmad.FTBKLANTSIS
                                 where sis1.KS_KLANTNUMMER != null
                                 select new
                                 {
                                     KLANTID = sis1.KS_ID == null ? 0 : sis1.KS_ID,
                                     KLANTNR = sis1.KS_KLANTNUMMER == null ? 0 : sis1.KS_KLANTNUMMER
                                 };


                var qryExpSis2 = from sis2 in qryExpSis1
                                 join KlantSis in farmad.FTBKLANTSIS
                                     on new { KLANTID = sis2.KLANTID, KLANTNR = sis2.KLANTNR }
                                     equals new { KLANTID = KlantSis.KS_ID, KLANTNR = KlantSis.KS_KLANTNUMMER } into j1
                                 from j in j1
                                 orderby j.KS_KLANTNUMMER
                                 select new
                                 {
                                     ID = j.KS_ID,
                                     NUMMER = j.KS_KLANTNUMMER,
                                     MUT = j.KS_MUT,
                                     CG1 = j.KS_CG1,
                                     CG2 = j.KS_CG2,
                                     CATEGORIE = j.KS_CATEGORIE,
                                     STAMNUMMER = j.KS_STAMNUMMER,
                                     SIS_GELEZEN = j.KS_SIS_GELEZEN,
                                     NR_SIS = j.KS_NR_SIS,
                                     VERSIE_VERZ = j.KS_VERSIE_VERZ,
                                     CERTIFICAAT = j.KS_CERTIFICAAT,
                                     SISGELDIGHEID = j.KS_SISGELDIGHEID,
                                     SISLEZERID = j.KS_SISLEZERID,
                                     GESLACHT = j.KS_GESLACHT,
                                     GEBOORTEDATUM = j.KS_GEBOORTEDATUM,
                                     FAMILIENAAM = j.KS_FAMILIENAAM,
                                     VOORNAAM = j.KS_VOORNAAM,
                                     INSZ = "",
                                     VOL_MUT = j.KS_MUT + " " + j.KS_VOL_MUT,
                                     CG1CG2 = j.KS_CG1 + " " + j.KS_CG2,
                                     VOLNAAM = j.KS_FAMILIENAAM + " " + j.KS_VOORNAAM,
                                     ATTEST = j.KS_ATTEST,
                                     LEEFTJD = j.KS_LEEFTIJD
                                 };

                var klantTelNrs = from qrysis2 in qryExpSis2
                                  join t in farmad.FTBTELNUMMERS
                                      on qrysis2.NUMMER equals t.T_OBJECTNUMMER into j1
                                  from j in j1
                                  where (j.T_OBJECT_TYPE == "K" && j.T_TELEFOONNUMMER != "")
                                  group j by j.T_OBJECTNUMMER into g1
                                  from g in g1
                                  select new
                                  {
                                      T_OBJECTNUMMER = g.T_OBJECTNUMMER,
                                      T_TELNR = g.T_TELEFOONNUMMER
                                  };

                foreach (var Ligne in klantTelNrs)
                {
                    Console.WriteLine(Ligne.ToString());
                }

            }
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine("## Terminé ##");
            Console.Read();




        }
    }
}
