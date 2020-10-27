package zad1;

public class Results {
	public int result;
	public int wr;
	public Object points;
	//metoda przelicza wynik w stosunku do rekodu swiata na dystansie
	
	public int ResultPoints (int result, int wr) {
		result = Math.abs(result);
		wr = Math.abs(wr);
		
		if ( result==0 && wr==0) {
			points= null;
			//	throw new IllegalArgumentException();
		}
		if (result < wr)
		 points = (result * 100)/wr ;
		if (result > wr)
		 points =  (result * 100)/wr ;
		if (result == wr && result!=0 && wr!=0)
			 points =  100 ;
	
		
		
		return (int) points;
	}
	
	
}

