using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace SortFiles
{
    class Program
    {
        public static void Main(String[] args){
            Console.WriteLine("Sortfiles ver 1.0");
            string path = GetUserinput();
            MoveFiles(path);
        }
        
        internal static string GetUserinput(){
            string? path = "";
            while(true){
                Console.WriteLine("please specify a path to be sorted");
                path = Console.ReadLine();
                if(Directory.Exists(path)){
                    return path;
                }
                Console.WriteLine("invaild path");
            }

        }

        private static void MoveFiles(string path){
            string[] fileArr = Directory.GetFiles(path);
            foreach(string file in fileArr){
                string gamename = TrimName(file);

            }
        }
        //gets the game name from the file name
        internal static string TrimName(string input){
            // Regex pattern to capture everything before the date pattern (year:month:day)
            string pattern = @"^(.*?)(?:\s*\d{4}[:/-]\d{2}[:/-]\d{2})"; // Match the game name before the date

            // Match the pattern
            Match match = Regex.Match(input, pattern);

            if (match.Success){
                return match.Groups[1].Value.Trim();
            }

            return null;
        }
        
    }
}