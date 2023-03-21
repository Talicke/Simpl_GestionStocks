using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleSimpl
{
    internal class CLI
    {
        public Magasin Magasin { get; set; }

        public CLI() 
        {
            this.Magasin = new Magasin();
        }

        public Article creerArticle()
        {
            Article article = new Article();
            Console.WriteLine("reference de l'article (int) : ");
            article.Reference = int.Parse(Console.ReadLine());
            Console.WriteLine("nom de l'article (string) : ");
            article.Nom = Console.ReadLine();
            Console.WriteLine("stock de l'article (int) : ");
            article.Stock = int.Parse(Console.ReadLine());
            Console.WriteLine("Prix de l'article (float) : ");
            article.Prix = int.Parse(Console.ReadLine());

            return article;
            
        }

        public Article rechercherArticleParRef()
        {
            Article article = new Article();
            Console.Write("Quel Article chercher vous (reference int)? :");
            int inputRefArticle = int.Parse(Console.ReadLine());
            if (this.Magasin.findByRef(inputRefArticle))
            {
                article = Magasin.Articles[inputRefArticle];
            }
            return article;
        }

        public void supprimerArticleParRef()
        {
            Console.WriteLine("Quelle référence voulez-vous supprimer (int) : ");
            Magasin.removeArticle(int.Parse(Console.ReadLine()));
        }

        public void modifierArticleParRef()
        {
            Console.WriteLine("Quelle référence voulez-vous supprimer (int) : ");
            Magasin.updateArticle(int.Parse(Console.ReadLine()), this.creerArticle());
                               
        }

        public void rechercherArticleParNom()
        {
            Console.WriteLine("Quel article chercher vous ? ");
            Console.WriteLine(Magasin.findByNom(Console.ReadLine()));
        }

        public void rechercherArticleParInterval()
        {
            Console.WriteLine("Entrez un prix min (int)");
            int prixMin = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez un prix max (int)");
            int prixMax = int.Parse(Console.ReadLine());
            foreach(Article article in Magasin.findByPrice(prixMin, prixMax))
            {
                Console.WriteLine(article);
            };
        }
        public void afficherToutArticles()
        {
            foreach(KeyValuePair<int, Article> kvp in Magasin.Articles) 
            {
                Console.WriteLine(kvp.Value);
            }
        }
    }
}
