/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP which will create 2 Buttons and One TextField. On click
 * 		any Button Label will be displayed in the TextField.
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class s4q1 {

	public static void main(String[] args) {
		
		JFrame frame = new JFrame("Button and TextField");
		frame.setSize(400, 400);
		frame.setLayout(new FlowLayout());
		frame.setVisible(true);
		frame.setLocationRelativeTo(null);
		
		TextField txf = new TextField();
		txf.setBounds(150, 100, 100, 25);
		txf.setVisible(true);
		
		Button btn1 = new Button("Button 1");
		btn1.setBounds(150, 150, 100, 30);
		btn1.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				
				txf.setText(btn1.getLabel());
			}
			
		});
		
		Button btn2 = new Button("Button 2");
		btn2.setBounds(150, 200, 100, 30);
		btn2.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				
				txf.setText(btn2.getLabel());
			}
			
		});
		
		frame.add(txf);
		frame.add(btn1);
		frame.add(btn2);
	}

}
