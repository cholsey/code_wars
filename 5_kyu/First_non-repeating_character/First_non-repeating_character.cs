using System.Collections.Generic;
using System.Linq;
using static System.Char;

public class Kata
{
  public static string FirstNonRepeatingLetter(string s)
  {
      foreach (char sChar in s)
      {
          if (s.ToLower().Count(c => c == ToLower(sChar)) == 1)
          {
              return sChar.ToString();
          }
      }
      return string.Empty;
  }
}