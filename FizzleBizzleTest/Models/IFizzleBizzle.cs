using System;
namespace FizzleBizzleTest.Models
{
    public interface IFizzleBizzle
    {
        int Fizz { set; }
        int Buzz { set; }
            
        string[] FizzBuzz(int start, int end);
           
        string[] FizzBuzzBazz(int start, int end, Predicate<int> bazz);
    }
}
