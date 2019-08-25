using System.Linq;
public static class Kata
{
  public static int Solution(int value)
  {
    if(value < 3)
      return 0;
    //magic happens here..
    int[] tempMagic = new int [value];

    int magicTotal=0;
    int starter=0;
    
    for(int i=3; i<value; i+=3)
    {
      tempMagic[starter] = i;
      starter++;
    }
    
    for(int j=5; j<value; j+=5)
    {
      tempMagic[starter] = j;
      starter++;
    }
    
    magicTotal = tempMagic.Distinct().Sum();   

   return magicTotal;
  }
}