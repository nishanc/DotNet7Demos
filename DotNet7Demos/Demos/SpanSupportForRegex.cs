using System.Text.RegularExpressions;

namespace DotNet7Demos.Demos
{
    public static class SpanSupportForRegex
    {
        public static void Demo()
        {
            // Create a pattern Regex for a word that starts with letter "R" 
            Regex regex = new Regex(@"\b[R]\w+");  
            
            // Long string  
            string authors = "John M. Harshman, Robert J. Howley, Mike Gold, Allen O'Neill, Marshal Troll"; 
            // Get all matches  
            var matchedAuthors = regex.Matches(authors);

            ReadOnlySpan<char> authorsChar = authors.AsSpan();  
            // Get all matches  
            var IsMatchedAuthors = regex.IsMatch(authorsChar);
            var matchedAuthorsCount = regex.Count(authorsChar);
            var matchedAuthorsEnumerator = regex.EnumerateMatches(authorsChar);

            Console.WriteLine(matchedAuthorsEnumerator.Current.Index);
        }
    }
}