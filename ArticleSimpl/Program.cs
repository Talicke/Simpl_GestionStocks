// See https://aka.ms/new-console-template for more information

using ArticleSimpl;



int input = -1;
CLI cli = new CLI();
cli.Magasin.CreerArticleFictif(10);


    while(input != 0)
    {
    Console.WriteLine("0) Quitter \n1) Recherche un article par référence \n2) Ajouter un article au magasin \n3) Supprimer un article par référence \n" +
        "4) Modifier un Article par référence \n5) Recherche un article par nom \n6) Rechercher un article par interval \n7) Afficher tout les articles");
    Console.WriteLine("Que souhaitez vous faire : ");
    input = int.Parse(Console.ReadLine());
    Console.Clear();
        switch (input)
        {
            case 1:                    
            Console.WriteLine(cli.rechercherArticleParRef());
            break;

            case 2:
                            
            cli.Magasin.addArticle(cli.creerArticle());

            break;

            case 3:
            cli.supprimerArticleParRef();
            break;

            case 4:
            cli.modifierArticleParRef();
            break;

            case 5:
            cli.rechercherArticleParNom();
            break;

            case 6:
            cli.rechercherArticleParInterval();
            break;

            case 7:
            cli.afficherToutArticles();
            break;

            default:
            Console.WriteLine("Désolé je n'ai pas compris votre requête ! ");
            break;
        }
    }

