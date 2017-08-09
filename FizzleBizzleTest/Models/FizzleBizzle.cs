using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FizzleBizzleTest.Models
{
    public class FizzleBizzle : IFizzleBizzle
    {
    
        private static int _bazz;
    
        public int Fizz     { get; set;} 
        public int Buzz     { get; set;}
        public int Start    { get; set;}
        public int End      { get; set;}
        
        public Predicate<int> GreaterThan = x => x > _bazz;
        
        public int Bazz { get { return _bazz; } set { _bazz = value; } }
    
    
        public FizzleBizzle() { }
        
        public string[] FizzBuzz(int start, int end)
        {
            // Create array of ints from start to end
            int[] arr = Enumerable.Range(start, (end - start) + 1).ToArray();
            // Create string array to return
            string[] ret = new string[(end - start) + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                bool isFizz = (arr[i] % Fizz) == 0;
                bool isBuzz = (arr[i] % Buzz) == 0;
                

                if (isFizz && isBuzz )
                {
                    ret[i] = "FizzBuzz";
                    continue;
                }
                else if (isFizz)
                {
                    ret[i] = "Fizz";
                    continue;
                }
                else if (isBuzz)
                {
                    ret[i] = "Buzz";
                    continue;
                }
                else
                {
                    ret[i] = arr[i].ToString();
                }
            }
            
            return ret;
        }
        
        public string[] FizzBuzzBazz(int start, int end, Predicate<int> bazz)
        {
            // Create array of ints from start to end
            int[] arr = Enumerable.Range(start, (end - start) + 1).ToArray();
            // Create string array to return
            string[] ret = new string[(end - start) + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                bool isFizz = (arr[i] % Fizz) == 0;
                bool isBuzz = (arr[i] % Buzz) == 0;
                bool isBazz = bazz(arr[i]);

                if (isFizz && isBuzz && isBazz)
                {
                    ret[i] = "FizzBuzzBazz";
                    continue;
                }
                else if (isFizz && isBuzz)
                {
                    ret[i] = "FizzBuzz";
                    continue;
                }
                else if (isFizz)
                {
                    ret[i] = "Fizz";
                    continue;
                }
                else if (isBuzz)
                {
                    ret[i] = "Buzz";
                    continue;
                }
                else
                {
                    ret[i] = arr[i].ToString();
                }
            }
            
            return ret;
        }
        
    }
}
