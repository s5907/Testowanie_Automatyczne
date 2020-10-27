package zad1;

import static org.junit.Assert.*;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

//testy
public class test {
	
	private NWD nwd;
	private Results rp;

	@Before
	public void setUp() {
		nwd = new NWD();
		rp = new Results();
		System.out.println("Before");
	}
	
	@After
	public void tearDown() {
		nwd=null;
		rp=null;
		System.out.println("After");
	}

	@Test
	public void testNWD() {
		int result = nwd.NWD(4, 2);
		assertEquals(2,result);
		System.out.println("Test 1");
		
	}
	
	@Test
	//gdy wynik wiekszy od rekordu swiata test metody
	public void testResults() {
		int result = rp.ResultPoints(20, 10);
		assertEquals(200,result);
		System.out.println("Test 0");
		
	}
	@Test
	//gdy wynik wiekszy od rekordu swiata test metody
	public void testResults1() {
		int result = rp.ResultPoints(10, 20);
		assertEquals(50,result);
		System.out.println("Test 1");
		
	}
	@Test
	//gdy wynik równy rekordowi swiata test metody
	public void testResults2() {
		int result = rp.ResultPoints(4, 4);
		assertEquals(100,result);
		System.out.println("Test 2"+ result);
		
	}
	
	@Test
	//gdy wynik wiekszy od rekordu swiata test parametrów
	public void testResults3() {
		
		rp.wr= 3;
		rp.result= 4;
		int wr = rp.wr;
		int results = rp.result;
		assertTrue("rekord swiata wiekszy od wyniku ",wr < results);
		System.out.println("Test 3");
		
	}
	@Test
	//gdy wynik mniejszy od rekordu swiata test parametrów
	public void testResults4() {
		
		rp.wr= 4;
		rp.result= 3;
		int wr = rp.wr;
		int results = rp.result;
		assertTrue("rekord swiata mniejszy od wyniku",wr > results);
		System.out.println("Test 4");
		
	}
	@Test
	//gdy wynik równy rekordowi swiata test parametrów
	public void testResults5() {
		
		rp.wr= 4;
		rp.result= 3;
		int wr = rp.wr;
		int results = rp.result;
		assertFalse("rekord swiata ró¿ny od wyniku",wr == results);
		System.out.println("Test 5");
		
	}
	@Test
public void testResults6() {
		//test wartosci null wyniku metdy wymaga wy³aczenia IllegalArgumentException
		int result = rp.ResultPoints(0, 0);
		assertNotNull("punkty maja wartosæ null",result );
		System.out.println("Test 6"+ result);
		
	}
	@Test
public void testResults7() {
		//test wartosci null wyniku metdy wymaga wy³aczenia IllegalArgumentException
	int result = rp.ResultPoints(1, 1);
	assertNull("punkty maja wartosæ null",result );
	System.out.println("Test 7"+ result);
	
}
}
