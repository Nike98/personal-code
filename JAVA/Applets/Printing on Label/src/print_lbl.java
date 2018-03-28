/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		Basic example of and Applet to display a Frame
 * 		and a clickable button in it which displays 
 * 		specific text written in a TextField on a Label.
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.awt.Frame;
import java.awt.TextField;
import java.awt.Button;
import java.awt.Label;
import java.awt.event.*;

public class print_lbl {

	public static void main(String[] args) {
		
		Frame frame = new Frame("Printing in Label Example");
		frame.setSize(400, 400);
		frame.setLayout(null);
		frame.setVisible(true);
		frame.setLocationRelativeTo(null);
		
		Label lbl1 = new Label();
		lbl1.setBounds(50,200,250,50);
		
		TextField txf1 = new TextField();
		txf1.setBounds(50, 50, 150, 20);
		
		Button btn1 = new Button("Print");
		btn1.setBounds(50, 100, 60, 30);
		btn1.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				
					String name = txf1.getText();
					lbl1.setText("Your name is " + name);
			}
			
		});
		
		frame.add(lbl1);
		frame.add(txf1);
		frame.add(btn1);
	}

}
