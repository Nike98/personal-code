import java.util.Random;

public class Random_num {

	public static void main(String[] args) {
		Random dice = new Random ();
		int number;
		
		for ( int counter = 0 ; counter < 10 ; counter++ ) {
			number = 1 + dice.nextInt(6);
			System.out.println(" " + number);
		}
	}

}
