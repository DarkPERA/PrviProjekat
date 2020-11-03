using System;

namespace Projekat
{
    class Program
    {
        static void Main(string[] args)
        {

            
             Console.WriteLine("Dobrodosli u igru zivota. U ovoj igri vi ste ucenik budzeta na VTS u Novom Sadu i imate 20 godina. \nPostoje dva indikatora koja ce uvek biti prikazana i koja oznacavaju gde se nalazite u igri.To su novac i zabava.\nUkoliko ostanete bez novca, izgubili ste. Ukoliko ostanete bez zabave, pocecete da gubite novac dok ne izgubite igricu.\nKako bi presli na opciju kreiranja lika, pritisnite enter");

             Console.ReadLine();

             Console.Clear();          


             Console.WriteLine("Dobrodosli u meni za kreiranje lika. Vas zivot i tok igrice ce jednim delom biti odluceni u ovom meniju, birajte pazljivo.\n");


             Console.WriteLine("\nOdaberite pol vaseg lika\n1) Musko\n2) Zensko");
            int pol = Convert.ToInt32(Console.ReadLine());
            while(pol < 1 || pol > 2)
            {
                Console.WriteLine("Molimo unesite adekvatne vrednosti 1 ili 2");
                pol = Convert.ToInt32(Console.ReadLine());
            }

             Console.WriteLine("\n\nDa li vas lik ima roditelje, ako da, koje?\n1)Oba roditelja\n2)Samo oca\n3)Samo majku\n4)Bez roditelja");
             int roditelj = Convert.ToInt32(Console.ReadLine());
            while(roditelj < 1 || roditelj > 4)
            {
                Console.WriteLine("Molimo unesite adekvatne vrednosti 1, 2, 3 ili 4");
                roditelj = Convert.ToInt32(Console.ReadLine());

            }


             Console.WriteLine("\n\nGde vas lik boravi?\n1)Kuca\n2)Stan\n3)Dom");
             int mesto = Convert.ToInt32(Console.ReadLine());
            while(mesto > 3 || mesto < 1)
            {
                Console.WriteLine("Molimo odaberite adekvatne vrednosti izmedju 1, 2 ili 3");
                mesto = Convert.ToInt32(Console.ReadLine());

            }
               
            Console.WriteLine("\n\nUnesite visinu vaseg lika, minimalno je 80cm, a maksimalno je 215cm");
            int visina = Convert.ToInt32(Console.ReadLine());
           
            while (visina < 80 || visina > 215)
            {
                Console.WriteLine("Niste uneli podrazumevane vrednosti za visinu, molimo vas da unesete podrazumevane vrednosti za visinu!");
                visina = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n\nUnesite kilazu vaseg lika, minimum je 40 kilograma, a maksimalno je 250 kilograma");
            int kilaza = Convert.ToInt32(Console.ReadLine());
            while(kilaza < 40 || kilaza > 250)
            {
                Console.WriteLine("Niste uneli podrazumevane vrednosti za kilazu, unesite vrednosti izmedju 40 i 250 kilograma");
                kilaza = Convert.ToInt32(Console.ReadLine());
                
            }

            
            int zabava = 100;
            int novac = 100;
            int doprinos = 100;
            int indikator = 0;
           
            switch(roditelj)
            {
                case 1:
                    if (mesto == 1)
                    {
                        novac = 5000;
                        doprinos = 8000;
                    }
                    else if (mesto == 2)
                    {
                        novac = 30000;
                        doprinos = 13000;
                    }
                    else
                    {
                        novac = 5000;
                        doprinos = 4000;
                    }
                        break;
                case 2:
                    if (mesto == 1)
                    {
                        novac = 5000;
                        doprinos = 6000;
                    }
                    else if (mesto == 2)
                    {
                        novac = 22000;
                        doprinos = 8000;
                    }
                    else
                    {
                        novac = 3000;
                        doprinos = 3000;
                    }
                        break;
                case 3:
                    if (mesto == 1)
                    {
                        novac = 5000;
                        doprinos = 6000;
                    }
                    else if (mesto == 2)
                    {
                        novac = 22000;
                        doprinos = 8000;
                    }
                    else
                    {
                        novac = 3000;
                        doprinos = 3000;
                    }
                    break;

                case 4:
                    if (mesto == 1)
                    {
                        novac = 5000;
                        doprinos = 4000;
                    }
                    else if (mesto == 2)
                    {
                        novac = 22000;
                        doprinos = 6000;
                    }
                    else
                    {
                        novac = 3000;
                        doprinos = 4000;
                    }
                    indikator = 1;
                    break;

            }
            static void pool(int x)
            {
                if (x == 1)
                    Console.WriteLine("Pol vaseg lika je: Musko");
                else
                    Console.WriteLine("Pol vaseg lika je: Zensko");                

            }

            static void roditelji(int x)
            {
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Vas lik ima oca i majku");
                        break;
                    case 2:
                        Console.WriteLine("Vas lik ima samo oca");
                        break;
                    case 3:
                        Console.WriteLine("Vas lik ima samo majku");
                        break;
                    case 4:
                        Console.WriteLine("Vas lik nema roditelje");
                        break;

                }
            }

                static void mestoo(int x)
                {
                    switch (x)
                    {
                        case 1:
                            Console.WriteLine("Vas lik zivi u kuci");
                            break;
                        case 2:
                            Console.WriteLine("Vas lik zivi u stanu");
                            break;
                        case 3:
                            Console.WriteLine("Vas lik zivi u domu");
                            break;
                            
                    }

                }


                 Console.Clear();

            Console.WriteLine("Specifikacije lika su postavljene!");
            pool(pol);
            roditelji(roditelj);
            mestoo(mesto);
                Console.WriteLine("Visina vaseg lika je: " + visina+" cm");
                Console.WriteLine("Kilaza vaseg lika je: " + kilaza + " kg");
            Console.WriteLine("Vas trenutni novac je: " + novac + " dinara");
            Console.WriteLine("Vasi mesecni doprinosi su: " + doprinos + " dinara");
            Console.WriteLine("Vasa trenutna zabava je: " + zabava);
                Console.WriteLine("\n\nPritisnite ENTER da bi nastavili dalje u igru");
            Console.ReadLine();

            Console.Clear();

            

            static int Troskovi(int x, int y) 
            {
                switch (x)
                {
                    case 1:
                        return y - 2000;
                        break;
                    case 2:
                        return y - 5000;
                        break;
                    case 3:
                        return y;
                        break;

                }
                return y;
            }

            static int GubitakNovca(int x)  
            {
                
                    x = x - 500;
                Console.WriteLine("\n\nVasa zabava je na nuli, zabavite se ili cete nastaviti da gubite novac!");
                return x;

                

            }

           

            static int LimitZabavu(int x, int min, int max)  
            {
                if (x >= min)
                {

                    if (x <= max)
                    {
                        return x;
                    }
                    return max;
                }
                return min;

            }


            static int ucenje(int x)
            {
                Console.WriteLine("\n\nDa li zelite da ucite?\n1)Da!\n2)Ne!");
                int y = Convert.ToInt32(Console.ReadLine());
                while (y < 1 || y > 2)
                {
                    Console.WriteLine("Molimo unesite podrazumevane vrednosti 1 ili 2");
                    y = Convert.ToInt32(Console.ReadLine());
                }
                if (y == 1)
                {
                    Console.WriteLine("\n\nUcili ste ovog meseca!");
                    x = x - 5;
                }
                else
                {
                    x = x + 0;
                    Console.WriteLine("\n\nNiste ucili ovog meseca!");
                }
                return x;
                               
            }

            static int izlazak(int x)
            {
                Console.WriteLine("\n\nDa li zelite da izadjete u provod?\n1)Da!\n2)Ne!");
                int y = Convert.ToInt32(Console.ReadLine());
                while (y < 1 || y > 2)
                {
                    Console.WriteLine("Molimo unesite podrazumevane vrednosti 1 ili 2");
                    y = Convert.ToInt32(Console.ReadLine());
                }
                if (y == 1)
                {
                    Console.WriteLine("\n\nIzasli ste i super ste se proveli!");
                    x = x - 300;
                }
                else
                {
                    Console.WriteLine("\n\nNiste izasli i nikom nista");
                    x = x + 0;
                }
                return (x);

            }

            int sudoper = 0;
             static int sudopera(int x) 
            {
                Console.WriteLine("\n\nU vasoj sudoperi se nakupilo previse taloga i sada je zacepljena, izaberite neku od opcija:\n1)Pozovi majstora\n2)Pokusaj sam da je popravis\n3)Ne radi nista");
                x = Convert.ToInt32(Console.ReadLine());
                while (x < 1 || x > 3)
                {
                    Console.WriteLine("Molimo unesite podrazumevane vrednosti 1, 2 ili 3");
                    x = Convert.ToInt32(Console.ReadLine());
                }
                switch (x)
                {
                    case 1:
                        Console.WriteLine("\n\nPozvali ste majstora i majstor vam je uzeo 1000 dinara.");
                        return x;
                        break;

                    case 2:
                        return x;
                        break;

                    case 3:
                        
                        return x;
                        break;

                        

                }

                return x;         
            }

            static int Dom(int x)
            {
                Console.WriteLine("\n\nNazalost nemate srece. Vas cimer mora da se priprema za kolokvijum\ni uci svaki dan kasno do 5 ujutru.\n\nIzgubili ste 10 zabave.");
                x = x - 10;
                return x;

            }

            
            static int DomZurka(int x) 
            {
                Console.WriteLine("\n\nNeko u domu veceras organizuje zurku!\n1)Pridruzi im se!\n2)Pokusaj da zaspis.");
                x = Convert.ToInt32(Console.ReadLine());
                while (x < 1 || x > 2)
                {
                    Console.WriteLine("Molimo unesite podrazumevane vrednosti 1 ili 2");
                    x = Convert.ToInt32(Console.ReadLine());
                }
                if (x == 1)
                {
                    Console.WriteLine("\n\nPridruzili ste im se i dobili ste 10 zabave, ali izgubili 300 dinara!");
                    return x;
                }
                else
                {
                    Console.WriteLine("\n\nNiste im se pridruzili, ali ste barem spavali. Zabava je veca za 5.");
                    return x;

                }
                    return x;

            }

            
            static int exclusive(int x, int y) 
            {
                if (y == 1)
                {
                    Console.WriteLine("\n\nOdjednom se pojavljuje vas daljni rodjak koji je cuvao novac u iznosu od 1.000.000 dolara\ni zeli da ga preda vama ako odgovorite tacno na sledeca pitanja");
                    Console.WriteLine("Pitanje broj jedan:\nKoja od sledecih boja opisuje vas?\n1)Bela\n2)Zuta\n3)Crna");
                    int prvo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n\nPitanje broj dva:\nKako ocenjujete higijenu u gradu?\n1)Prezivljava se\n2)Pa dobro\n3)Haos");
                    int drugo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n\nPitanje broj tri:\nDa li znate ko je Nenad Knezevic Knez?\n1)Da\n2)Ne");
                    int trece = Convert.ToInt32(Console.ReadLine());
                    if (prvo == 3 && drugo == 2 && trece == 1)
                    {
                        Console.WriteLine("\n\n\nCestitamo!!! Pobedili ste igricu!!");
                        return x + 1000000;
                    }
                    else
                        Console.WriteLine("\n\n\nNazalost nemate srece, niste odgovorili tacno na sva pitanja i niste nasledili novac");
                }
                return x;
            }


            static int KucaPas(int x)
            {
                Console.WriteLine("\n\nKomsijin pas je odlucio da laje celu noc i niste se naspavali. Nazalost gubite 5 zadovoljstva");
                return x - 5;

            }

            static int StanBurgija(int x)
            {
                Console.WriteLine("\n\nVas komsija je odlucio da burgija u 7 ujutru. Nazalost gubite 5 zadovoljstva jer ne mozete da se naspavate");
                return x - 5;
                
            }

      
            Random procenat = new Random();
            int sansica = 0;
            

            int ne = 0;
            int ke = 0;
            int glupost = 0;
            int ispit = 0;
            int zabavatest = 0;
            int novactest = 0;
            int uf = 0;
            int tamdam = 0;
            string[] meseci = new string[12] { "Septembar", "Oktobar", "Novembar", "Decembar", "Januar", "Februar", "Mart", "April", "Maj", "Jun", "Jul", "Avgust" };

                int i = 0;
            for(i=0;i<=11;i++)
            {
                meseci[i] = meseci[i] + " Mesec";
            }
            i = 0;
            while (i <= 11)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine(meseci[i]);
                        i++;
                        novac = Troskovi(mesto, novac);
                        Console.WriteLine("Vasi resursi:\nNovac = " + novac + " dinara\nDoprinosi = " + doprinos + " dinara\nZabava = " + zabava);
                        Console.WriteLine("\n\nOvo je vas prvi mesec na fakultetu!\nImate prvo predavanje u punom amfiteatru, ovo je vasa prilika da ostanete zapamceni!\n1)Pokusaj da se nasalis\n2)Napravi glupost\n3)Ne radi nista");
                        uf = Convert.ToInt32(Console.ReadLine());
                        while (uf < 1 || uf > 3)
                        {
                            Console.WriteLine("\n\nMolimo unesite podrazumevane vrednosti 1, 2 ili 3");
                            uf = Convert.ToInt32(Console.ReadLine());
                        }
                        if (uf == 1)
                        {
                            Console.WriteLine("\n\nVasa sala je primecena od strane profesora i kolega, dobro ste postupili!");
                        }
                        if (uf == 2)
                        {
                            Console.WriteLine("\n\nVasa glupost je primecena od strane profesora i kolega, srecno na ispitu");
                            glupost = 1;
                        }
                        if (uf == 3)
                            Console.WriteLine("\n\nNiste nista uradili i nikom nista");


                        zabavatest = zabava;
                        zabava = ucenje(zabava);
                        if (zabavatest != zabava)
                            ispit++;

                        novactest = novac;
                        novac = izlazak(novac);
                        if (novactest != novac)
                            zabava = zabava + 5;

                        sansica = procenat.Next(11);
                        if (mesto == 1 && sansica <= 5)
                            zabava = KucaPas(zabava);

                        sansica = procenat.Next(11);
                        if (mesto == 2 && sansica <= 5)
                            zabava = StanBurgija(zabava);

                        sansica = procenat.Next(11);
                        if (mesto == 3 && sansica <= 5)
                            zabava = Dom(zabava);

                        if (mesto == 3 && sansica <= 5)
                        {
                            ke = DomZurka(ke);
                            if (ke == 1)
                            {
                                novac = novac - 300;
                                zabava = zabava + 10;
                            }
                            else
                                zabava = zabava + 5;
                        }


                        sansica = procenat.Next(11);
                        if (mesto == 1 || mesto == 2 && sansica <= 3)
                        {
                            sudoper = sudopera(sudoper);
                            if (sudoper == 1)
                            {
                                novac = novac - 1000;

                            }
                            if (sudoper == 2)
                            {

                                sansica = procenat.Next(11);
                                if (sansica <= 6)
                                {
                                    Console.WriteLine("\n\nUspeo si sam da je popravis!");

                                }
                                else
                                {
                                    Console.WriteLine("\n\nNisi uspeo sam da je popravis i pozvao si majstora");
                                    novac = novac - 1500;
                                    zabava = zabava - 10;
                                }
                            }

                            if (sudoper == 3)
                            {
                                Console.WriteLine("\n\nOstavio si sudoperu takvu kakva je i ne mozes vise da peres sudje.");
                                zabava = zabava - 15;

                            }

                        }

                        sansica = procenat.Next(11);
                        if (sansica < 3 && indikator == 1)
                            novac = exclusive(novac, indikator);
                        if (novac > 1000000)
                            i = 13;

                        Console.WriteLine("Da predjete u sledeci mesec, pritisnite ENTER!");
                        Console.ReadLine();
                        break;




                    case 1:
                        Console.Clear();
                        Console.WriteLine(meseci[i]);
                        i++;
                        novac = novac + doprinos;

                        zabava = LimitZabavu(zabava, 0, 100);
                        if (zabava == 0)
                        {
                            novac = GubitakNovca(novac);
                        }
                        novac = Troskovi(mesto, novac);
                        if (novac < 0)
                        {
                            i = 14;
                            break;
                        }
                        Console.WriteLine("Vasi resursi:\nNovac = " + novac + " dinara\nDoprinosi = " + doprinos + " dinara\nZabava = " + zabava);

                        zabavatest = zabava;
                        zabava = ucenje(zabava);
                        if (zabavatest != zabava)
                            ispit++;

                        novactest = novac;
                        novac = izlazak(novac);
                        if (novactest != novac)
                            zabava = zabava + 5;

                        Console.WriteLine("\n\nDok ste hodali ulicom, prisla vam je devojka koja razdeljuje flajere \ni ponudila vam je posao na par dana.\nDa li prihvatate ili ne prihvatate ovu ponudu?\n1)Prihvatam\n2)Ne prihvatam");
                        int prihvatanje = Convert.ToInt32(Console.ReadLine());
                        while (prihvatanje < 1 || prihvatanje > 2)
                        {
                            Console.WriteLine("Molimo unesite podrazumevane parametre 1 ili 2");
                            prihvatanje = Convert.ToInt32(Console.ReadLine());

                        }
                        if (prihvatanje == 1)
                        {
                            Console.WriteLine("Prihvatili ste posao i uspeli ste da zaradite 2000 dinara, ali ste izgubili 10 zabave!");
                            novac = novac + 2000;
                            zabava = zabava - 10;
                        }
                        else
                            Console.WriteLine("Niste prihvatili posao i nikom nista.");
                        sansica = procenat.Next(11);
                        if (mesto == 1 && sansica <= 5)
                            zabava = KucaPas(zabava);

                        sansica = procenat.Next(11);
                        if (mesto == 2 && sansica <= 5)
                            zabava = StanBurgija(zabava);

                        sansica = procenat.Next(11);
                        if (mesto == 3 && sansica <= 5)
                            zabava = Dom(zabava);

                        if (mesto == 3 && sansica <= 5)
                        {
                            ke = DomZurka(ke);
                            if (ke == 1)
                            {
                                novac = novac - 300;
                                zabava = zabava + 10;
                            }
                            else
                                zabava = zabava + 5;
                        }


                        sansica = procenat.Next(11);
                        if (mesto == 1 || mesto == 2 && sansica <= 3)
                        {
                            sudoper = sudopera(sudoper);
                            if (sudoper == 1)
                            {
                                novac = novac - 1000;

                            }
                            if (sudoper == 2)
                            {

                                sansica = procenat.Next(11);
                                if (sansica <= 6)
                                {
                                    Console.WriteLine("\n\nUspeo si sam da je popravis!");

                                }
                                else
                                {
                                    Console.WriteLine("\n\nNisi uspeo sam da je popravis i pozvao si majstora");
                                    novac = novac - 1500;
                                    zabava = zabava - 10;
                                }
                            }

                            if (sudoper == 3)
                            {
                                Console.WriteLine("\n\nOstavio si sudoperu takvu kakva je i ne mozes vise da peres sudje.");
                                zabava = zabava - 15;

                            }

                        }

                        sansica = procenat.Next(11);
                        if (sansica < 3 && indikator == 1)
                            novac = exclusive(novac, indikator);
                        if (novac > 1000000)
                            i = 13;




                        Console.WriteLine("Da predjete u sledeci mesec, pritisnite ENTER!");
                        Console.ReadLine();

                        break;



                    case 2:
                        Console.Clear();
                        Console.WriteLine(meseci[i]);
                        i++;
                        novac = novac + doprinos;

                        zabava = LimitZabavu(zabava, 0, 100);
                        if (zabava == 0)
                        {
                            novac = GubitakNovca(novac);
                        }
                        novac = Troskovi(mesto, novac);
                        if (novac < 0)
                        {
                            i = 14;
                            break;
                        }
                        Console.WriteLine("Vasi resursi:\nNovac = " + novac + " dinara\nDoprinosi = " + doprinos + " dinara\nZabava = " + zabava);

                        zabavatest = zabava;
                        zabava = ucenje(zabava);
                        if (zabavatest != zabava)
                            ispit++;

                        novactest = novac;
                        novac = izlazak(novac);
                        if (novactest != novac)
                            zabava = zabava + 5;

                        Console.WriteLine("Po vasoj skoli se prijavljuju kandidati koji bi zeleli da ucestvuju kao deo studentskog parlamenta!\nDa li cete i vi konkurisati?\n1)Da\n2)Ne");
                        ne = Convert.ToInt32(Console.ReadLine());
                        while (ne > 2 || ne < 1)
                        {
                            Console.WriteLine("Molimo unesite podrazumevane parametre 1 ili 2");
                            ne = Convert.ToInt32(Console.ReadLine());
                        }
                        if (ne == 1 && glupost != 1)
                        {
                            Console.WriteLine("Cestitamo, postali ste clan studentskog parlamenta!\nVasi mesecni doprinosi se povacavaju za 500");
                            doprinos = doprinos + 500;

                        }
                        else
                            Console.WriteLine("Niste postali clan studentskog parlamenta");


                        sansica = procenat.Next(11);
                        if (mesto == 1 && sansica <= 5)
                            zabava = KucaPas(zabava);

                        sansica = procenat.Next(11);
                        if (mesto == 2 && sansica <= 5)
                            zabava = StanBurgija(zabava);

                        sansica = procenat.Next(11);
                        if (mesto == 3 && sansica <= 5)
                            zabava = Dom(zabava);

                        if (mesto == 3 && sansica <= 5)
                        {
                            ke = DomZurka(ke);
                            if (ke == 1)
                            {
                                novac = novac - 300;
                                zabava = zabava + 10;
                            }
                            else
                                zabava = zabava + 5;
                        }


                        sansica = procenat.Next(11);
                        if (mesto == 1 || mesto == 2 && sansica <= 3)
                        {
                            sudoper = sudopera(sudoper);
                            if (sudoper == 1)
                            {
                                novac = novac - 1000;

                            }
                            if (sudoper == 2)
                            {

                                sansica = procenat.Next(11);
                                if (sansica <= 6)
                                {
                                    Console.WriteLine("\n\nUspeo si sam da je popravis!");

                                }
                                else
                                {
                                    Console.WriteLine("\n\nNisi uspeo sam da je popravis i pozvao si majstora");
                                    novac = novac - 1500;
                                    zabava = zabava - 10;
                                }
                            }

                            if (sudoper == 3)
                            {
                                Console.WriteLine("\n\nOstavio si sudoperu takvu kakva je i ne mozes vise da peres sudje.");
                                zabava = zabava - 15;

                            }

                        }

                        sansica = procenat.Next(11);
                        if (sansica < 3 && indikator == 1)
                            novac = exclusive(novac, indikator);
                        if (novac > 1000000)
                            i = 13;

                        Console.WriteLine("Da predjete u sledeci mesec, pritisnite ENTER!");
                        Console.ReadLine();

                        break;



                    case 3:
                        Console.Clear();
                        Console.WriteLine(meseci[i]);
                        i++;
                        novac = novac + doprinos;

                        zabava = LimitZabavu(zabava, 0, 100);
                        if (zabava == 0)
                        {
                            novac = GubitakNovca(novac);
                        }
                        novac = Troskovi(mesto, novac);
                        if (novac < 0)
                        {
                            i = 14;
                            break;
                        }
                        Console.WriteLine("Vasi resursi:\nNovac = " + novac + " dinara\nDoprinosi = " + doprinos + " dinara\nZabava = " + zabava);


                        zabavatest = zabava;
                        zabava = ucenje(zabava);
                        if (zabavatest != zabava)
                            ispit++;

                        novactest = novac;
                        novac = izlazak(novac);
                        if (novactest != novac)
                            zabava = zabava + 5;
                        int fu = 0;

                        if (ispit > 2)
                        {
                            Console.WriteLine("Profesori matematike i programiranja primecuju vas trud i nude vam opciju da uradite projekat na temu enkripcije podataka\nDa li ste zainteresovani?\n1)Da\n2)Ne");
                            fu = Convert.ToInt32(Console.ReadLine());
                            while (fu < 1 || fu > 2)
                            {
                                Console.WriteLine("Molimo unesite podrazumevane vrednosti 1 ili 2");
                                fu = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Profesori matematike i programiranja vas upozoravaju da ukoliko ovako nastavite\nda se ponasate i ophodite prema skoli, necete proci sve ispite!");
                        }
                        if (fu == 1) 
                        { 
                            Console.WriteLine("Uspesno ste odradili projekat!");
                            ispit++;
                        }
                        else
                        {
                            Console.WriteLine("Nazalost odbili ste priliku da se unapredite.");
                        }

                        sansica = procenat.Next(11);
                        if (mesto == 1 && sansica <= 5)
                            zabava = KucaPas(zabava);

                        sansica = procenat.Next(11);
                        if (mesto == 2 && sansica <= 5)
                            zabava = StanBurgija(zabava);

                        sansica = procenat.Next(11);
                        if (mesto == 3 && sansica <= 5)
                            zabava = Dom(zabava);

                        if (mesto == 3 && sansica <= 5)
                        {
                            ke = DomZurka(ke);
                            if (ke == 1)
                            {
                                novac = novac - 300;
                                zabava = zabava + 10;
                            }
                            else
                                zabava = zabava + 5;
                        }


                        sansica = procenat.Next(11);
                        if (mesto == 1 || mesto == 2 && sansica <= 3)
                        {
                            sudoper = sudopera(sudoper);
                            if (sudoper == 1)
                            {
                                novac = novac - 1000;

                            }
                            if (sudoper == 2)
                            {

                                sansica = procenat.Next(11);
                                if (sansica <= 6)
                                {
                                    Console.WriteLine("\n\nUspeo si sam da je popravis!");

                                }
                                else
                                {
                                    Console.WriteLine("\n\nNisi uspeo sam da je popravis i pozvao si majstora");
                                    novac = novac - 1500;
                                    zabava = zabava - 10;
                                }
                            }

                            if (sudoper == 3)
                            {
                                Console.WriteLine("\n\nOstavio si sudoperu takvu kakva je i ne mozes vise da peres sudje.");
                                zabava = zabava - 15;

                            }

                        }

                        sansica = procenat.Next(11);
                        if (sansica < 3 && indikator == 1)
                            novac = exclusive(novac, indikator);
                        if (novac > 1000000)
                            i = 13;


                        Console.WriteLine("Da predjete u sledeci mesec, pritisnite ENTER!");
                        Console.ReadLine();
                        break;



                        case 4:
                        Console.Clear();
                        Console.WriteLine(meseci[i]);
                            i++;
                        novac = novac + doprinos;

                        zabava = LimitZabavu(zabava, 0, 100);
                        if (zabava == 0)
                        {
                            novac = GubitakNovca(novac);
                        }
                        novac = Troskovi(mesto, novac);
                        if (novac < 0)
                        {
                            i = 14;
                            break;
                        }
                        Console.WriteLine("Vasi resursi:\nNovac = " + novac + " dinara\nDoprinosi = " + doprinos + " dinara\nZabava = " + zabava);


                        Console.WriteLine("\n\nDoslo je vreme da se pokaze sta ste ucili tokom semestra!\nVreme je za ispite!");
                        if (glupost == 1)
                        {
                            Console.WriteLine("\n\nZbog vaseg ispada na pocetku semestra, profesori ce vas gledati drugacije na ispitu");
                            --ispit;
                        }
                        if (ispit >= 3)
                        {
                        Console.WriteLine("\n\nS obzirom da ste dovoljno ucili ovog semestra, polozili ste sve ispite!\nVasi doprinosi se povecavaju za 1000!\nSvaka cast!");
                            doprinos = doprinos + 1000;
                        }
                       else
                        {
                            Console.WriteLine("\n\nNiste ucili dovoljno ovog semestra! Vas mesecni dobitak se smanjuje za 500");
                            doprinos = doprinos - 500;

                        }
                        

                        zabavatest = zabava;
                        zabava = ucenje(zabava);
                        if (zabavatest != zabava)
                            ispit++;

                        novactest = novac;
                        novac = izlazak(novac);
                        if (novactest != novac)
                            zabava = zabava + 5;

                        sansica = procenat.Next(11);
                        if (mesto == 1 && sansica <= 5)
                            zabava = KucaPas(zabava);

                        sansica = procenat.Next(11);
                        if (mesto == 2 && sansica <= 5)
                            zabava = StanBurgija(zabava);

                        sansica = procenat.Next(11);
                        if (mesto == 3 && sansica <= 5)
                            zabava = Dom(zabava);

                        if (mesto == 3 && sansica <= 5)
                        {
                            ke = DomZurka(ke);
                            if (ke == 1)
                            {
                                novac = novac - 300;
                                zabava = zabava + 10;
                            }
                            else
                                zabava = zabava + 5;
                        }


                        sansica = procenat.Next(11);
                        if (mesto == 1 || mesto == 2 && sansica <= 3)
                        {
                            sudoper = sudopera(sudoper);
                            if (sudoper == 1)
                            {
                                novac = novac - 1000;

                            }
                            if (sudoper == 2)
                            {

                                sansica = procenat.Next(11);
                                if (sansica <= 6)
                                {
                                    Console.WriteLine("\n\nUspeo si sam da je popravis!");

                                }
                                else
                                {
                                    Console.WriteLine("\n\nNisi uspeo sam da je popravis i pozvao si majstora");
                                    novac = novac - 1500;
                                    zabava = zabava - 10;
                                }
                            }

                            if (sudoper == 3)
                            {
                                Console.WriteLine("\n\nOstavio si sudoperu takvu kakva je i ne mozes vise da peres sudje.");
                                zabava = zabava - 15;

                            }

                        }

                        sansica = procenat.Next(11);
                        if (sansica < 3 && indikator == 1)
                            novac = exclusive(novac, indikator);
                        if (novac > 1000000)
                            i = 13;

                        Console.WriteLine("Da predjete u sledeci mesec, pritisnite ENTER!");
                        Console.ReadLine();

                        break;



                        case 5:
                        Console.Clear();
                        Console.WriteLine(meseci[i]);
                            i++;
                        novac = novac + doprinos;


                        zabava = LimitZabavu(zabava, 0, 100);
                        if (zabava == 0)
                        {
                            novac = GubitakNovca(novac);
                        }
                        novac = Troskovi(mesto, novac);
                        if (novac < 0)
                        {
                            i = 14;
                            break;
                        }
                        Console.WriteLine("Vasi resursi:\nNovac = " + novac + " dinara\nDoprinosi = " + doprinos + " dinara\nZabava = " + zabava);
                        zabavatest = zabava;
                        zabava = ucenje(zabava);
                        if (zabavatest != zabava)
                            ispit++;
                        Console.WriteLine("\n\nDosao je i taj period kad su ispiti napokon prosli i bez obzira na rezultat\nred je da izadjete i zaboravite na sve.");
                        Console.WriteLine("\n\nOkupili ste super drustvo i provodite se fenomenalno, ali od toga uvek moze bolje!\n1)Popij jos\n2)Dosta je i ovo");
                        int ekv = Convert.ToInt32(Console.ReadLine());
                        while (ekv < 1 || ekv > 2)
                        {
                            Console.WriteLine("\n\nMolimo unesite odgovarajuce parametre 1 ili 2");
                            ekv = Convert.ToInt32(Console.ReadLine());
                        }
                        if (ekv == 1 && pol == 1)
                        {
                            Console.WriteLine("\n\nPopili ste jos i poceli ste da se glupirate\nPrilazi vam namrgodjeni tip i unosi vam se u facu i psuje vam sve po spisku\n1)Udari ga\n2)Udari ga");
                            int uff = Convert.ToInt32(Console.ReadLine());
                            while (uff < 1 || uff > 2)
                            {
                                Console.WriteLine("\n\nMolimo unesite odgovarajuce parametre 1 ili 2");
                                uff = Convert.ToInt32(Console.ReadLine());
                            }
                            if (visina >= 195 && kilaza >= 115)
                            {
                                Console.WriteLine("\n\nUdarili ste ga i slomili ste mu sve kosti...nastavite dalje sa vasim zivotom dok se ne donese konacna presuda");
                                i = 15;
                            }
                            else
                            {
                                Console.WriteLine("\n\nUdarili ste ga i slomili ste mu nos, ali osecaj je bio dobar. Pobegli ste odatle i vratili se kuci.\nVasa zabava se povecala za 10");
                                zabava = zabava + 10;

                            }
                               

                        }
                        if (ekv == 1 && pol == 2)
                        {
                            Console.WriteLine("\n\nPoceli ste da se glupirate i prilazi vam tip i nudi vam se na jedno vece.\nDa li ste zainteresovani?\n1)Da!\n)2)Ne, fuj.");
                            int ufu = Convert.ToInt32(Console.ReadLine());
                            while (ufu < 1 || ufu > 2)
                            {
                                Console.WriteLine("\n\nMolimo unesite odgovarajuce parametre 1 ili 2");
                                ufu = Convert.ToInt32(Console.ReadLine());
                            }
                            if (ufu == 1)
                            {
                                Console.WriteLine("\n\nMomak s kojim ste bili na vece nije koristio zastitu i desila se nepredvidjena stvar.\nRezultate cete saznati tek krajem meseca.");
                                i = 16;
                            }
                            else
                            {
                                Console.WriteLine("\n\nMomak se izvinuo i presao je dalje na sledecu, vi ste nastavili da uzivate s drustvom sve dok niste dosli kuci i legli u krevet.\nZabava se povecala za 10");
                                zabava = zabava + 10;
                            }
                        
                        
                        }


                        

                        sansica = procenat.Next(11);
                        if (mesto == 1 && sansica <= 5)
                            zabava = KucaPas(zabava);

                        sansica = procenat.Next(11);
                        if (mesto == 2 && sansica <= 5)
                            zabava = StanBurgija(zabava);

                        sansica = procenat.Next(11);
                        if (mesto == 3 && sansica <= 5)
                            zabava = Dom(zabava);

                        if (mesto == 3 && sansica <= 5)
                        {
                            ke = DomZurka(ke);
                            if (ke == 1)
                            {
                                novac = novac - 300;
                                zabava = zabava + 10;
                            }
                            else
                                zabava = zabava + 5;
                        }


                        sansica = procenat.Next(11);
                        if (mesto == 1 || mesto == 2 && sansica <= 3)
                        {
                            sudoper = sudopera(sudoper);
                            if (sudoper == 1)
                            {
                                novac = novac - 1000;

                            }
                            if (sudoper == 2)
                            {

                                sansica = procenat.Next(11);
                                if (sansica <= 6)
                                {
                                    Console.WriteLine("\n\nUspeo si sam da je popravis!");

                                }
                                else
                                {
                                    Console.WriteLine("\n\nNisi uspeo sam da je popravis i pozvao si majstora");
                                    novac = novac - 1500;
                                    zabava = zabava - 10;
                                }
                            }

                            if (sudoper == 3)
                            {
                                Console.WriteLine("\n\nOstavio si sudoperu takvu kakva je i ne mozes vise da peres sudje.");
                                zabava = zabava - 15;

                            }

                        }

                        sansica = procenat.Next(11);
                        if (sansica < 3 && indikator == 1)
                            novac = exclusive(novac, indikator);
                        if (novac > 1000000)
                            i = 13;


                        Console.WriteLine("Da predjete u sledeci mesec, pritisnite ENTER!");
                        Console.ReadLine();
                        break;



                        case 6:                                                                             
                        Console.Clear();
                        Console.WriteLine(meseci[i]);
                            i++;
                        novac = novac + doprinos;


                        zabava = LimitZabavu(zabava, 0, 100);
                        if (zabava == 0)
                        {
                            novac = GubitakNovca(novac);
                        }
                        novac = Troskovi(mesto, novac);
                        if (novac < 0)
                        {
                            i = 14;
                            break;
                        }
                        Console.WriteLine("Vasi resursi:\nNovac = " + novac + " dinara\nDoprinosi = " + doprinos + " dinara\nZabava = " + zabava);
                        zabavatest = zabava;
                        zabava = ucenje(zabava);
                        if (zabavatest != zabava)
                            ispit++;

                        novactest = novac;
                        novac = izlazak(novac);
                        if (novactest != novac)
                            zabava = zabava + 5;

                        Console.WriteLine("\n\nNakon par meseci ponovo vam prilazi devojka koja vam je nudila posao da delite flajere, da li zelite da prihvatite taj posao?\n1)Da\n2)Ne");
                        int qwe = Convert.ToInt32(Console.ReadLine());
                        while (qwe < 1 || qwe > 2)
                        {
                            Console.WriteLine("Molimo unesite odgovarajuce parametre 1 ili 2");
                            qwe = Convert.ToInt32(Console.ReadLine());
                        }
                        if (qwe == 1)
                        {
                            if (ispit >= 5)
                            {
                                Console.WriteLine("\n\nProfesori koji su vas primetili na ulici prepoznaju vas trud, prilaze vam i nude vam posao u jednoj firmi.\nDa li prihvatate?\n1)Da\n2)Ne");
                                int ufc = Convert.ToInt32(Console.ReadLine());
                                while (ufc < 1 || ufc > 2)
                                {
                                    Console.WriteLine("\n\nMolimo unesite parametre 1 ili 2");
                                    ufc = Convert.ToInt32(Console.ReadLine());

                                }
                                if (ufc == 1)
                                {
                                    Console.WriteLine("\n\nPrihvatili ste posao i pocinjete da radite!");
                                    doprinos = doprinos + 5000;
                                }
                                else
                                    Console.WriteLine("\n\nOdbili ste ponudu za posao, ali barem imate vise slobodnog vremena!");
                            }
                            Console.WriteLine("\n\nPodelili ste sve flajere, ali vam je trebalo mnogo vremena tako da gubite 15 zabave, ali barem dobijate 2000 dinara");
                            zabava = zabava - 15;
                            novac = novac + 2000;


                        }
                        else
                            Console.WriteLine("\n\nOdbili ste ponudu za posao, ali barem imate vise slobodnog vremena!");

                        sansica = procenat.Next(11);
                        if (mesto == 1 && sansica <= 5)
                            zabava = KucaPas(zabava);

                        sansica = procenat.Next(11);
                        if (mesto == 2 && sansica <= 5)
                            zabava = StanBurgija(zabava);

                        sansica = procenat.Next(11);
                        if (mesto == 3 && sansica <= 5)
                            zabava = Dom(zabava);

                        if (mesto == 3 && sansica <= 5)
                        {
                            ke = DomZurka(ke);
                            if (ke == 1)
                            {
                                novac = novac - 300;
                                zabava = zabava + 10;
                            }
                            else
                                zabava = zabava + 5;
                        }


                        sansica = procenat.Next(11);
                        if (mesto == 1 || mesto == 2 && sansica <= 3)
                        {
                            sudoper = sudopera(sudoper);
                            if (sudoper == 1)
                            {
                                novac = novac - 1000;

                            }
                            if (sudoper == 2)
                            {

                                sansica = procenat.Next(11);
                                if (sansica <= 6)
                                {
                                    Console.WriteLine("\n\nUspeo si sam da je popravis!");

                                }
                                else
                                {
                                    Console.WriteLine("\n\nNisi uspeo sam da je popravis i pozvao si majstora");
                                    novac = novac - 1500;
                                    zabava = zabava - 10;
                                }
                            }

                            if (sudoper == 3)
                            {
                                Console.WriteLine("\n\nOstavio si sudoperu takvu kakva je i ne mozes vise da peres sudje.");
                                zabava = zabava - 15;

                            }

                        }

                        sansica = procenat.Next(11);
                        if (sansica < 3 && indikator == 1)
                            novac = exclusive(novac, indikator);
                        if (novac > 1000000)
                            i = 13;

                        Console.WriteLine("Da predjete u sledeci mesec, pritisnite ENTER!");
                        Console.ReadLine();
                        break;



                        case 7:
                        Console.Clear();
                        Console.WriteLine(meseci[i]);
                            i++;
                        novac = novac + doprinos;

                        zabava = LimitZabavu(zabava, 0, 100);
                        if (zabava == 0)
                        {
                            novac = GubitakNovca(novac);
                        }
                        novac = Troskovi(mesto, novac);
                        if (novac < 0)
                        {
                            i = 14;
                            break;
                        }
                        Console.WriteLine("Vasi resursi:\nNovac = " + novac + " dinara\nDoprinosi = " + doprinos + " dinara\nZabava = " + zabava);
                        zabavatest = zabava;
                        zabava = ucenje(zabava);
                        if (zabavatest != zabava)
                            ispit++;

                        
                            Console.WriteLine("Kako se priblizava kraj godine, a bome i pocetak leta, na vama je da odlucite da li zelite da idete u teretanu da se dovedete u red\n1)Oticu\n2)Necu otici");
                            int teretana = Convert.ToInt32(Console.ReadLine());
                            while (teretana < 1 || teretana > 2)
                        {
                            Console.WriteLine("Molimo unesite podrazumevane vrednosti 1 ili 2");
                                teretana = Convert.ToInt32(Console.ReadLine());
                        }
                        if (teretana == 1)
                        {
                            Console.WriteLine("\n\nOdlucili ste da idete i to ce vas kostati 400 dinara mesecno");
                            doprinos = doprinos - 400;
                        }
                        else
                            Console.WriteLine("\n\nOdlucili ste ipak da je bolje da ostanete kuci jer ipak izgledate fenomenalno!");
                       

                        novactest = novac;
                        novac = izlazak(novac);
                        if (novactest != novac)
                            zabava = zabava + 5;

                        sansica = procenat.Next(11);
                        if (mesto == 1 && sansica <= 5)
                            zabava = KucaPas(zabava);

                        sansica = procenat.Next(11);
                        if (mesto == 2 && sansica <= 5)
                            zabava = StanBurgija(zabava);

                        sansica = procenat.Next(11);
                        if (mesto == 3 && sansica <= 5)
                            zabava = Dom(zabava);

                        if (mesto == 3 && sansica <= 5)
                        {
                            ke = DomZurka(ke);
                            if (ke == 1)
                            {
                                novac = novac - 300;
                                zabava = zabava + 10;
                            }
                            else
                                zabava = zabava + 5;
                        }


                        sansica = procenat.Next(11);
                        if (mesto == 1 || mesto == 2 && sansica <= 3)
                        {
                            sudoper = sudopera(sudoper);
                            if (sudoper == 1)
                            {
                                novac = novac - 1000;

                            }
                            if (sudoper == 2)
                            {

                                sansica = procenat.Next(11);
                                if (sansica <= 6)
                                {
                                    Console.WriteLine("\n\nUspeo si sam da je popravis!");

                                }
                                else
                                {
                                    Console.WriteLine("\n\nNisi uspeo sam da je popravis i pozvao si majstora");
                                    novac = novac - 1500;
                                    zabava = zabava - 10;
                                }
                            }

                            if (sudoper == 3)
                            {
                                Console.WriteLine("\n\nOstavio si sudoperu takvu kakva je i ne mozes vise da peres sudje.");
                                zabava = zabava - 15;

                            }

                        }

                        sansica = procenat.Next(11);
                        if (sansica < 3 && indikator == 1)
                            novac = exclusive(novac, indikator);
                        if (novac > 1000000)
                            i = 13;

                        Console.WriteLine("Da predjete u sledeci mesec, pritisnite ENTER!");
                        Console.ReadLine();
                        break;



                        case 8:
                        Console.Clear();
                        Console.WriteLine(meseci[i]);
                            i++;
                        novac = novac + doprinos;

                        zabava = LimitZabavu(zabava, 0, 100);
                        if (zabava == 0)
                        {
                            novac = GubitakNovca(novac);
                        }
                        novac = Troskovi(mesto, novac);
                        if (novac < 0)
                        {
                            i = 14;
                            break;
                        }
                        Console.WriteLine("Vasi resursi:\nNovac = " + novac + " dinara\nDoprinosi = " + doprinos + " dinara\nZabava = " + zabava);

                        Console.WriteLine("\n\nPonovo je doslo vreme ispita! Nadamo se da ste ucili dovoljno da prodjete svaki ispit");
                        if (ispit > 6)
                        {
                            Console.WriteLine("\n\nUcili ste dovoljno i dobijate nagradu od 1000 dinara mesecno koju mozete trositi na sta god zelite!");
                            doprinos = doprinos + 1000;
                        }
                        else
                        {
                            Console.WriteLine("\n\nNazalost niste dovoljno ucili i niste polozili ispite, a daleko od toga da se uspeli da zadrzite budzet.\nVise srece u narednoj godini. ");
                            i = 18;
                        }
                        if (i != 18)
                        {
                            zabavatest = zabava;
                            zabava = ucenje(zabava);
                            if (zabavatest != zabava)
                                ispit++;

                            novactest = novac;
                            novac = izlazak(novac);
                            if (novactest != novac)
                                zabava = zabava + 5;

                            sansica = procenat.Next(11);
                            if (mesto == 1 && sansica <= 5)
                                zabava = KucaPas(zabava);

                            sansica = procenat.Next(11);
                            if (mesto == 2 && sansica <= 5)
                                zabava = StanBurgija(zabava);

                            sansica = procenat.Next(11);
                            if (mesto == 3 && sansica <= 5)
                                zabava = Dom(zabava);

                            if (mesto == 3 && sansica <= 5)
                            {
                                ke = DomZurka(ke);
                                if (ke == 1)
                                {
                                    novac = novac - 300;
                                    zabava = zabava + 10;
                                }
                                else
                                    zabava = zabava + 5;
                            }


                            sansica = procenat.Next(11);
                            if (mesto == 1 || mesto == 2 && sansica <= 3)
                            {
                                sudoper = sudopera(sudoper);
                                if (sudoper == 1)
                                {
                                    novac = novac - 1000;

                                }
                                if (sudoper == 2)
                                {

                                    sansica = procenat.Next(11);
                                    if (sansica <= 6)
                                    {
                                        Console.WriteLine("\n\nUspeo si sam da je popravis!");

                                    }
                                    else
                                    {
                                        Console.WriteLine("\n\nNisi uspeo sam da je popravis i pozvao si majstora");
                                        novac = novac - 1500;
                                        zabava = zabava - 10;
                                    }
                                }

                                if (sudoper == 3)
                                {
                                    Console.WriteLine("\n\nOstavio si sudoperu takvu kakva je i ne mozes vise da peres sudje.");
                                    zabava = zabava - 15;

                                }

                            }

                            sansica = procenat.Next(11);
                            if (sansica < 3 && indikator == 1)
                                novac = exclusive(novac, indikator);
                            if (novac > 1000000)
                                i = 13;


                            Console.WriteLine("Da predjete u sledeci mesec, pritisnite ENTER!");
                            Console.ReadLine();
                        }
                        break;



                        case 9:
                        Console.Clear();
                        Console.WriteLine(meseci[i]);
                            i++;
                        novac = novac + doprinos;

                        zabava = LimitZabavu(zabava, 0, 100);
                        if (zabava == 0)
                        {
                            novac = GubitakNovca(novac);
                        }
                        novac = Troskovi(mesto, novac);
                        if (novac < 0)
                        {
                            i = 14;
                            break;
                        }
                        Console.WriteLine("Vasi resursi:\nNovac = " + novac + " dinara\nDoprinosi = " + doprinos + " dinara\nZabava = " + zabava);
                        Console.WriteLine("\n\nOvog meseca se nista posebno nece dogoditi");
                        zabavatest = zabava;
                        zabava = ucenje(zabava);
                        if (zabavatest != zabava)
                            ispit++;

                        novactest = novac;
                        novac = izlazak(novac);
                        if (novactest != novac)
                            zabava = zabava + 5;

                        sansica = procenat.Next(11);
                        if (mesto == 1 && sansica <= 5)
                            zabava = KucaPas(zabava);

                        sansica = procenat.Next(11);
                        if (mesto == 2 && sansica <= 5)
                            zabava = StanBurgija(zabava);

                        sansica = procenat.Next(11);
                        if (mesto == 3 && sansica <= 5)
                            zabava = Dom(zabava);

                        if (mesto == 3 && sansica <= 5)
                        {
                            ke = DomZurka(ke);
                            if (ke == 1)
                            {
                                novac = novac - 300;
                                zabava = zabava + 10;
                            }
                            else
                                zabava = zabava + 5;
                        }


                        sansica = procenat.Next(11);
                        if (mesto == 1 || mesto == 2 && sansica <= 3)
                        {
                            sudoper = sudopera(sudoper);
                            if (sudoper == 1)
                            {
                                novac = novac - 1000;

                            }
                            if (sudoper == 2)
                            {

                                sansica = procenat.Next(11);
                                if (sansica <= 6)
                                {
                                    Console.WriteLine("\n\nUspeo si sam da je popravis!");

                                }
                                else
                                {
                                    Console.WriteLine("\n\nNisi uspeo sam da je popravis i pozvao si majstora");
                                    novac = novac - 1500;
                                    zabava = zabava - 10;
                                }
                            }

                            if (sudoper == 3)
                            {
                                Console.WriteLine("\n\nOstavio si sudoperu takvu kakva je i ne mozes vise da peres sudje.");
                                zabava = zabava - 15;

                            }

                        }

                        sansica = procenat.Next(11);
                        if (sansica < 3 && indikator == 1)
                            novac = exclusive(novac, indikator);
                        if (novac > 1000000)
                            i = 13;

                        Console.WriteLine("Da predjete u sledeci mesec, pritisnite ENTER!");
                        Console.ReadLine();
                        break;

                       

                        case 10:
                        Console.Clear();
                        Console.WriteLine(meseci[i]);
                            i++;
                        novac = novac + doprinos;

                        zabava = LimitZabavu(zabava, 0, 100);
                        if (zabava == 0)
                        {
                            novac = GubitakNovca(novac);
                        }
                        novac = Troskovi(mesto, novac);
                        if (novac < 0)
                        {
                            i = 14;
                            break;
                        }
                        Console.WriteLine("Vasi resursi:\nNovac = " + novac + " dinara\nDoprinosi = " + doprinos + " dinara\nZabava = " + zabava);

                        Console.WriteLine("\n\nKako se mirno setate ulicom, prilazi vam covek koji vas moli da mu pomognete, \nali ne zeli da kaze u cemu je problem vec vas hvata za rukav i vuce vas u jednom smeru.");
                        Console.WriteLine("1)Otrgni ruku i pobegni\n2)Dozvoli da vas covek odvede u nepoznato");
                        int tuba = Convert.ToInt32(Console.ReadLine());
                        while (tuba < 1 || tuba > 2 )
                        {
                            Console.WriteLine("Molimo unesite podrazumevane vrednosti 1 ili 2");
                            tuba = Convert.ToInt32(Console.ReadLine());
                        }
                        if (tuba == 1)
                            Console.WriteLine("Otrgnuli ste ruku i uspeli ste da pobegnete bez problema i nikad vise niste sreli tog coveka");
                        else
                        {
                            Console.WriteLine("Covek vas odvodi u slepu ulicu i preti vam da ce vas ubiti ukoliko mu ne date sav svoj novac\n1)Daj mu sav novac\n2)Ne daj mu nista u nadi da ce da ode");
                             tamdam = Convert.ToInt32(Console.ReadLine());
                            while (tamdam < 1 || tamdam > 2)
                            {
                                Console.WriteLine("Molimo unesite podrazumevane vrednosti 1 ili 2");
                                tamdam = Convert.ToInt32(Console.ReadLine());
                            }
                            if (tamdam == 1)
                            {
                                novac = 0;
                                i = 14;
                                break;
                            }
                            else
                            {
                                i = 17;
                                break;
                            }
                        }


                        if (tuba == 1)
                        {
                            zabavatest = zabava;
                            zabava = ucenje(zabava);
                            if (zabavatest != zabava)
                                ispit++;

                            novactest = novac;
                            novac = izlazak(novac);
                            if (novactest != novac)
                                zabava = zabava + 5;

                            sansica = procenat.Next(11);
                            if (mesto == 1 && sansica <= 5)
                                zabava = KucaPas(zabava);

                            sansica = procenat.Next(11);
                            if (mesto == 2 && sansica <= 5)
                                zabava = StanBurgija(zabava);

                            sansica = procenat.Next(11);
                            if (mesto == 3 && sansica <= 5)
                                zabava = Dom(zabava);

                            if (mesto == 3 && sansica <= 5)
                            {
                                ke = DomZurka(ke);
                                if (ke == 1)
                                {
                                    novac = novac - 300;
                                    zabava = zabava + 10;
                                }
                                else
                                    zabava = zabava + 5;
                            }


                            sansica = procenat.Next(11);
                            if (mesto == 1 || mesto == 2 && sansica <= 5)
                            {
                                sudoper = sudopera(sudoper);
                                if (sudoper == 1)
                                {
                                    novac = novac - 1000;

                                }
                                if (sudoper == 2)
                                {

                                    sansica = procenat.Next(11);
                                    if (sansica <= 6)
                                    {
                                        Console.WriteLine("\n\nUspeo si sam da je popravis!");

                                    }
                                    else
                                    {
                                        Console.WriteLine("\n\nNisi uspeo sam da je popravis i pozvao si majstora");
                                        novac = novac - 1500;
                                        zabava = zabava - 10;
                                    }
                                }

                                if (sudoper == 3)
                                {
                                    Console.WriteLine("\n\nOstavio si sudoperu takvu kakva je i ne mozes vise da peres sudje.");
                                    zabava = zabava - 15;

                                }

                            }

                            sansica = procenat.Next(11);
                            if (sansica < 3 && indikator == 1)
                                novac = exclusive(novac, indikator);
                            if (novac > 1000000)
                                i = 13;


                            Console.WriteLine("Da predjete u sledeci mesec, pritisnite ENTER!");
                            Console.ReadLine();
                        }
                        break;



                        case 11:
                        Console.Clear();
                        Console.WriteLine(meseci[i]);
                            i++;
                        novac = novac + doprinos;

                        zabava = LimitZabavu(zabava, 0, 100);
                        if (zabava == 0)
                        {
                            novac = GubitakNovca(novac);
                        }
                        novac = Troskovi(mesto, novac);
                        if (novac < 0)
                        {
                            i = 14;
                            break;
                        }
                        Console.WriteLine("Vasi resursi:\nNovac = " + novac + " dinara\nDoprinosi = " + doprinos + " dinara\nZabava = " + zabava);

                        zabavatest = zabava;
                        zabava = ucenje(zabava);
                        if (zabavatest != zabava)
                            ispit++;

                        novactest = novac;
                        novac = izlazak(novac);
                        if (novactest != novac)
                            zabava = zabava + 5;

                        Console.WriteLine("Dosli ste na sam kraj godine i vreme je da se pozdravite sa svima.\nSvaka vam cast sto ste ovoliko dugo izdrzali, zbog toga sto ste dosli do kraja,\nKao nagradu dobijate 5000 dinara!\nBilo je vreme da se malo odmorite!");
                        novac = novac + 5000;

                        sansica = procenat.Next(11);
                        if (mesto == 1 && sansica <= 5)
                            zabava = KucaPas(zabava);

                        sansica = procenat.Next(11);
                        if (mesto == 2 && sansica <= 5)
                            zabava = StanBurgija(zabava);

                        sansica = procenat.Next(11);
                        if (mesto == 3 && sansica <= 5)
                            zabava = Dom(zabava);

                        if (mesto == 3 && sansica <= 5)
                        {
                            ke = DomZurka(ke);
                            if (ke == 1)
                            {
                                novac = novac - 300;
                                zabava = zabava + 10;
                            }
                            else
                                zabava = zabava + 5;
                        }


                        sansica = procenat.Next(11);
                        if (mesto == 1 || mesto == 2 && sansica <= 3)
                        {
                            sudoper = sudopera(sudoper);
                            if (sudoper == 1)
                            {
                                novac = novac - 1000;

                            }
                            if (sudoper == 2)
                            {

                                sansica = procenat.Next(11);
                                if (sansica <= 6)
                                {
                                    Console.WriteLine("\n\nUspeo si sam da je popravis!");

                                }
                                else
                                {
                                    Console.WriteLine("\n\nNisi uspeo sam da je popravis i pozvao si majstora");
                                    novac = novac - 1500;
                                    zabava = zabava - 10;
                                }
                            }

                            if (sudoper == 3)
                            {
                                Console.WriteLine("\n\nOstavio si sudoperu takvu kakva je i ne mozes vise da peres sudje.");
                                zabava = zabava - 15;

                            }

                        }

                        sansica = procenat.Next(11);
                        if (sansica < 3 && indikator == 1)
                            novac = exclusive(novac, indikator);
                        if (novac > 1000000)
                            i = 13;


                        Console.WriteLine("Da zavrsite igricu, pritisnite ENTER!");
                        Console.ReadLine();
                        break;




                }



            }


            switch (i)
            {
                case (12):
                    Console.WriteLine("\nSvaka cast!\nZavrsili ste igru tako sto ste uspeli da sacuvate dovoljno novca i niste pali godinu!");
                    break;
                case (13):
                    Console.WriteLine("\nSvaka cast!\nPobedili ste igru na tajnni nacin!");
                    break;
                case (14):
                    Console.WriteLine("\nNazalost izgubili ste jer vam je ponestalo novca");
                    break;
                case (15):
                    Console.WriteLine("\nNazalost izgubili ste jer ste zavrsili u zatvoru");
                    break;
                case (16):
                    Console.WriteLine("\nNazalost izgubili ste igricu jer ste trudni");
                    break;
                case (17):
                    Console.WriteLine("\nNazalost izgubili ste igricu jer ste preminuli");
                    break;
                case (18):
                    Console.WriteLine("\nNazalost izgubili ste igricu jer ste pali godinu");
                    break;

                    
                    int ocena = 0;
                    do
                    {
                        try
                        {
                            Console.WriteLine("\n\nOcenite ovu igru od 1 do 10");
                            ocena = Convert.ToInt32(Console.ReadLine());

                            if (ocena < 1 || ocena > 10)
                                throw new IndexOutOfRangeException();
                            else break;



                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Greska! Unesite vrednosti od 1 do 10!");
                        }
                    }
                    while (true);

            }
        }
    }
}
    

