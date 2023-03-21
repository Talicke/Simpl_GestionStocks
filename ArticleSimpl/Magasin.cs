using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ArticleSimpl
{
    /// <summary>
    /// Contient une collection, contenant tout les articles. 
    /// </summary>
    internal class Magasin
    {
        public Dictionary<int, Article> Articles { get; set; }

        public Magasin() 
        {
            this.Articles = new Dictionary<int, Article>();

        }

        /// <summary>
        /// Trouve un articles avec sa reférence dans la collection
        /// </summary>
        /// <param name="refArticle"></param>
        /// <returns>bool</returns>
        public bool findByRef(int refArticle)
        {
            if (Articles.ContainsKey(refArticle))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Trouve le premier article dans la collection correspondant au nom en parametre
        /// </summary>
        /// <param name="nomArticle"></param>
        /// <returns>Article</returns>
        public Article findByNom(string nomArticle)
        {
            Article article = new Article();
            foreach(KeyValuePair<int, Article> kvp in Articles)
            {
                if(kvp.Value.Nom == nomArticle)
                {
                   article = kvp.Value;
                }
            }
            return article;
        }

        /// <summary>
        /// Ajouter un article à la collection
        /// </summary>
        /// <param name="article"></param>
        public void addArticle(Article article)
        {
            if(!this.findByRef(article.Reference))
            {
                this.Articles.Add(article.Reference, article);
            }
            else
            {
                Console.WriteLine(" ************************ Cet article est déja en stock! ************************ ");
            }
        }

        /// <summary>
        /// Supprime un article de la collection
        /// </summary>
        /// <param name="articleRef"></param>
        public void removeArticle(int articleRef)
        {
            if(this.findByRef(articleRef))
            {
                this.Articles.Remove(articleRef);
            }
            else
            {
                Console.WriteLine("************************ Cet article n'est pas dans nos stocks ************************");
            }
        }

        /// <summary>
        /// trouve un article dans la collection avec la référence et le replace par un nouveau 
        /// </summary>
        /// <param name="articleRef"></param>
        /// <param name="newArticle"></param>
        public void updateArticle(int articleRef, Article newArticle)
        {
            if (this.findByRef(articleRef)){
                this.Articles[articleRef] = newArticle;
            }
        }

        /// <summary>
        /// trouve tout les articles dans la collection compris entre prixMin et prixMax
        /// </summary>
        /// <param name="prixMin"></param>
        /// <param name="prixMax"></param>
        /// <returns>List d'articles</returns>
        public List<Article> findByPrice(int prixMin, int prixMax)
        {
            List<Article> listArticle = new List<Article>();
            foreach(KeyValuePair <int, Article> kvp in Articles)
            {
                if(kvp.Value.Prix > prixMin && kvp.Value.Prix < prixMax)
                {
                    listArticle.Add(kvp.Value);
                }
            }
            return listArticle;
        }

        /// <summary>
        /// Permet de créer un nombre n d'article fictif
        /// </summary>
        /// <param name="nbArticle"></param>
        public void CreerArticleFictif(int nbArticle)
        {
            
           
            for (int i = 1; i <= nbArticle; i++)
            {
                Article article = new Article();
                article.Reference = i;
                article.Nom = $"Article {i}";
                article.Stock = i;
                article.Prix = i;
                Articles.Add(article.Reference, article);
            }
        }
    }
}
