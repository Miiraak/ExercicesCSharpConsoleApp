namespace Exercice
{
    internal class Program
    {
        static void Main(string[] args) //  <--- Vous pouvez fermer le code à ce niveau / Close Here
        {
            bool continuer = true;

            while (continuer)
            {
                try
                {
                    AfficherMenu();
                    int choix  = Convert.ToInt16(Console.ReadLine());

                    switch (choix)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("");
                            AfficherMenuVariables();
                            int choix2 = Convert.ToInt16(Console.ReadLine());

                            switch (choix2)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Var1();
                                    break; 
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Var2();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Var3();
                                    break; 
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Var4();
                                    break; 
                                case 5: 
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("Choix invalide. Veuillez entrer un numéro valide.");
                                    break;
                            }
                            break;

                        case 2:
                            Console.WriteLine("");
                            AfficherMenuTypesScales();
                            int choix3 = Convert.ToInt16(Console.ReadLine());

                            switch (choix3)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    TS1();
                                    break; 
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    TS2();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    TS3();
                                    break; 
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    TS4();
                                    break; 
                                case 5:
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("Choix invalide. Veuillez entrer un numéro valide.");
                                    break;
                            }
                            break;

                        case 3:
                            Console.WriteLine("");
                            AfficherMenuOperateurs();
                            int choix4 = Convert.ToInt16(Console.ReadLine());

                            switch (choix4)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Opr1();
                                    break; 
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Opr2();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Opr3();
                                    break; 
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Opr4();
                                    break;
                                case 5:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Opr5();
                                    break;
                                case 6:
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("Choix invalide. Veuillez entrer un numéro valide.");
                                    break;
                            }
                            break;

                        case 4:
                            Console.WriteLine("");
                            AfficherMenuConditions();
                            int choix5 = Convert.ToInt16(Console.ReadLine());

                            switch (choix5)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Cond1();
                                    break; 
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Cond2();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Cond3();
                                    break; 
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Cond4();
                                    break; 
                                case 5:
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("Choix invalide. Veuillez entrer un numéro valide.");
                                    break;
                            }
                            break; 

                        case 5:
                            Console.WriteLine("");
                            AfficherMenuBoucles();
                            int choix6 = Convert.ToInt16(Console.ReadLine());

                            switch (choix6)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Bouc1();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Bouc2();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Bouc3();
                                    break; 
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Bouc4();
                                    break; 
                                case 5:
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("Choix invalide. Veuillez entrer un numéro valide.");
                                    break;
                            }
                            break;

                        case 6:
                            Console.WriteLine("");
                            AfficherMenuFonctions();
                            int choix7 = Convert.ToInt16(Console.ReadLine());

                            switch (choix7)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Fonc1();
                                    break; 
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Fonc2();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Fonc3();
                                    break; 
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Fonc4();
                                    break; 
                                case 5:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Fonc5();
                                    break; 
                                case 6:
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("Choix invalide. Veuillez entrer un numéro valide.");
                                    break;
                            }
                            break;

                        case 7:
                            Console.WriteLine("");
                            AfficherMenuTableaux();
                            int choix8 = Convert.ToInt16(Console.ReadLine());

                            switch (choix8)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Tab1();
                                    break; 
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Tab2();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Tab3();
                                    break; 
                                case 4:
                                    //Console.Clear();
                                    Console.WriteLine("");
                                    Tab4();
                                    break; 
                                case 5:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Tab5();
                                    break; 
                                case 6:
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("Choix invalide. Veuillez entrer un numéro valide.");
                                    break;
                            }
                            break;

                        case 8:
                            Console.WriteLine("");
                            AfficherMenuListes();
                            int choix9 = Convert.ToInt16(Console.ReadLine());

                            switch (choix9)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Liste1();
                                    break; 
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Liste2();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Liste3();
                                    break; 
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Liste4();
                                    break;
                                case 5:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Liste5();
                                    break; 
                                case 6:
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("Choix invalide. Veuillez entrer un numéro valide.");
                                    break;
                            }
                            break; 
                        
                        case 9:
                            Console.Clear();
                            Console.WriteLine("\nZONE DE TEST\n");
                            break;

                        case 10:
                            continuer = false;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Au revoir !");
                            System.Environment.Exit(0);
                            break;
                                
                        default:
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Choix invalide. Veuillez entrer un numéro valide.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Erreur : Veuillez entrer un nombre !");
                }
                catch (OverflowException)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Erreur : Votre nombre est trop grand !");
                }
            }
        }

        static void AfficherMenu() //  <--- Vous pouvez fermer le code à ce niveau 
        {
            Console.WriteLine("");
            Console.WriteLine("Menu :");
            Console.WriteLine("1. Variables");
            Console.WriteLine("2. Types Scalaires");
            Console.WriteLine("3. Opérateurs");
            Console.WriteLine("4. Conditions");
            Console.WriteLine("5. Boucles");
            Console.WriteLine("6. Fonctions");
            Console.WriteLine("7. Tableau");
            Console.WriteLine("8. Listes");
            Console.WriteLine("9. ZONE TEST");
            Console.WriteLine("10. Quitter");
            Console.Write("Entrez votre choix : ");
        }

        static void AfficherMenuVariables() //  <--- Vous pouvez fermer le code à ce niveau 
        {
            Console.WriteLine("");
            Console.WriteLine("Les Variables :");
            Console.WriteLine("1. Nom et âge");
            Console.WriteLine("2. Convertire une température");
            Console.WriteLine("3. Calcule d'aire");
            Console.WriteLine("4. Calcules de base");
            Console.WriteLine("5. Quitter");
            Console.Write("Entrez votre choix : ");
        }

        static void AfficherMenuTypesScales() //  <--- Vous pouvez fermer le code à ce niveau 
        {
            Console.WriteLine("");
            Console.WriteLine("Les Types Scalaires :");
            Console.WriteLine("1. Nom et âge");
            Console.WriteLine("2. Calcule d'aire");
            Console.WriteLine("3. Convertire une température");
            Console.WriteLine("4. Verification parité");
            Console.WriteLine("5. Quitter");
            Console.Write("Entrez votre choix : ");
        }

        static void AfficherMenuOperateurs() //  <--- Vous pouvez fermer le code à ce niveau 
        {
            Console.WriteLine("");
            Console.WriteLine("Les Opérateurs :");
            Console.WriteLine("1. Calcules de base");
            Console.WriteLine("2. Opérations logiques");
            Console.WriteLine("3. Verification parité");
            Console.WriteLine("4. Calcule Moyenne");
            Console.WriteLine("5. Echange de contenu");
            Console.WriteLine("6. Quitter");
            Console.Write("Entrez votre choix : ");
        }

        static void AfficherMenuConditions() //  <--- Vous pouvez fermer le code à ce niveau 
        {
            Console.WriteLine("");
            Console.WriteLine("Les Conditions :");
            Console.WriteLine("1. Vérification pos/neg/nul");
            Console.WriteLine("2. Vérification type caractère");
            Console.WriteLine("3. Attribution de note");
            Console.WriteLine("4. Vérificaton jours par mois");
            Console.WriteLine("5. Quitter");
            Console.Write("Entrez votre choix : ");
        }

        static void AfficherMenuBoucles() //  <--- Vous pouvez fermer le code à ce niveau 
        {
            Console.WriteLine("");
            Console.WriteLine("Les Boucles :");
            Console.WriteLine("1. Afficher les nombres de 1 à 10");
            Console.WriteLine("2. Nombres pairs jusqu'a x");
            Console.WriteLine("3. Ecrire input à l'envers");
            Console.WriteLine("4. Somme entier de 1 à X");
            Console.WriteLine("5. Quitter");
            Console.Write("Entrez votre choix : ");
        }

        static void AfficherMenuFonctions() //  <--- Vous pouvez fermer le code à ce niveau 
        {
            Console.WriteLine("");
            Console.WriteLine("Les Fonctions :");
            Console.WriteLine("1. Fonction 'CalculerCarre'");
            Console.WriteLine("2. Fonction 'EstPair'");
            Console.WriteLine("3. Fonction 'CalculerMoyenne'");
            Console.WriteLine("4. Fonction 'TrouverMaximum'");
            Console.WriteLine("5. Fonction 'ConvertirEnMajuscules'");
            Console.WriteLine("6. Quitter");
            Console.Write("Entrez votre choix : ");
        }

        static void AfficherMenuTableaux() //  <--- Vous pouvez fermer le code à ce niveau 
        {
            Console.WriteLine("");
            Console.WriteLine("Les Tableaux :");
            Console.WriteLine("1. Cinq premiers nombres pairs");
            Console.WriteLine("2. Les noms de trois fruits");
            Console.WriteLine("3. Le nombre est présent");
            Console.WriteLine("4. Modification d'un tableau");
            Console.WriteLine("5. Stockage dans un tableau");
            Console.WriteLine("6. Quitter");
            Console.Write("Entrez votre choix : ");
        }

        static void AfficherMenuListes() //  <--- Vous pouvez fermer le code à ce niveau 
        {
            Console.WriteLine("");
            Console.WriteLine("Les Listes :");
            Console.WriteLine("1. Ajout dans une liste");
            Console.WriteLine("2. Modification d'une Liste");
            Console.WriteLine("3. Vérification et ajout dans une liste");
            Console.WriteLine("4. Affichage elements récurrent de liste");
            Console.WriteLine("5. Suppresion elements liste");
            Console.WriteLine("6. Quitter");
            Console.Write("Entrez votre choix : ");
        }

