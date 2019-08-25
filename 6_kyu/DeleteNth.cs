using System;
using System.Collections.Generic;
using System.Linq;

public class Kata {
  public static int[] DeleteNth(int[] arr, int x) 
  {
       List<int> list = arr.Cast<int>().ToList();
       List<int> temp = new List<int>();
       int length = list.Count();
       IEnumerable<int> distinctList = list.Distinct();
       Dictionary<int, int> My_dict =
         new Dictionary<int, int>();

       for (int i = 0; i < length; i++)
       {
          My_dict.Add(i, list[i]);
       }

       foreach (int num in distinctList)
       {
          int count = 0;

          for (int i = 0; i < length; i++)
          {
              if (num == list[i])
              {
                  count++;
              }

              if (count > x && num == list[i])
              {
                  temp.Add(i);
              }
          }
       }
      
       for(int i = 0; i < temp.Count(); i++)
       {
          My_dict.Remove(temp[i]);
       }

       var myArray = My_dict.Values.ToArray();

       return myArray;
  }
}