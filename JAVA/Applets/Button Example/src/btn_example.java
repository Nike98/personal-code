/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		Basic example of and Applet to display a Frame
 * 		and a clickable button in it.
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.awt.*;

public class btn_example {

	public static void main(String[] args) {
		
		Frame frame = new Frame("Button Example");
		frame.setSize(400, 400);
		frame.setLayout(null);
		frame.setVisible(true);
		frame.setLocationRelativeTo(null);
		
		Button btn = new Button("Click Me!");
		btn.setBounds(50, 100, 80, 30);
		
		frame.add(btn);
	}

}
