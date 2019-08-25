using System;


public class Kata
{
  public static bool IsAscOrder(int[] arr)
  { 
    int length = arr.Length-1;
    
    for(int i=0; i<length; i++)
    {
      if(arr[i] > arr[i+1])
        return false;
    }
    
    return true;
  }
}