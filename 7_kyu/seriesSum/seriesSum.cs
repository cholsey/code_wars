using System;

public class NthSeries {
	
	public static string seriesSum (int n) {
		// Happy Coding ^_^
    double happyCoding = 0.00d;
    double counter = 1;
  
    for(int i=1; i<=n; i++)
    {
      happyCoding += (1/counter);
      counter+=3;
    }
    
    return happyCoding.ToString("0.00");
	}
}