using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hector
{
    internal class Famille
    {
        private static int count = 0;

        private int Reference;

        private string Nom;

        public Famille()
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
