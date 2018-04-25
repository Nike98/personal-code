/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP which will create one Button, when clicked, toggle
 * 		the Label of Button OK to KO.
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class toggle_button {

	public static void main(String[] args) {
		
		JFrame frame = new JFrame("Toggle Button");
		frame.setSize(400, 400);
		frame.setLayout(null);
		frame.setVisible(true);
		frame.setLocationRelativeTo(null);
		
		Button btn = new Button("OK");
		btn.setBounds(150, 150, 100, 50);
		btn.setBackground(Color.LIGHT_GRAY);
		btn.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				
				btn.setLabel("KO");
			}
			
		});
		
		frame.add(btn);
	}

}
