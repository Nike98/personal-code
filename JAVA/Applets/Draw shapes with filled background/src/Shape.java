
import java.awt.Color;
import java.awt.Graphics;

import javax.swing.JPanel;

public class Shape extends JPanel {

	public void painComponent(Graphics g) {
		super.paintComponent(g);
		this.setBackground(Color.WHITE);
		
		g.setColor(Color.BLACK);
		g.drawLine(5, 30, 380, 30);
		
		g.setColor(Color.RED);
		g.fillRect(100, 40, 90, 55);
		
		g.setColor(Color.BLUE);
		g.fillOval(290, 100, 90, 55);
	}
}
