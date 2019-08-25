using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
    char[] cInput = input.ToCharArray();
    int xScore=0;
    int oScore=0;
    bool bTicTac = false;
    
    for(int i= 0; i<input.Length; i++)
    {
      if(cInput[i] == 'x' || cInput[i] == 'X')
      {
        xScore = xScore + 1;
        continue;
      }
      else if(cInput[i] == 'o' || cInput[i] == 'O')
      {
        oScore = oScore + 1;
        continue;
      }
     
     continue;
      
    }
    
    if(xScore == oScore)
    {
      bTicTac = true;
      return bTicTac;
    }
    else{
      return bTicTac;}
  }
}