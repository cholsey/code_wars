using System;
using System.Linq;

public class IQ
    {
        public static int Test(string numbers)
        { 
            int[] nArr = numbers.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            
            int evenCount=0;
            int oddCount=0;
            
            for(int i=0; i < nArr.Length; i++)
            {
              if(nArr[i]%2 == 1 )
              {
                oddCount = oddCount + 1;
              }  
              else
              {
                evenCount = evenCount + 1;
              }
            }
            
            if(oddCount == 1)
            {
              for(int i=0; i < nArr.Length; i++)
              {
                if(nArr[i]%2 == 1 )
                  return i+1;
                else
                  {
                    continue;
                  }
              }
              return oddCount;
            } 
            else if(evenCount == 1)
            {
              for(int i=0; i < nArr.Length; i++)
                {
                  if(nArr[i]%2 == 0 )
                    return i+1;
                  else
                    {
                      continue;
                    }
                }
                return evenCount;
            }
            else
              return evenCount;
        }
    }