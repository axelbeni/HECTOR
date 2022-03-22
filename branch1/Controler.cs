using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Sql;
namespace Hector
{
    internal class Controler
    {
        SQLiteConnection Connect;

        public object SQLCommandLine { get; private set; }

        public SQLiteConnection Connexion()
        {
            Connect = new SQLiteConnection("Data Source=Hector.SQLite;Version=3");
            try
            {
                Connect.Open();
            }
            catch (Exception ex)
            {

            }
            return Connect;
        }

        public void ExecuteRead(string txtQuery)
        {
            Connect = Connexion(); 
            SQLiteCommand Cmd = Connect.CreateCommand();
            Cmd = Connect.CreateCommand();
            Cmd.CommandText = txtQuery;
            Cmd.ExecuteReader();
            Connect.Close();
        }

        private void ExecuteQuery(string txtQuery)
        {
            Connect = Connexion();

            SQLiteCommand Cmd = Connect.CreateCommand();

            Cmd.CommandText = txtQuery;

            Cmd.ExecuteNonQuery();

            Connect.Close();
        }

        public void insertData(List<Article> Articles, List<Marque> Marques, List<Famille> Familles, List<SousFamille> SousFamilles)
        {
            for (int i = 0; i < Marques.Count; i++)
            {
                string QueryMarques = "INSERT INTO Marques (RefMarque, Nom) VALUES ('" + Marques[i].getReference() +"','" + Marques[i].getNom()+"')";
                
                try
                {
                    ExecuteQuery(QueryMarques);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            for (int i = 0; i < Familles.Count; i++)
            {
                string QueryFamilles = "INSERT INTO Familles (RefFamille, Nom) VALUES ('" + Familles[i].getReference() + "','" + Familles[i].getNom() + "')";
                try
                {
                    ExecuteQuery(QueryFamilles);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            for (int i = 0; i < SousFamilles.Count; i++)
            {
                string QuerySousFamilles = "INSERT INTO SousFamilles (RefSousFamille, RefFamille, Nom) VALUES ('" + SousFamilles[i].getReference() + "','" + SousFamilles[i].getFamille().getReference() + "','" + SousFamilles[i].getNom() + "')";
                try
                {
                    ExecuteQuery(QuerySousFamilles);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            for (int i = 0; i < Articles.Count; i++)
            {
                string QueryArticles = "INSERT INTO Articles (RefArticle, Description, RefSousFamille, RefMarque , PrixHT, Quantite) VALUES ('"+Articles[i].getReference()+"','"+ Articles[i].getDescription() + "','"+ Articles[i].getSousFamille().getReference()+"','"+ Articles[i].getMarque().getReference()+"','"+ Articles[i].getPrix()+"','"+0+"') ";
                try
                {
                    ExecuteQuery(QueryArticles);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }         
         }

        public void viderTables()
        {
            string QueryArticles = "DELETE FROM 'Articles'";
            string QueryMarques = "DELETE FROM 'Marques'";
            string QuerySousFamilles = "DELETE FROM 'SousFamilles'";
            string QueryFamilles = "DELETE FROM 'Familles'";
            try
            {
                ExecuteQuery(QueryArticles);
                ExecuteQuery(QueryMarques);
                ExecuteQuery(QueryFamilles);
                ExecuteQuery(QuerySousFamilles);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}