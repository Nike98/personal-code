import java.applet.Applet;
import java.awt.Button;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Panel;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;


/*
 * <applet code="BouncingBall" width=150 height=150></applet>
 */

public class BouncingBall extends Applet implements Runnable, ActionListener {
	
	private Panel panel;
	private Button start;
	private Button stop;
	
	private boolean flag;
	private int x = 150;
	private int y = 50;
	private int r = 20;
	private int dx = 11;
	private int dy = 7;
	
	Thread t = new Thread();
	
	public void init() {
		flag = false;
		panel = new Panel();
		
		start = new Button("Start");
		start.addActionListener((ActionListener) this);
		panel.add(start);
		
		stop = new Button("Stop");	
		stop.addActionListener((ActionListener) this);
		panel.add(stop);
		
		add(panel);
		new Thread(this, "StopWatch").start();
	}
	
	public void paint(Graphics g) {
		setBackground(Color.RED);
		g.setColor(Color.YELLOW);
		g.drawOval(x-r, y-r, r*2, r*2);
		g.fillOval(x-r, y-r, r*2, r*2);
	}
	
	@Override
	public void run() {
		while (flag) {
			if (!flag)
				break;
			
			if ((x-r + dx < 0) || (x+r + dx > bounds().width))	dx = -dx;
			if ((y-r + dy < 0) || (y+r + dy > bounds().width))	dy = -dy;
			
			x += dx;
			y += dy;
			
			try {
				repaint();
				Thread.sleep(10);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		if (e.getSource() == start) {
			flag = true;
			new Thread(this, "StopWatch").start();
		}
		
		if (e.getSource() == stop) 
			flag = false;
	}

}
