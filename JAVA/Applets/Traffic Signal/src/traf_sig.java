/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		This program creates an Applet to show the working of a
 * 		Traffic Signal.
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.awt.*;
import java.awt.event.*;
import java.applet.*;
import java.applet.Applet;

public class traf_sig extends Applet implements ActionListener {

	int colorNum;		// Variable responsible to change the color of the Lights
	
	Button btnStop = new Button("Stop Traffic");		// Red light
	Button btnCaut = new Button("Caution");				// Yellow light
	Button btnProc = new Button("Proceed");				// Green light
	
	public void init() {
		
		setBackground(Color.LIGHT_GRAY);
		
		// Adding all the ActionListeners for the Buttons
		btnStop.addActionListener(this);
		btnCaut.addActionListener(this);
		btnProc.addActionListener(this);
		
		// Adding all the Buttons to the Applet Frame
		add(btnStop);
		add(btnCaut);
		add(btnProc);
	}
	
	public void paint(Graphics g) {
		
		g.setColor(Color.BLACK);
		
		g.setColor(colorNum == 1 ? Color.RED : Color.RED.darker().darker());
		g.fillOval(150, 60, 20, 20);		// for red
		
		g.setColor(colorNum == 2 ? Color.YELLOW : Color.YELLOW.darker().darker());
		g.fillOval(150, 90, 20, 20);		// for yellow
		
		g.setColor(colorNum == 3 ? Color.GREEN : Color.GREEN.darker().darker());
		g.fillOval(150, 120, 20, 20);
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		
		if ( e.getSource() == btnStop )
			colorNum = 1;
		
		else if ( e.getSource() == btnCaut )
			colorNum = 2;
		
		else
			colorNum = 3;
		
		repaint();
	}
}
