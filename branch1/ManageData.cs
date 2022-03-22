using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hector
{
    internal class ManageData
    {

        private List<Marque> listMarque;
        private List<Article> listArticle;
        private List<Famille> listFamille;
        private List<SousFamille> listSousFamille; 

        public List<Marque> getMarques()
        {
            return listMarque;
        }
        public List<Article> getArticles()
        {
            return listArticle;
        }
        public List<Famille> getFamille()
        {
            return listFamille;
        }
        public List<SousFamille> getSousFamille()
        {
            return listSousFamille;
        }
        public void createClass(string name)
        {
            listMarque = new List<Marque>();    
            listArticle = new List<Article>();
            listFamille = new List<Famille>();
            listSousFamille = new List<SousFamille>();

            StreamReader reader = new StreamReader(name);
            string data = reader.ReadLine();
            string[] read;
            char[] seperators = { ';' };

            while ((data = reader.ReadLine()) != null)
            {
                read = data.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

               /* if(listMarque != null)
                {
                    for (int i = 0; i < listMarque.Count; i++)
                    {
                        if(read[2].ToString() == listMarque[i].getNom())
                        {

                        }
                    }
                }*/
                
                Article MonArticle = new Article();
                Marque MaMarque = new Marque();
                Famille MaFamille = new Famille();
                SousFamille MaSousFamille = new SousFamille();

                MonArticle.setDescription(read[0].ToString());
                MonArticle.setReference(read[1].ToString());

                MonArticle.setPrix(float.Parse(read[5]));

                bool cmptMarque = false;
                bool cmptFamille = false;
                bool cmptSousFamille = false;

                if (listMarque != null)
                {
                    for (int i = 0; i < listMarque.Count(); i++)
                    {
                        if (read[2].ToString() == listMarque[i].getNom())
                        {
                            cmptMarque = true;
                        }
                    }
                    if (cmptMarque == false)
                    {

                        MaMarque.setNom(read[2].ToString());
                        MonArticle.setMarque(MaMarque);
                    }
                    else
                    {
                        for (int i = 0; i < listMarque.Count(); i++)
                        {
                            if (read[2].ToString() == listMarque[i].getNom())
                            {
                                MonArticle.setMarque(listMarque[i]);
                            }
                        }
                    }
                }
                else
                {
                    MaMarque.setNom(read[2].ToString());
                    MonArticle.setMarque(MaMarque);
                }


       
                if (listSousFamille != null)
                {
                    for (int i = 0; i < listSousFamille.Count(); i++)
                    {
                        if (read[4].ToString() == listSousFamille[i].getNom())
                        {
                            cmptSousFamille = true;
                        }
                    }

                    if (cmptSousFamille == false)
                    {
                        MaSousFamille.setNom(read[4].ToString());
                        MonArticle.setSousFamille(MaSousFamille);
                    }
                    else
                    {
                        for (int i = 0; i < listSousFamille.Count(); i++)
                        {
                            if (read[4].ToString() == listSousFamille[i].getNom())
                            {
                                MonArticle.setSousFamille(listSousFamille[i]);
                            }
                        }
                    }
                }
                else
                {
                    MaSousFamille.setNom(read[4].ToString());
                    MonArticle.setSousFamille(MaSousFamille);
                }
       
                if (listFamille != null)
                {
                    for (int i = 0; i < listFamille.Count(); i++)
                    {
                        if (read[3].ToString() == listFamille[i].getNom())
                        {
                            cmptFamille = true;
                        }
                    }
                    if (cmptFamille == false)
                    {
                        MaFamille.setNom(read[3].ToString());
                        MaSousFamille.setFamille(MaFamille);
                        MonArticle.setSousFamille(MaSousFamille);
                    }
                    else
                    {
                        for (int i = 0; i < listFamille.Count(); i++)
                        {
                            if (read[3].ToString() == listFamille[i].getNom())
                            {
                                MaSousFamille.setFamille(listFamille[i]);
                                MonArticle.setSousFamille(MaSousFamille);
                            }
                        }
                    }
                }
                else
                {
                    MaFamille.setNom(read[3].ToString());
                    MaSousFamille.setFamille(MaFamille);
                    MonArticle.setSousFamille(MaSousFamille);
                }
                if (MaFamille.getNom() != null)
                {
                    listFamille.Add(MaFamille);

                }
                if (MaSousFamille.getNom() != null)
                {
                    listSousFamille.Add(MaSousFamille);

                }
                if (MaMarque.getNom() != null)
                {
                    listMarque.Add(MaMarque);

                }
                listArticle.Add(MonArticle);

            }
            reader.Close();
        }
    }
}


