using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativgöraom
{
        class Test_klass
    {
        /// <summary>
        /// Testar så att det går att sätta ett lösenord som är inom den korrekta längden
        /// </summary>
        public static void TestPasswordCorrect()
        {
            var pass = new Validate();
            try
            {
                pass.Password = "aaaaa";
            }
            catch
            {
                Console.WriteLine("Lösenordet har rätt längd");
            }
        }
        /// <summary>
        /// Testar så att det ej går att mata in längre lösenord än 12 tecken.
        /// </summary>
        public static void TestPasswordIncorrect()
        {
            var pass = new Validate();
            try
            {
            pass.Password = "aaaaaaaaaaaaa";
            }
            catch(ArgumentOutOfRangeException error)
            {
                Console.WriteLine(error.Message);
            }
        }
        /// <summary>
        /// Testar så att det blir korrekt om användaren matar in rätt längd på användarnamnet.
        /// </summary>
        public static void TestUsernameCorrect()
        {
            var use = new Validate();
            try
            {
                use.Usename = "aaaaaaaaaaaaaaaaaa";
            }
            catch ()
            {
                Console.WriteLine("Användarnamnet har en godkänd längd.");
            }
        }
        /// <summary>
        /// Testar så att det ej går att mata in ett användarnamn än som är förbjudet.
        /// </summary>
        public static void TestUsernameIncorrect()
        {
            var use = new Validate();
            try
            {
                use.Usename = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            }
            catch(ArgumentOutOfRangeException error2)
            {
                Console.WriteLine(error2.Message);
            }
        }
    }
}