// ______________________________________________________________________//
//                                                                       //
//                         ESPACE EXERCICES                              //
// ______________________________________________________________________//

    // Variables
        static void Var1()
        {
            Console.WriteLine("Exercice 1 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur son nom et son âge
            Puis affiche un message de salutation personnalisé avec ces informations.
            */
            // Entrez vos lignes de codes ci-dessous //

            
        }        
        static void Var2()
        {
            Console.WriteLine("Exercice 2 lancé !");
            Console.WriteLine("");
            /*
             Écrivez un programme en C# qui convertit une température en degrés Celsius en une température équivalente en degrés Fahrenheit. 
             Demandez à l'utilisateur d'entrer une température en degrés Celsius.
             Puis affichez la température équivalente en degrés Fahrenheit.
             Formule de conversion : F = C * 9/5 + 32.
            */
            // Entrez vos lignes de codes ci-dessous //


        }
        static void Var3()
        {
            Console.WriteLine("Exercice 3 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui calcule l'aire d'un rectangle.
            Demandez à l'utilisateur d'entrer la longueur et la largeur du rectangle. 
            Affichez ensuite l'aire calculée.
            */
            // Entrez vos lignes de codes ci-dessous //


        }
        static void Var4()
        {
            Console.WriteLine("Exercice 4 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur de saisir deux nombres entiers, puis effectue les opérations suivantes :
            Calcule la somme des deux nombres.
            Calcule la différence du premier nombre moins le deuxième nombre.
            Calcule le produit des deux nombres.
            Calcule le quotient entier du premier nombre divisé par le deuxième nombre.
            Affichez les résultats de chaque opération.
            */
            // Entrez vos lignes de codes ci-dessous //


        }

// ______________________________________________________________________

    // Types Scalaire
        static void TS1()
        {
            Console.WriteLine("Exercice 1 lancé !");     
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur son nom et son âge
            Puis affiche un message de salutation personnalisé avec ces informations.
            */
            // Entrez vos lignes de codes ci-dessous //


        }
        static void TS2()
        {
            Console.WriteLine("Exercice 2 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui calcule l'aire d'un rectangle.
            Demandez à l'utilisateur d'entrer la longueur et la largeur du rectangle. 
            Affichez ensuite l'aire calculée.
            */
            // Entrez vos lignes de codes ci-dessous //


        }
        static void TS3()
        {
            Console.WriteLine("Exercice 3 lancé !");
            Console.WriteLine("");
            /*
             Écrivez un programme en C# qui convertit une température en degrés Celsius en une température équivalente en degrés Fahrenheit. 
             Demandez à l'utilisateur d'entrer une température en degrés Celsius.
             Puis affichez la température équivalente en degrés Fahrenheit.
             Formule de conversion : F = C * 9/5 + 32.
            */
            // Entrez vos lignes de codes ci-dessous //


        }
        static void TS4() 
        {
            Console.WriteLine("Exercice 4 lancé !");
            Console.WriteLine("");
            /* 
            Écrivez un programme en C# qui demande à l'utilisateur d'entrer un nombre entier et vérifie s'il est pair ou impair. 
            Utilisez une variable de type int pour stocker le nombre et une condition if pour vérifier si le nombre est pair ou impair. 
            Affichez ensuite un message approprié à l'utilisateur.
            */
            // Entrez vos lignes de codes ci-dessous //


        }

// ______________________________________________________________________

    // Opérateurs
        static void Opr1()
        {
            Console.WriteLine("Exercice 1 lancé !");      
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur d'entrer deux nombres entiers.
            Affichez leur somme, leur différence, leur produit, leur quotient et leur reste de la division entière.
            */
            // Entrez vos lignes de codes ci-dessous //


        }
        static void Opr2()
        {
            Console.WriteLine("Exercice 2 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur d'entrer deux valeurs booléennes (true ou false)
            Affichez le résultat des opérations logiques ET, OU et NON sur ces valeurs.         
            */
            // Entrez vos lignes de codes ci-dessous //


        }        
        static void Opr3() // Même exercice que TS4
        {
            Console.WriteLine("Exercice 3 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur d'entrer un nombre entier.
            Et détermine s'il est pair ou impair. Affichez le résultat.
            */
            // Entrez vos lignes de codes ci-dessous //


        }
        static void Opr4()
        {
            Console.WriteLine("Exercice 4 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur d'entrer trois notes (sur 6) et calcule la moyenne de ces notes.   
            Affichez le résultat avec deux décimales.
            */
            // Entrez vos lignes de codes ci-dessous //

            bool running = true;
            double note1 = 0;
            double note2 = 0;
            double note3 = 0;

            while(running)
            {
                SelectionNote();

                if(note1 <= 6 && note2 <= 6 && note3 <= 6)
                {
                    double total = Math.Round((note1 + note2 + note3) / 3, 2);
                    Console.WriteLine($"La moyenne de vos notes {note1}, {note2} et {note3} est égal à : {total}");
                    running = false;
                }
                else Console.WriteLine("L'une de vos notes n'est pas sur 6");
            }

            void SelectionNote()
            {
                    Console.WriteLine("Veuillez entrer la première note :");
                    note1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Veuillez entrer la seconde note :");
                    note2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Veuillez entrer la dernière note :");
                    note3 = Convert.ToDouble(Console.ReadLine());
            }

        }
        static void Opr5()
        {
            Console.WriteLine("Exercice 5 lancé !");
            Console.WriteLine("");
            // Entrez vos lignes de ci-dessous //

            /*
            Écrivez un programme en C# qui demande à l'utilisateur d'entrer deux valeurs (A et B).
            Echangez leur contenu sans utiliser de variable supplémentaire.
            */

            Console.WriteLine("Veuillez entrer un nombre :");
            int nbr1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Veuillez entrer un seconde nombre :");
            int nbr2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"Avant inversion : A = {nbr1} & B = {nbr2}");
            // Utilisation d'une liste...? non y a forcement plus simple
            // Utilisation tuples
            (nbr1, nbr2) = (nbr2, nbr1);

            Console.WriteLine($"Après inversion : A = {nbr1} & B = {nbr2}");
        }

// ______________________________________________________________________


    // Conditions
        static void Cond1()
        {
            Console.WriteLine("Exercice 1 lancé !");  
            Console.WriteLine("");
            // Entrez vos lignes de code ci-dessous // 

            /*
            Écrivez un programme en C# qui demande à l'utilisateur de saisir un nombre entier. 
            Vérifiez si le nombre est positif, négatif ou nul.
            Affichez un message approprié à l'utilisateur
            */    

            Console.WriteLine("Veuillez entrer un nombre entier, positif, null ou négatif");
            int entree = Convert.ToInt32(Console.ReadLine());

            if(entree < 0)
            {
                Console.WriteLine("Votre chiffre est négatif");
            }
            else if(entree > 0)
            {
                Console.WriteLine("Votre chiffre est positif");
            }
            else Console.WriteLine("Votre chiffre est nul");

        }
        static void Cond2()
        {
            Console.WriteLine("Exercice 2 lancé !");
            Console.WriteLine("");
            // Entrez vos lignes de code ci-dessous //

            /*
             Écrivez un programme en C# qui demande à l'utilisateur de saisir un caractère.
             Vérifiez si le caractère est une voyelle (a, e, i, o, u) ou une consonne. 
             Affichez un message approprié à l'utilisateur.
            */
            Console.WriteLine("Veuillez entrer une lettre de l'alphabet");
            char input = Convert.ToChar(Console.ReadLine());

        }        
        static void Cond3()
        {
            Console.WriteLine("Exercice 3 lancé !");
            Console.WriteLine("");
            // Entrez vos lignes de code ci-dessous //

            /*
            Écrivez un programme en C# qui demande à l'utilisateur de saisir une note sur 100. 
            Vérifiez la plage de la note et affichez le grade correspondant en utilisant la table de correspondance suivante :

                De 0 à 59 : Échec
                De 60 à 69 : D
                De 70 à 79 : C
                De 80 à 89 : B
                De 90 à 100 : A
            */
            Console.WriteLine("Veuillez entrer une note sur 100 :");
            byte input = Convert.ToByte(Console.ReadLine());

            if(input >= 0 && input <= 59)
            {
                Console.WriteLine($"Pour {input} points vous êtes en échec");
            }
            else if(input > 59 && input <= 69)
            {
                Console.WriteLine($"Pour {input} points, votre note est : D");
            }
            else if(input > 69 && input <= 79)
            {
                Console.WriteLine($"Pour {input} points, votre note est : C");
            }
            else if(input > 79 && input <= 89)
            {
                Console.WriteLine($"Pour {input} points, votre note est : B");
            }
            else Console.WriteLine($"Pour {input} points, votre note est : A");

        }
        static void Cond4()
        {
            Console.WriteLine("Exercice 4 lancé !");
            Console.WriteLine("");
            // Entrez vos lignes de code ci-dessous //

            /*
            Écrivez un programme en C# qui demande à l'utilisateur de saisir un mois (1 à 12).
            Utilisez une instruction switch pour afficher le nombre de jours dans ce mois.
            */

            Menu();
            int input = Convert.ToInt16(Console.ReadLine());

            switch(input)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Janvier comporte 31 jours.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Février comporte 28 jours.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Mars comporte 31 jours.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Avril comporte 30 jours.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 5:
                    Console.WriteLine("");
                    Console.WriteLine("Mai comporte 31 jours.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 6:
                    Console.WriteLine("");
                    Console.WriteLine("Juin comporte 30 jours.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 7:
                    Console.WriteLine("");
                    Console.WriteLine("Juillet comporte 31 jours.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 8:
                    Console.WriteLine("");
                    Console.WriteLine("Août comporte 31 jours.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 9:
                    Console.WriteLine("");
                    Console.WriteLine("Septembre comporte 30 jours.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 10:
                    Console.WriteLine("");
                    Console.WriteLine("Octobre comporte 31 jours.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 11:
                    Console.WriteLine("");
                    Console.WriteLine("Novembre comporte 30 jours.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 12:
                    Console.WriteLine("");
                    Console.WriteLine("Décembre comporte 31 jours.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Choix invalide. Veuillez entrer un numéro valide.");
                    break;
            }

            static void Menu()
            {
            Console.WriteLine("Menu :");
            Console.WriteLine("1. Janvier");
            Console.WriteLine("2. Février");
            Console.WriteLine("3. Mars");
            Console.WriteLine("4. Avril");
            Console.WriteLine("5. Mai");
            Console.WriteLine("6. Juin");
            Console.WriteLine("7. Juillet");
            Console.WriteLine("8. Août");
            Console.WriteLine("9. Septembre");
            Console.WriteLine("10. Octobre");
            Console.WriteLine("11. Novembre");
            Console.WriteLine("12. Décembre");
            Console.Write("Choississez votre mois : ");
            
            }

        }

// ______________________________________________________________________


    // Boucles
        static void Bouc1()
        {
            Console.WriteLine("Exercice 1 lancé !");    
            Console.WriteLine("");  
            /*
            Écrivez un programme en C# qui affiche les nombres de 1 à 10 à l'aide d'une boucle for. 
            Et ensuite avec une boucle while.
            */ 
            
            // Entrez vos lignes de code ci-dessous //   

            Menu();
            int choix = Convert.ToInt16(Console.ReadLine());

            switch(choix)
            {
                case 1:
                    Console.Clear();
                    for(byte i = 1; i < 11; i++)
                    {
                        Console.WriteLine(i);
                        Thread.Sleep(200);
                    }
                    Console.WriteLine("\nVoici les nombres de un à dix");
                    Thread.Sleep(500);
                    break;
                case 2:
                    Console.Clear();
                    byte i2 = 0;
                    while(i2 < 10)
                    {
                        i2++;
                        Console.WriteLine(i2);
                        Thread.Sleep(200);
                    }

                Console.WriteLine("\nVoici les nombres de un à dix.");
                Thread.Sleep(500);
                break;
            }

            static void Menu()
            {
                Console.WriteLine("Menu :");
                Console.WriteLine("1. La boucle for");
                Console.WriteLine("2. La boucle while");
                Console.Write("Choissisez votre boucle : ");
            }

        }
        static void Bouc2()
        {
            Console.WriteLine("Exercice 2 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur d'entrer un nombre entier positif. 
            Utilisez une boucle for pour afficher les nombres pairs de 0 jusqu'au nombre entré par l'utilisateur. 
            Et ensuite avec une boucle while.
            */

            // Entrez vos lignes de code ci-dessous //

            Menu();
            byte choix = Convert.ToByte(Console.ReadLine());
            Console.Clear();

            switch(choix)
            {
                case 1:
                    Console.WriteLine("Bonjour, veuillez entrer un nombre entier positif : ");
                    uint nombre = Convert.ToUInt32(Console.ReadLine());
                    byte pairTest = Convert.ToByte(nombre % 2);
                    uint nombreIteration;
                    uint ii = 0;
                    Console.Clear();
                    
                    if(pairTest == 1)
                    {
                        nombreIteration = (nombre - 1) / 2;
                    }
                    else nombreIteration = nombre / 2;

                    for(uint i = 0; i < nombreIteration; i++)
                    {
                        ii += 2;
                        Console.WriteLine(ii);
                    }
                Console.WriteLine($"\nVoici les nombres pairs de 0 à {nombre}");
                Thread.Sleep(2000);
                break;

                case 2:
                    Console.WriteLine("Bonjour, veuillez entrer un nombre entier positif : ");
                    uint nombre2 = Convert.ToUInt32(Console.ReadLine());
                    byte pairTest2 = Convert.ToByte(nombre2 % 2);
                    uint nombreIteration2;
                    uint ii2 = 0;
                    uint iii = 0;
                    Console.Clear();

                    if(pairTest2 == 1)
                    {
                        nombreIteration2 = (nombre2 - 1) / 2;
                    }
                    else nombreIteration2 = nombre2 / 2;

                    while(ii2 < nombreIteration2)
                    {

                        iii += 2;
                        Console.WriteLine(iii);
                    }
                Console.WriteLine($"\nVoici les nombres pairs de 0 à {nombre2}");
                Thread.Sleep(2000);
                break;
            }

            static void Menu()
            {
                Console.WriteLine("Menu :");
                Console.WriteLine("1. La boucle for");
                Console.WriteLine("2. La boucle while");
                Console.Write("Choissisez votre boucle : ");
            }

        }        
        static void Bouc3()
        {
            Console.WriteLine("Exercice 3 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur d'entrer un mot. Utilisez une boucle while pour afficher chaque lettre du mot à l'envers.
            */
            // Entrez vos lignes de code ci-dessous //

            string input = "";
            string reverse = "";

            Console.WriteLine("Veuillez entrer un mot :");
            input = Console.ReadLine();
            
            
            int lenght = input.Length - 1;

            while(lenght >= 0)
            {
                reverse += input[lenght];
                lenght--;
            }
            Console.WriteLine(reverse);

        }
        static void Bouc4()
        {
            Console.WriteLine("Exercice 4 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui calcule la somme des entiers de 1 à 100 en utilisant une boucle for. Affichez ensuite la somme calculée.
            */
            // Entrez vos lignes de code ci-dessous //

            int input;
            int result = 0;
            int i = 0;

            Console.WriteLine("Veuillez entrer un nombre :");
            input = Convert.ToInt32(Console.ReadLine());

            while(i <= input)
            {
                int num = 0;
                result += num + i;
                i++;
            }
            Console.WriteLine($"Le résultat est : {result}");

        }

// ______________________________________________________________________

    // Fonctions
        static void Fonc1()
        {
            Console.WriteLine("Exercice 1 lancé !");    
            Console.WriteLine(""); 
            /*
            Déclarez une fonction nommée "CalculerCarre" qui prend un entier en paramètre et renvoie le carré de ce nombre.
            */

            // Entrez vos lignes de code ci-dessous //
            Console.WriteLine("Veuillez entrer un nombre :");
            int input = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"{input} au carré donne : {input * input}");
        }
        static void Fonc2()
        {
            Console.WriteLine("Exercice 2 lancé !");
            Console.WriteLine("");
            /*
            Déclarez une fonction nommée "EstPair" qui prend un entier en paramètre et renvoie true si le nombre est pair, sinon renvoie false.
            */

            // Entrez vos lignes de code ci-dessous //
            Console.WriteLine("Veuillez entrer un nombre :");
            int input = Convert.ToInt16(Console.ReadLine());
            bool isTrue;
            Console.Clear();
            
            if(input % 2 == 0)
            {
                isTrue = true;
                Console.WriteLine($"Mon nombre {input} est Pair. {isTrue}");
            }
            else
            {
                isTrue = false;
                Console.WriteLine($"Mon nombre {input} est Pair. {isTrue}");
            }

        }        
        static void Fonc3()
        {
            Console.WriteLine("Exercice 3 lancé !");
            Console.WriteLine("");
            /*
            Déclarez une fonction nommée "CalculerMoyenne" qui prend trois nombres en paramètres et renvoie leur moyenne.
            */

            // Entrez vos lignes de code ci-dessous //
            Console.WriteLine("Combien avez vous de notes à entrer ?");
            decimal nbrNote = Convert.ToInt16(Console.ReadLine());
            decimal calc = 0;

            for(int i = 0; i < nbrNote; i++)
            {
                Console.WriteLine("Veuillez entrer une note");
                calc += Convert.ToInt16(Console.ReadLine());
            }
            decimal result = Convert.ToDecimal(calc / nbrNote);
            Console.WriteLine($"La moyene de vos {nbrNote} notes est de : {result}");
            Thread.Sleep(1000);

        }
        static void Fonc4()
        {
            Console.WriteLine("Exercice 4 lancé !");
            Console.WriteLine("");
            /*
            Déclarez une fonction nommée "TrouverMaximum" qui prend un tableau d'entiers en paramètre et renvoie la valeur maximale dans ce tableau.
            */
            // Entrez vos lignes de code ci-dessous //

            int i = 0;
            int nombreDePlaceTableau = 5;
            int index = 0;
            int valeurMax = 0;

            int[] tableauChiffre = new int[nombreDePlaceTableau];

            tableauChiffre[0] = 0;
            tableauChiffre[1] = 0;
            tableauChiffre[2] = 0;
            tableauChiffre[3] = 0;
            tableauChiffre[4] = 0;
            
            Console.WriteLine("Bonjours nous allons vous afficher le plus gros chiffre du tableau.");
            Console.WriteLine("Vous allez entrer 5 nombres.");
            DemandeChiffre();
            TestDeGrandeur();
            Console.WriteLine($"Le chiffre le plus grand est : {valeurMax}, et à pour index [{index}] dans notre tableau");

            void TestDeGrandeur()
            {
                valeurMax = tableauChiffre[0];
                index = 0;

                for (int ii = 0; ii < tableauChiffre.Length; ii++)
                {
                    int valeurSuivante = tableauChiffre[ii];

                    if(valeurMax < valeurSuivante)
                    {
                        valeurMax = valeurSuivante;
                        index = ii +1;
                    }
                }
            }

            void DemandeChiffre()
            {
                while(i < nombreDePlaceTableau)
                {
                    Console.WriteLine($"Veuillez entrer le nombre n°{i + 1 } : ");
                    tableauChiffre[i] = Convert.ToInt16(Console.ReadLine());
                    i++;
                }
            }



        }
        static void Fonc5()
        {
            Console.WriteLine("Exercice 5 lancé !");
            Console.WriteLine("");
            /*
            Déclarez une fonction nommée "ConvertirEnMajuscules" qui prend une chaîne de caractères en paramètre et renvoie la même chaîne en lettres majuscules.
            */
            // Entrez vos lignes de code ci-dessous //
            Console.WriteLine("Bonjour veuillez entrer une chaine de caractère :");
            //Console.WriteLine(Console.ReadLine().ToUpper());
            string input = Console.ReadLine().ToUpper();
            ConvertirEnMajuscule(input);
            static void ConvertirEnMajuscule(string inputUpper)
            {
                Console.WriteLine(inputUpper);
            }
        }        

// ______________________________________________________________________

    // Tableau 
        static void Tab1()
        {
            Console.WriteLine("Exercice 1 lancé !");
            Console.WriteLine("");     
            /*
            Déclarez et initialisez un tableau d'entiers contenant les cinq premiers nombres pairs (2, 4, 6, 8, 10) et affichez-les à l'écran.
            */

            // Entrez vos lignes de code ci-dessous //
            int[] tableau = new int[5];
            tableau[0] =  2;
            tableau[1] =  4;
            tableau[2] =  6;
            tableau[3] =  8;
            tableau[4] =  10;

            for(byte i = 0; i <= tableau.Length; i++)
            {
                Console.WriteLine(tableau[i]);
            }
            Thread.Sleep(1000);

        }
        static void Tab2()
        {
            Console.WriteLine("Exercice 2 lancé !");
            Console.WriteLine("");
            /*
            Déclarez et initialisez un tableau de chaînes de caractères contenant les noms de trois fruits (par exemple : "pomme", "orange", "banane") et affichez-les à l'écran.
            */
            // Entrez vos lignes de code ci-dessous //

            string[] tableau = new string[3];
            tableau[0] = "Ananas";
            tableau[1] = "Kiwi";
            tableau[2] = "Goyave";

            for(int i = 0; i <= tableau.Length; i++)
            {
                Console.WriteLine(tableau[i]);
            }
            Thread.Sleep(1000);
        }   
        static void Tab3()
        {
            Console.WriteLine("Exercice 3 lancé !");
            Console.WriteLine("");
            /*
            Déclarez et initialisez un tableau d'entiers contenant les dix premiers nombres entiers (1 à 10). 
            Demandez ensuite à l'utilisateur d'entrer un nombre entier. 
            Si le nombre entré par l'utilisateur se trouve dans le tableau, 
            affichez "Le nombre est présent dans le tableau", 
            sinon affichez "Le nombre n'est pas présent dans le tableau".
            */
            // Entrez vos lignes de code ci-dessous //

            int[] tableau = new int [10];
            tableau[0] = 1;
            tableau[1] = 2;
            tableau[2] = 3;
            tableau[3] = 4;
            tableau[4] = 5;
            tableau[5] = 6;
            tableau[6] = 7;
            tableau[7] = 8;
            tableau[8] = 9;
            tableau[9] = 10;

            Console.WriteLine("Veuillez entrer un nombre entier : ");
            int input = Convert.ToInt16(Console.ReadLine());
            bool isSame = false;


            for(int i = 0; i < tableau.Length; i++)
            {
                if(tableau[i] == input)
                {
                    isSame = true;
                    break;
                }
            }
            if(isSame == true)
            {
                Console.WriteLine("Votre nombre est présent dans le tableau.");
            }
            else Console.WriteLine("Votre nombre n'est pas présent dans le tableau.");
        }
        static void Tab4()
        {
            Console.WriteLine("Exercice 4 lancé !");
            Console.WriteLine("");
            /*
            Déclarez et initialisez un tableau d'entiers contenant cinq valeurs. Demandez ensuite à l'utilisateur d'entrer une valeur. 
            Si la valeur se trouve dans le tableau, supprimez-la et affichez le tableau mis à jour. 
            Sinon, ajoutez cette valeur à la fin du tableau et affichez le tableau mis à jour.
            */
            // Entrez vos lignes de code ci-dessous //

            // J'ai compris comment ça marche mais c'est hyper chiant, je serai passé par une liste personnellent.

            int input;
            int inputMenu;
            bool isIn = false;
            bool quit = false;

            int[] tableau = new int[5];
            tableau[0] = 10;
            tableau[1] = 20;
            tableau[2] = 30;
            tableau[3] = 40;
            tableau[4] = 50;

            while(quit == false)
            {
                Console.WriteLine("Menu :");
                Console.WriteLine("1. Afficher Tableau");
                Console.WriteLine("2. Modifier le tableau");
                Console.WriteLine("3. Quitter");
                Console.Write("Entrer un chiffre : ");
                inputMenu = Convert.ToInt16(Console.ReadLine());
                
                switch(inputMenu)
                {
                    case 1:
                    Tableau();
                    break;
                    
                    case 2:
                    MenuTableau();
                    break;

                    case 3:
                    quit = true;
                    break;
                }
            }

            void Tableau()
            {
                Console.WriteLine("Voici vos chiffres :");
                for(int i = 0; i < tableau.Length; i++)
                {
                    Console.WriteLine(tableau[i]);
                }
            }

            void MenuTableau()     
            {
                Console.WriteLine("Voici vos chiffres :");
                for(int i = 0; i < tableau.Length; i++)
                {
                    Console.WriteLine(tableau[i]);
                }

                Console.WriteLine("Veuillez entrer un nombre :");
                input = Convert.ToInt16(Console.ReadLine());
            }
        }
        static void Tab5()
        {
            Console.WriteLine("Exercice 5 lancé !");
            Console.WriteLine("");
            /*
            Déclarez et initialisez un tableau d'entiers de taille 5. 
            Demandez à l'utilisateur d'entrer cinq valeurs entières et stockez-les dans le tableau. 
            Ensuite, affichez la somme de toutes les valeurs du tableau.
            */

            // Entrez vos lignes de code ci-dessous //
            int total = 0;
            int tailleTableau = 5;
            int[] tableau = new int [tailleTableau];
            
            
            for(int i = 0; i < tailleTableau; i++)
            {
                Console.WriteLine($"Veuillez entrer la valeur n°{i + 1}");
                tableau[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < tailleTableau; i++)
            {
                total += tableau[i];
            }

            Console.WriteLine($"La sommes de vos nombres est : {total}");


        }        

// ______________________________________________________________________

    // Listes
        static void Liste1()
        {
            Console.WriteLine("Exercice 1 lancé !");            
            Console.WriteLine("");
            /*
            Créez une liste d'entiers vide et demandez à l'utilisateur d'entrer cinq nombres entiers. Ajoutez ces nombres à la liste et affichez ensuite la liste complète à l'écran.
            */
            // Entrez vos lignes de code ci-dessous //

            // Déclaration et initialisation d'une liste d'entiers

            int nombreAEntrer = 5;
            int i = 0;
            int ii = 1;
            List<int> listeEntiers = new();

            Console.WriteLine($"Veuillez entrer {nombreAEntrer} nombre : ");
            
            for(i = 0; i < nombreAEntrer; i++)
            {
                Appel();
            }
            
            Console.Clear();
            foreach(int numbers in listeEntiers)
            {
                Console.Write(numbers + ", ");
            }

            void Appel()
            {
                Console.WriteLine($"Nombre n°{ii}");
                listeEntiers.Add(Convert.ToInt32(Console.ReadLine()));
                ii++;
            }
        }
        static void Liste2()
        {
            Console.WriteLine("Exercice 2 lancé !");
            Console.WriteLine("");
            /*
            Créez une liste de chaînes de caractères contenant les noms de trois pays. Demandez ensuite à l'utilisateur d'entrer le nom d'un pays. 
            Si le pays se trouve dans la liste, supprimez-le et affichez la liste mise à jour. 
            Sinon, ajoutez ce pays à la liste et affichez la liste mise à jour.
            */
            // Entrez vos lignes de code ci-dessous //

            bool running = true;
            List<string> listePays = new()
            {
                "Suisse", "France", "Allemagne", "Norvège", "Pays-Bas", "Autriche", "Espagne"
            };

            Affichage();

            while(running)
            {
                Console.WriteLine("Veuillez entrer le nom d'un pays d'Europe.\n");
                string recherche = Console.ReadLine();

                if(listePays.Contains(recherche))
                {
                    listePays.Remove(recherche);
                    Console.WriteLine($"La valeur {recherche} a été trouvée, supression en cours...");
                    Thread.Sleep(1000);
                    Affichage();
                }
                else
                {
                    listePays.Add(recherche);
                    Console.WriteLine($"La valeur {recherche} n'a pas été trouvée, ajout à la liste en cours...");
                    Thread.Sleep(1000);
                    Affichage();

                }
            }

            void Affichage()
            {
                Console.WriteLine("Voici votre liste de pays : ");
                foreach(string pays in listePays)
                {
                    Console.Write(pays + ", ");
                    Console.WriteLine("");
                }
            }
            

        }        
        static void Liste3()
        {
            Console.WriteLine("Exercice 3 lancé !");
            Console.WriteLine("");
            /*
            Créez une liste d'entiers contenant quelques valeurs initiales. 
            Demandez à l'utilisateur d'entrer un nombre entier. 
            Si le nombre se trouve dans la liste, affichez son index dans la liste. 
            Sinon, ajoutez-le à la liste et affichez la liste mise à jour.
            */
            // Entrez vos lignes de code ci-dessous //

            bool running = true;
            List<int> listeNombre = new()
            {
                13, 21, 68, 897, 254, 1354, 12, 34
            };

            Affichage();

            while(running)
            {
                Console.WriteLine("Veuillez entrer un nombre.\n");
                int recherche = Convert.ToInt32(Console.ReadLine());

                if(listeNombre.Contains(recherche))
                {
                    Console.WriteLine($"La valeur {recherche} a été trouvée, voici son index :" + listeNombre.IndexOf(recherche));
                    Thread.Sleep(1000);
                    Affichage();
                }
                else
                {
                    listeNombre.Add(recherche);
                    Console.WriteLine($"La valeur {recherche} n'a pas été trouvée, ajout à la liste en cours...");
                    Thread.Sleep(1000);
                    Affichage();

                }
            }

            void Affichage()
            {
                Console.WriteLine("Voici votre liste de nombre : ");
                foreach(int nombre in listeNombre)
                {
                    Console.Write(nombre + ", ");
                    Console.WriteLine("");
                }
            }

        }
        static void Liste4()
        {
            Console.WriteLine("Exercice 4 lancé !");
            Console.WriteLine("");
            /*
            Créez une liste d'entiers contenant quelques valeurs initiales. 
            Demandez à l'utilisateur d'entrer un nombre entier. 
            Affichez ensuite combien de fois cette valeur apparaît dans la liste.
            */
            // Entrez vos lignes de code ci-dessous //

            int total = 0;

            List<int> listeNombre = new()
            {
                1, 
                2, 2, 
                3, 3, 3, 
                4, 4, 4, 4, 
                5, 5, 5, 5, 5, 
                6, 6, 6, 6, 6, 6, 
                7, 7, 7, 7, 7, 7, 7, 
                8, 8, 8, 8, 8, 8, 8, 8, 
                9, 9, 9, 9, 9, 9, 9, 9, 9
            };

            Console.WriteLine("Veuillez entrer un nombre à vérifier : ");
            int recherche = Convert.ToInt32(Console.ReadLine());
            
            foreach(int num in listeNombre)
            {
                if(num == recherche)
                {
                    total++;
                }
            }

            Console.WriteLine($"Il y a {total}x la valeur [{recherche}]");

        }
        static void Liste5()
        {
            Console.WriteLine("Exercice 5 lancé !");
            Console.WriteLine("");
            /*
            Créez une liste d'entiers contenant quelques valeurs initiales. Demandez à l'utilisateur d'entrer un nombre entier. 
            Supprimez toutes les occurrences de cette valeur dans la liste et affichez la liste mise à jour.
            */
            // Entrez vos lignes de code ci-dessous //

            bool running = true;
            List<int> ListeNombre = new()
            {
                1, 
                2, 2, 
                3, 3, 3, 
                4, 4, 4, 4, 
                5, 5, 5, 5, 5
            };

            while(running)
            {
                Affichage();

                Console.WriteLine("\nVeuillez entrer un nombre entier :");
                int recherche = Convert.ToInt32(Console.ReadLine());

            
                
                if(ListeNombre.Contains(recherche))
                {
                    Console.WriteLine($"La valeur {recherche} a été trouvée.");
                    Console.WriteLine("...Suppression en cours...");
                    Thread.Sleep(1000);

                    while(ListeNombre.Contains(recherche))
                    {
                        ListeNombre.Remove(recherche);
                    }

                    Affichage();
                }
                else
                {
                    ListeNombre.Add(recherche);
                    Console.WriteLine($"La valeur {recherche} n'a pas été trouvée.");
                    Thread.Sleep(1000);
                    Affichage();
                }
            }

            

            void Affichage()
            {
                Console.WriteLine("Voici votre liste de nombre : ");
                foreach(int nombre in ListeNombre)
                {
                    Console.Write(nombre + ", ");
                    Console.WriteLine("");
                }
            }

        }   

// ______________________________________________________________________//
//                                                                       //
//                         ESPACE EXERCICES AVANCÉS                      //
// ______________________________________________________________________//


    // Exercice Algo

        static void Algo1()
        {
            Console.WriteLine("Exercice 1 lancé !");            
            Console.WriteLine("");

            /*
            Vous travaillez dans une bibliothèque et vous devez concevoir un algorithme pour organiser les livres retournés. 
            Les livres peuvent être classés en trois catégories : "Fiction", "Non-fiction" et "Enfants". 
            L'algorithme doit prendre chaque livre retourné, déterminer sa catégorie et le placer dans la bonne pile.
            */



        }

        static void Algo2()
        {
            /*
            Vous programmez un thermostat pour une serre qui cultive des plantes tropicales. 
            La température idéale pour la serre est entre 26°C et 29°C. 
            Si la température dépasse 29°C, le système doit activer les ventilateurs. 
            Si elle descend en dessous de 26°C, le système doit activer le chauffage. 
            Si la température est dans la plage idéale, rien ne doit être fait, sauf vérifier à nouveau après 5 minutes.
            */
        }

        static void Algo3()
        {
            /*
            Programmer un système de barrière automatique qui s'active par télécommande.
            */
        }

    }
}