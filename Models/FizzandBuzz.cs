using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.Models
{
    public class FizzandBuzz
    {
        //User inputs 2 numbers
        public int FirstNum { get; set; }
        public int SecondNum { get; set; }

        //Multiple of 3, 5, or 15
        public string Fizz { get; set; }
        public string Buzz { get; set; }
        public string FizzBuzz { get; set; }

        //output
        public string Message { get; set; }


    }
}
