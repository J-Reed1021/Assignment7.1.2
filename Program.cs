using System.Text;

namespace Assignment7._1._2
{
  
public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        StringBuilder sb = new();
        int Lengthy = (word1.Length >= word2.Length ? word1.Length : word2.Length);
        for (int i = 0; i < Lengthy; i++)
        {
            if (word1.Length > i)
                sb.Append(word1[i]);
            if (word2.Length > i)
                sb.Append(word2[i]);
        }
        return sb.ToString();
    }
}
    internal class Program
    {
        public static void Main(string[] args)
        {

            string word1 = "abc";
            string word2 = "pqr";

            Solution solution = new Solution();
            string merged = solution.MergeAlternately(word1, word2);

            Console.WriteLine($"Merged output {merged}");

        }
    }
}