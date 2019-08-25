public class Kata
{
  public static int Grow(int[] x)
  {
    int product = x[0];
    for(int i = 0; i < x.Length - 1; i++)
    {
      product = product * x[i+1];
    }
    
    return product;
  }
}