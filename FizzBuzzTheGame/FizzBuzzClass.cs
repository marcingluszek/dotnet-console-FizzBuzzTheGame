using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTheGame
{
    class FizzBuzzClass
    {
        public int UserNum;

        public string FizzBuzz()
        {
            /*
                -Jeżeli liczba użytkownika będzie podzielna przez 3 bez reszty, to powinien zostać zwrócony wynik „Fizz”.
                -Jeżeli liczba użytkownika będzie podzielna przez 5 bez reszty, to powinien zostać zwrócony wynik „Buzz”.
                -Jeżeli liczba użytkownika będzie podzielna przez 3 i przez 5 jednocześnie bez reszty, to powinien zostać zwrócony wynik „FizzBuzz”.
                -Jeżeli liczba użytkownika nie będzie podzielna przez 3 ani przez 5 bez reszty, to wtedy zwracasz podaną liczbę.
            */

            if(UserNum % 3 == 0 && UserNum % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (UserNum % 3 == 0)
            {
                return "Fizz";
            }
            else if (UserNum % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return UserNum.ToString();
            }

        }
        
        
        


    }
}
