    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public static bool IsPalindrome(string word){
                bool result = false;
                var pal = string.Join("", word.Split(' '));
                var size = pal.Length - 1;
               
                for(var i = 0; i <= size; i++)
                {
                    if (i == size - i)
                        return true;
     
     
                    if(pal[i] == pal[size - i])
                    {
                        result = true;
                    } else
                    {
                        result = false;
                    }
     
                    if (!result)
                        return result;
                }
                return result;
            }
        }
    }