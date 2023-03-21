using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ArticleSimpl
{
    internal class Magasin
    {
        public Dictionary<int, Article> Articles { get; set; }

        public Magasin() 
        {
            this.Articles = new Dictionary<int, Article>();

        }

        public bool findByRef(int refArticle)
        {
            if (Articles.ContainsKey(refArticle))
            {
                return true;
            }
            return false;
        }

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

        public void updateArticle(int articleRef, Article newArticle)
        {
            if (this.findByRef(articleRef)){
                this.Articles[articleRef] = newArticle;
            }
        }

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
