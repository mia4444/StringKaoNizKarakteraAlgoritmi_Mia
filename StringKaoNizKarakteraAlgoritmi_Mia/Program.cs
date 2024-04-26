using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StringKaoNizKarakteraAlgoritmi_Mia
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            //Algoritam 1
            //Kreirati algoritam sa pseudokodom koji prebrojava karaktere zadatog stringa(ne brojeći terminacioni karakter)
            Console.WriteLine("Unesite Vaše ime i prezime:");
            string imePrezime=Console.ReadLine();
            //string[] imePrezime = new string[50];//kreiramo niz karaktera, tj string i ogranicavamo ga na worst-case-scenario, odnosno 50
            
            //char karakter= imePrezime[i];
            //recimo da ocekujemo da se unese necije ime i prezime
            int length = imePrezime.Length;//recimo da smo ovo stavili na 50
           // length = 50;
           // int i = 0;
            int count = 0;//count tj brojac postavljam na 0, jer je 0 neutralna za aritmeticku operaciju sabiranja
             
            for (int i=0; i<length && i!= ' '; i++){ //nula ili terminacioni karakter se ne navodi eksplicitno u kodu

                //i++;
                count++;
            }

            Console.WriteLine("Broj karaktera je "+count);//on meni ovde broji i space
            Console.ReadLine();


            //Algoritam 1-A
            //Prebrojava ODREĐENI karakter u stringu, prekopiracu inicijalni kod i dodati neke linije 

            Console.WriteLine("Unesite Vaše ime i prezime:");
            string nameSurname = Console.ReadLine();
            //string[] imePrezime = new string[50];//kreiramo niz karaktera, tj string i ogranicavamo ga na worst-case-scenario, odnosno 50

            Console.WriteLine("Unesite karakter koji želite prebrojati:");
            char charKojiBrojim = Console.ReadLine()[0];

            //recimo da ocekujemo da se unese necije ime i prezime
            int len = nameSurname.Length;//recimo da smo ovo stavili na 50
                                           // length = 50;
                                           // int i = 0;
            int broj = 0;//count tj brojac postavljam na 0, jer je 0 neutralna za aritmeticku operaciju sabiranja

            for (int j = 0; j < len; j++)
            { //nula ili terminacioni karakter se ne navodi eksplicitno u kodu

                if (nameSurname[j] == charKojiBrojim) { 
                //i++;
                broj++;
                }           
                
            }

            Console.WriteLine("Broj karaktera je " + broj);
            Console.ReadLine();

            //Algoritam 1-B
            /*Za vežbu ili domaći napisati algoritam koji “meri” dužine dva
            zadata stringa i štampa niz koji je duži. Ako su nizovi istih
            dužina štampa prvi zadati niz.*/


            //Algoritam 2
            //Replace lowercase with uppercase chars

            string tekstLow;//input se čuva u ovoj promenljivoj
            char[] niz1;
            int l, m;//l oznacava prvo slovo reci length, to jest duzinu naseg inputovanog niza
            l = 0;
           // char ch;

            Console.WriteLine("Aplikacija za zamenu lowercase karaktera, uppercase verzijom istih.\n");
            Console.WriteLine("Unesite tekst na kom želite da primenite funkciju aplikacije");
            tekstLow = Console.ReadLine();//uneti input u konzoli se cuva u ovoj promenljivoj
            l = tekstLow.Length;
            niz1 = tekstLow.ToCharArray(0,1);


            Console.WriteLine("Nakon konverzije, string će izgledati ovako: ");

            /*for (m=0;m<l;m++)
            {
                ch = niz1[m];

                if (Char.IsLower(ch))//u slucaju da je karakter lowercase
                {//true

                    niz1[m] = Char.ToUpper(ch);
                    Console.Write(Char.ToUpper(ch));//ako je lowercase, pretvori ga u upper
                }
                else { //false

                    niz1[m] = Char.ToLower(ch);
                    Console.Write(Char.ToLower(ch));//ELSE ako je uppercase, pretvori ga u lower

                }
                Console.Write(niz1[m]);
            }
            Console.ReadLine();*/

            foreach (char ch in tekstLow)
            {
                if (char.IsLower(ch))
                {
                    Console.Write(char.ToUpper(ch));
                }
                else if (char.IsUpper(ch))
                {
                    Console.Write(char.ToLower(ch));
                }
                else
                {
                    Console.Write(ch); // Preserve non-alphabetic characters
                }
            }

            Console.ReadLine();


            //Algoritam 3-Koji niz je leksikografski veći?

            //char[] prviString = new char[50];
            //char[] drugiString = new char[50];
            /*
            Console.WriteLine("Unesi prvi string.");
            string prviString =Console.ReadLine();
            Console.WriteLine("Unesi drugi string.");
            string drugiString = Console.ReadLine();

            int A = 0;


            //while (prviString[A] < prviString.Length && drugiString[A] < drugiString.Length && prviString[A] == drugiString[A] && prviString[A]!= '\0'&& drugiString[A] != '\0') 
            while (prviString[A] < prviString.Length && drugiString[A] < drugiString.Length &&  prviString[A] == drugiString[A] && prviString[A]!= "\0")
            {
                
                A++;
            
            }

            //U momentu kad im elementi vise nisu jednaki
            if (prviString[A] > drugiString[A]) {

                Console.WriteLine("Veći je prvi niz.");

            } else if(prviString[A] < drugiString[A]) {

                Console.WriteLine("Veći je drugi niz.");

            } else 
            {

                Console.WriteLine("Nizovi su jednaki.");

            }

           Console.ReadLine();*/

            //Algoritam 3-resenje sa interneta

            Console.WriteLine("Unesi prvi string.");
            string prviString = Console.ReadLine();
            Console.WriteLine("Unesi drugi string.");
            string drugiString = Console.ReadLine();

            int minLength = Math.Min(prviString.Length, drugiString.Length);
            int A = 0;

            while (A < minLength && prviString[A] == drugiString[A])
            {
                A++;
            }

            if (A == minLength)
            {
                if (prviString.Length == drugiString.Length)
                {
                    Console.WriteLine("Nizovi su jednaki.");
                }
                else if (prviString.Length > drugiString.Length)
                {
                    Console.WriteLine("Veći je prvi niz.");
                }
                else
                {
                    Console.WriteLine("Veći je drugi niz.");
                }
            }
            else if (prviString[A] > drugiString[A])
            {
                Console.WriteLine("Veći je prvi niz.");
            }
            else
            {
                Console.WriteLine("Veći je drugi niz.");
            }

            Console.ReadLine();




            //POKUŠAJ: Algoritam 4-Eliminise pojavu karaktera
            //String je immutable, te se ne moze menjati in-place
            /* string str = "Mia Nedeljković";

             Console.WriteLine(remove_char(str, 1));
             Console.ReadKey();

             //string []abcd = new string[50];
             string abcd;
             char kar;
             int M, N;

             Console.WriteLine("Unesite vrednost stringa:");      
             abcd = Console.ReadLine();

             Console.WriteLine("Unesite vrednost karaktera:");
             kar = Convert.ToChar(Console.ReadLine());

             M = 1;
             N = 1;

             while (M<abcd.Length) {

                 if (abcd[M]!=kar) {
                     abcd[N] = abcd[M];
                     N++;
                 }
                 M++;
             }

             N= V;
             Console.WriteLine(abcd);*/

            //REŠENJE SA NETA-Algoritam 4
            string str;
            char kar;

            Console.WriteLine("Unesite vrednost stringa:");
            str = Console.ReadLine();

            Console.WriteLine("Unesite vrednost karaktera:");
            kar = Convert.ToChar(Console.ReadLine());

            string modifiedString = RemoveChar(str, kar);

            Console.WriteLine(modifiedString);

            //Algoritam 4-A:dupliranje

            string mojString;
            char mojKarakter;

            Console.WriteLine("Unesite vrednost stringa:");
            mojString = Console.ReadLine();

            Console.WriteLine("Unesite vrednost karaktera:");
            mojKarakter = Convert.ToChar(Console.ReadLine());

            string dupliraniString = DuplicateChar(mojString, mojKarakter);

            Console.WriteLine(dupliraniString);


            //Algoritam 4-B: Napisati algoritam koji daje kao rezultat poziciju gde se prvi put pojavio zadati karakter.
            //Ovaj postupak znaci i za podstring kasnije, jer nakon prvog karaktera, nalazimo jos neke neophodne

            string moj_string;
            int charIndex;//samo ovaj deklarisem

            Console.WriteLine("Unesite vrednost stringa:");
            moj_string = Console.ReadLine();

            Console.WriteLine("Unesite vrednost karaktera:");
            charIndex =(Console.ReadLine())[0];//citaj karakter direktno umesto parsiranja

            int pozicija = FindCharPosition(moj_string,charIndex);

            if (pozicija != -1)
            {
                Console.WriteLine("Pozicija " + pozicija + " je pronadjena.");
            }
            else { 
            
                Console.WriteLine("Karakter nije pronadjen.");

            }




            //Algoritam 4-c:Nadji podstring u stringu-kao 5. algoritam
            /*Algoritam 5: Zadaje se string S i dva cela broja I i J. Treba formirati drugi
            string koji se sastoji od karaktera stringa S koji se nalaze od
            pozicije I do pozicije J.*/

            //poz1 (i) i poz2(j) su pozicije/indeksi koje ce se koristiti kao granicne vrednosti

            Console.WriteLine("Unesite glavni string.");//korisnik unosi
            string glavniString = Console.ReadLine();//cita se sa konzole

            Console.WriteLine("Unesite sporedni string.");
            string sporedniString = Console.ReadLine();

            int myIndex = FindSporedni(glavniString, sporedniString);

            if (myIndex != -1)
            {
                Console.WriteLine("Sporedni string " + sporedniString + " je pronadjen na indexu " + myIndex);

            }
            else {

                Console.WriteLine("Sporedni string nije pronadjen u vecem stringu.");
            }




        } //kraj Main-a

    //public static string remove_char(string str, int n) {

           // return str.Remove(n, 1);

        //Funkcija za algoritam 4: uklanja karakter po želji
            static string RemoveChar(string str, char charToRemove)
            {
                string result = "";
                foreach (char c in str)
                {
                    if (c != charToRemove)
                    {
                        result += c;
                    }
                }
                return result;
            }

        //Algoritam 4-A: dupliranje karaktera u stringu
        //U suštini se jednino sama funkcija menja, pa se poziva u Main-u i prima appropriate argumente na mestu parametara nad kojima će da "operiše"
        static string DuplicateChar(string mojString, char charToDuplicate)
        {
            string result = "";
            foreach (char c in mojString)
            {
                result += c;
                if (c == charToDuplicate)
                {
                    result+=c;
                }
            }
            return result;
        }

        //Algoritam 4-B: nađi poziciju karaktera u stringu

        static int FindCharPosition(string moj_string, int charIndex)
            {

              
                for (int index=0; index< moj_string.Length;index++) { 
                
                    if (moj_string[index] == charIndex)
                    {
                        return index;
                    }
                } 
            
            return -1;//nije pronadjen karakter
                }


            static int FindSporedni(string glavniString, string sporedniString)
        {

            int glDuzina = glavniString.Length;
            int sporDuzina = sporedniString.Length;

            for (int poz1=0; poz1<= glDuzina-sporDuzina; poz1++) {

                int poz2;
                for (poz2=0;poz2<sporDuzina;poz2++) {

                    if (glavniString[poz1+poz2] != sporedniString[poz2]) {

                        break;
                    }
                
                }

                if (poz2==sporDuzina) {
                    return poz1;//pronasli smo sporedni string
                }
            }
            return -1;
        }
        
               
            }
    }







