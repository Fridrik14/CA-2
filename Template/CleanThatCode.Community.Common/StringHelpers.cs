using System.Linq;

namespace CleanThatCode.Community.Common
{
    // Your job is to implement this class
    public static class StringHelpers
    {
        // Instead of spaces it should be separated with dots, e.g. Hello World -> Hello.World
        public static string ToDotSeparatedString(this string str)
        {
            string newstring = "";
            
            for(int i=0; i<str.Length; i++){
                
                if(str[i] != ' '){
                    newstring += str[i];
                    
                }
                else{
                    newstring += '.';
                }
            }
            
            return newstring;
        }
        
        // All words in the string should be capitalized, e.g. teenage mutant ninja turtles -> Teenage Mutant Ninja Turtles
        public static string CapitalizeAllWords(this string str)
        {
            string newstring = "";
            for(int i = 0 ; i<str.Length; i++){
                int x;
                if(i-1 < 0){
                    x = 0;
                }
                else{
                    x = i-1;
                }
                if (i == 0 | str[x] == ' '){
                    newstring += char.ToUpper(str[i]);
                }
                else{
                    newstring += str[i];
                }
            }
            return newstring;
        }

        // The words should be reversed in the string, e.g. Hi Ho Silver Away! -> Away! Silver Ho Hi
        public static string ReverseWords(this string str)
        {
            string[] words = str.Split(' ');
            string newstring = "";
            for(int i = words.Length ; i>0; i--){
                if (i-1 == 0){newstring += words[i-1];}
                else{newstring += words[i-1] + ' ';}
            }
            
            return newstring;
        }
    }
}