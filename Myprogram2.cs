using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {

            //Isnullorwhitespace
            string firstName = "Vennu";
            string lastName = "gopal";
            string fullName = String.Concat(" "+ firstName,lastName+" ");
            bool data = String.IsNullOrEmpty(fullName);
            Console.WriteLine(data);




            //StringIndexof
             string firstname = "nithish";
             string lastname = "karthi";
             Console.WriteLine(firstname.IndexOf('t'));



            // Substring method
            string name = "spain";
            string laname = "very";
            Console.WriteLine(name.Substring(3));



            //String.trim
             string firstName = "Manikandan";
             string lastName = "k";
             string fullName = String.Concat(" "+ firstName,lastName + " ");
             Console.WriteLine(fullName.Trim());
