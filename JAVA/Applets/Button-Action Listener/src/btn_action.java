/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		Basic example of and Applet to display a Frame
 * 		and a clickable button in it which displays 
 * 		specific text in a TextField.
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.awt.Frame;
import java.awt.Button;
import java.awt.TextField;
import java.awt.event.*;

public class btn_action {

	public static void main(String[] args) {
		
		Frame frame = new Frame("Button Action Example");
		frame.setSize(400, 400);
		frame.setLayout(null);
		frame.setVisible(true);
		frame.setLocationRelativeTo(null);
		
		final TextField txf1 = new TextField();
		txf1.setBounds(50, 50, 150, 20);
		
		Button btn1 = new Button("Click Me!");
		btn1.setBounds(50, 100, 60, 30);
		
		btn1.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed (ActionEvent e) {
				txf1.setText("Hi there, How are you ?");
			}
		});
		
		frame.add(txf1);
		frame.add(btn1);
	}

}
