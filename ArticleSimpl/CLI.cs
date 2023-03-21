using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleSimpl
{
    internal class CLI
    {
        /// <summary>
        /// Contient les méthodes pour que l'utilisateur puisse interragir avec la classe magasin
        /// </summary>
        public Magasin Magasin { get; set; }

        public CLI() 
        {
            this.Magasin = new Magasin();
        }

        /// <summary>
        /// Demande a l'utilisateur les informations pour créer un article
        /// </summary>
        /// <returns>un article</returns>
        public Article creerArticle()
        {
            Article article = new Article();
            Console.WriteLine("reference de l'article (int) : ");
            article.Reference = int.Parse(Console.ReadLine());
            Console.WriteLine("nom de l'article (string) : ");
            article.Nom = Console.ReadLine();
            Console.WriteLine("stock de l'article (int) : ");
            article.Stock = int.Parse(Console.ReadLine());
            Console.WriteLine("Prix de l'article (int) : ");
            article.Prix = int.Parse(Console.ReadLine());

            return article;
            
        }


        /// <summary>
        /// Demande à l'utilisateur une valeur int pour rechercher une clé dans la collection Articles 
        /// </summary>
        /// <returns>Article</returns>
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

        /// <summary>
        /// Demande à l'utilisateur une valeur int pour rechercher une clé 
        /// dans la collection Articles et la supprime dans la collection
        /// </summary>
        public void supprimerArticleParRef()
        {
            Console.WriteLine("Quelle référence voulez-vous supprimer (int) : ");
            Magasin.removeArticle(int.Parse(Console.ReadLine()));
        }

        /// <summary>
        /// Demande à l'utilisateur une valeur int pour rechercher une clé 
        /// dans la collection Articles et remplace la valeurs par un nouvelle.
        /// </summary>
        public void modifierArticleParRef()
        {
            Console.WriteLine("Quelle référence voulez-vous modifier (int) : ");
            Magasin.updateArticle(int.Parse(Console.ReadLine()), this.creerArticle());
                               
        }

        /// <summary>
        /// Demande à l'utilisateur une valeur string pour rechercher dans la collecion l'article correspondant
        /// </summary>
        public void rechercherArticleParNom()
        {
            Console.WriteLine("Quel article chercher vous ? ");
            Console.WriteLine(Magasin.findByNom(Console.ReadLine()));
        }

        /// <summary>
        /// Demande à l'utilisateur un prixMin et un prixMax pou recherche dans la collection
        /// tout les articles dans cette intervale de prix
        /// </summary>
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

        /// <summary>
        /// Affiche tout les articles dans la collection Articles
        /// </summary>
        public void afficherToutArticles()
        {
            foreach(KeyValuePair<int, Article> kvp in Magasin.Articles) 
            {
                Console.WriteLine(kvp.Value);
            }
        }
    }
}
