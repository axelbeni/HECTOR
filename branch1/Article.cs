using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hector
{
    internal class Article
    {
        private string Reference;//8 caractere max

        private string Description;

        private SousFamille LaSousFamille;

        private float Prix;

        private Marque LaMarque;

        private int Quantite;

        public void setReference(string Reference)
        {
            this.Reference = Reference;
        }

        public string getReference()
        {
            return this.Reference;
        }

        public void setDescription(string Description)
        {
            this.Description = Description;
        }

        public string getDescription()
        {
            return this.Description;
        }

        public void setSousFamille(SousFamille LaSousFamille)
        {
            this.LaSousFamille = LaSousFamille;
        }

        public SousFamille getSousFamille()
        {
            return this.LaSousFamille;
        }

        public void setMarque(Marque LaMarque)
        {
            this.LaMarque = LaMarque;
        }

        public Marque getMarque()
        {
            return this.LaMarque;
        }

        public void setPrix(float Prix)
        {
            this.Prix = Prix;
        }

        public float getPrix()
        {
            return this.Prix;
        }

        public void setQuantite(int Quantite)
        {
            this.Quantite = Quantite;
        }

        public int getQuantite()
        {
            return this.Quantite;
        }
    }
}
