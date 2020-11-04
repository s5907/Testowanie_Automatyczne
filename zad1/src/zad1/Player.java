package zad1;
import java.util.List;
import java.util.ArrayList;
import java.util.HashMap;

public class Player {
	
	private static Object ppp;
	public String name;
	public  int age;
	public List<String> players = new ArrayList<>();
	public List<Integer> playersAge = new ArrayList<>();
	public HashMap<String, Integer > details = new HashMap<>();
	
	public void AddPlayer (String name, int age) {
		players.add(name);
		players.add("Adam");
		playersAge.add(21);
		
		
		playersAge.add(age);
		players.add("Maciej");
		playersAge.add(18);
		
		
		 
		details.put("keanu", 23);
		details.put("max", 23);
		details.put("john", 53);
		
		HashMap<String, Integer> map = new HashMap<>(); 

    // Add elements to the map 
    map.put("vishal", 10); 
    map.put("sachin", 30); 
    map.put("vaibhav", 20); 
		
		players.addAll(details.keySet());
		
		AddPlayer ("marcin",22 );
		
		System.out.println ("name =" + players.size());
		System.out.println ("name =" + players);
		System.out.println ("name =" + details);
		
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
	

	}

}
