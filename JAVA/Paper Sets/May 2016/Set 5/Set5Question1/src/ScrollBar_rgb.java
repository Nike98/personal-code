/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		Write an AWT program to add three Scroll Bars indicating 
 * 		Red, Green, and Blue Color. The background color of the 
 * 		frame should be changed according to the value selected 
 * 		in the Scroll Bars.
 * 
 * ######################################################################################
 * ######################################################################################
*/

import javax.swing.JFrame;

public class ScrollBar_rgb {

	public static void main(String[] args) {
		
		rgb_scroller obj = new rgb_scroller();
		
		obj.setSize(400, 400);
		obj.setVisible(true);
		obj.setLocationRelativeTo(null);
		obj.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

}
