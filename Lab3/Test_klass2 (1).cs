using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativgöraom
{
    class Test_klass2
    {
        /// <summary>
        /// Testar så att ValidatePassword egenskapen I klassen Validate fungerar.
        /// </summary>
        public static void TestValidate()
        {
            var validator = new Validate("hej", "123");
            var user = new User("hej", "123");

            try
            {
                Console.WriteLine(validator.ValidatePassword(user));
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            user.PassWord = "lambo";
        }

        public string ValidatePassword(User a)
        {
            if (_userName == a.Username && _password == a.PassWord)
            {
                return "Korrekta inloggningsuppgifter.";
            }
            else
            {
                throw new ArgumentException("Ej korrekt");
            }
        }
    }
}