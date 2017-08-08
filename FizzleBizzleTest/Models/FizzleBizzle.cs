using System;
namespace FizzleBizzleTest.Models
{
    public class FizzleBizzle : IFizzleBizzle
    {
    
        public int Fizz     { get; set;} 
        public int Buzz     { get; set;}
        public int Start    { get; set;}
        public int End      { get; set;}
    
        public FizzleBizzle() { }
        
        public string[] FizzBuzz(int start, int end)
        {
            return null;
        }
        
        public string[] FizzBuzzBazz(int start, int end, Predicate<int> bazz)
        {
            return null;
        }
        
    }
}
