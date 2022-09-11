using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        // Your code here
        bool isValid = false;
        isValid = Count(input);
        Console.WriteLine($"Input: '{input}' \n");
        return isValid;
    }
   public static bool Count(string count)
   {
           char[] temp;
            int openCount, closeCount, total, end;
            temp = count.ToCharArray();
            total = temp.Count();
            end = total - 1;
            openCount = 0;
            closeCount = 0;

            if (count == "") return true;

            for (int i = 0; i < total; i++)
            {
                if (temp[i] == '(')
                {
                    openCount++;
                }
                if (temp[i] == ')')
                {
                    closeCount++;
                }
                if (closeCount > openCount)
                {
                    return false;
                }
                if (i == (end) && (openCount != closeCount))
                {
                    return false;
                }
                if (i == (end) && temp[end] == ')')
                {
                    return true;
                }
            }

            return false;
   }
}