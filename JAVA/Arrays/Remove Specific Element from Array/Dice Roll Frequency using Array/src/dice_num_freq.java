/*
 * ##################################################################
 * 
 * 			This program is the presentation of the 
 * 		   usage of Arrays to store the Array indexes
 * 			(which are the dice faces) and show how
 * 			 frequently they appear when a dice is 
 * 			          rolled 1000 times.
 *  
 * ##################################################################
 */

import java.util.Random;

public class dice_num_freq {

	public static void main(String[] args) {
		Random rand = new Random();
		int freq[] = new int[7];
		
		for ( int roll = 0 ; roll < 1000 ; roll++ ) {
			++freq[1 + rand.nextInt(6)];
		}
		
		System.out.println(" Face\tFrequency");
		
		for ( int face = 1 ; face < freq.length ; face++ ) {
			System.out.println("  " + face + " \t  " + freq[face]);
		}
	}

}
