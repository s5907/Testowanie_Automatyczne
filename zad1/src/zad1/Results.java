package zad1;

import java.util.HashMap;

public class Results {
	public int result, wr;
	public Object points;
	HashMap<String, Integer> results = new HashMap<>(); 
	//metoda przelicza wynik w stosunku do rekodu swiata na dystansie
	
	public int ResultPoints (int result, int wr) {
		result = Math.abs(result);
		wr = Math.abs(wr);
	//	Player pla= new Player();
	//	results.put(player, result);
		
	//	pla.playersAge.add(result);
		
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

