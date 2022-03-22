using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hector
{
    internal class SousFamille
    {
        private static int count = 0;

        private int Reference;

        private Famille LaFamille;

        private string Nom;

        public SousFamille()
        {
            count++;
            Reference = count;
        }

        public void setReference(int Reference)
        {
            this.Reference = Reference;
        }

        public int getReference()
        {
            return this.Reference;
        }

        public void setFamille(Famille LaFamille)
        {
            this.LaFamille = LaFamille;
        }

        public Famille getFamille()
        {
            return this.LaFamille;
        }

        public void setNom(string Nom)
        {
            this.Nom = Nom;
        }

        public string getNom()
        {
            return this.Nom;
        }
    }
}
