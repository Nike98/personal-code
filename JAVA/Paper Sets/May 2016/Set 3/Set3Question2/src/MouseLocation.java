/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		Design a Screen in Java to handle Mouse Events and Display 
 * 		the position of the Mouse Click in a Text Box.
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.applet.Applet;
import java.awt.*;
import java.awt.event.*;

public class MouseLocation extends Applet implements MouseListener, MouseMotionListener {

	String msg;
	int x, y;
	
	TextField txf = new TextField(20);
	
	public void init(){
		
		setLayout(new FlowLayout(FlowLayout.CENTER));
		add(txf);
		
		addMouseListener(this);
		addMouseMotionListener(this);
	}
	
	@Override
	public void mouseDragged(MouseEvent e) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void mouseMoved(MouseEvent e) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void mouseClicked(MouseEvent e) {
		
		txf.setText("Mouse Clicked at " + e.getX() + "," + e.getY());
		repaint();
	}

	@Override
	public void mousePressed(MouseEvent e) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void mouseReleased(MouseEvent e) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void mouseEntered(MouseEvent e) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void mouseExited(MouseEvent e) {
		// TODO Auto-generated method stub
		
	}
	
	public void paint(Graphics g) {
		
		g.drawString(msg, 10, 10);
	}

}
