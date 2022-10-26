using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple_cours
{
//défénition de la classe person

    public class Person
    {
        //déclaration des attributs
        private string nom;
        private string prenom;

        private string ville;

        //déclaration des propriétés

        public string Nom
         { 
          get { return nom; }
          set { nom = value; }
         
        }
      
      //constructeur sans paramètre de la classe personne
      public Person()
        {
         Console.WriteLine("création d'une nouvelle personne");
        }

        //constructeur avec 2 paramètre - surcharge le constructeur
        public Person(string p_nom, string p_prenom)
        {
        Console.WriteLine("création d'une nouvelle personne qui se nomme" + " "+ p_prenom+ " " +p_nom);
        }

        //Constructeur avec 3 paramètre - surcharger le constructeur
        public Person(string p_nom, string p_prenom,string p_ville)
        {
            this.nom = p_nom;
            this.prenom = p_prenom;
            this.ville = p_ville;
            Console.WriteLine("création d'une nouvelle personne qui se nomme" + " " + p_prenom + " " + p_nom +
                " et qui habite à " +p_ville );
        }
        //déstructeur de la classe person
        ~Person()
        {
            Console.WriteLine("Destruction d'un objet de la classe person");
            Console.ReadKey();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //déclaration de la référence
            Person Simon;
            // instanciation
            Simon = new Person();

            // déclaration et instanciation
            Person Mathis = new Person();
           


           //déclaration et instanciation avec paramètre
           Person Patrick = new Person("Bolduc","Patrick");
          
            //déclaration et instanciation avec paramètre
            Person isabelle = new Person("dubois", "isabelle", "Val-des-Monts");
            
            //propriété nom
            Console.WriteLine(isabelle.Nom);
            // propriété nom, setter
            isabelle.Nom = "Gauthier";
            Console.WriteLine(isabelle.Nom);
            Console.ReadLine();
        }
    }
}
