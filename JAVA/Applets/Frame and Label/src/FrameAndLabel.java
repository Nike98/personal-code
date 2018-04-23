/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		Basic example of and Applet to display a Frame
 * 		and two Labels in it.
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.awt.Frame;
import java.awt.Label;

public class FrameAndLabel {

	public static void main(String[] args) {
		
		Frame frame = new Frame("Frame Example");
		frame.setSize(400, 400);
		frame.setLayout(null);
		frame.setVisible(true);
		frame.setLocationRelativeTo(null);
		
		Label lbl1 = new Label("Label 1");
		lbl1.setBounds(50, 100, 100, 30);
		
		Label lbl2 = new Label("Label 2");
		lbl2.setBounds(50, 150, 100, 30);
		
		frame.add(lbl1);
		frame.add(lbl2);
	}

}
