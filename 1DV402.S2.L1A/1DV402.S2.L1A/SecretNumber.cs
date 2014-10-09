using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    class SecretNumber
    {

        private int _count;
        private int _number;
        public const int MaxNumberOfGuesses = 7;
        
       public SecretNumber(){
           Random rnd = new Random();
           _number = rnd.Next(1, 101);
           
    }

        public void Initialize()
        {
            
            _count = 0;


        }
        public bool MakeGuess(int number)
        {
            if (_count >= MaxNumberOfGuesses)
            {
                throw new ApplicationException();
            }

            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException();
            }
            _count++;

            
            if (number == _number)
            {
                Console.WriteLine("RÄTT GISSAT. Du klarade det på {0} försök.", _count);
                return true;
            }
            else if (number > _number)
            {
                Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar.", number, MaxNumberOfGuesses - _count);
            }
            else if (number < _number)
            {
                Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar.", number, MaxNumberOfGuesses - _count);
            }
            if (MaxNumberOfGuesses == _count)
            {
                Console.WriteLine("Det hemliga talet är {0} ", _number);
            }
            return false;
        }
        

    }
}
