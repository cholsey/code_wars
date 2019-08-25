using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

public static class Kata
{
	public static int sumTwoSmallestNumbers(int[] numbers)
	{
		int lowestNum = 0;
    int lowNum = 0;
   
    int[] sortedNumbers = numbers.OrderBy(i => i).ToArray();
    lowestNum = sortedNumbers[0];
    lowNum = sortedNumbers[1];
    
    int newNumber = lowNum + lowestNum;
    
    return newNumber;
	}
}