import java.awt.Color;
import java.awt.Dimension;
import java.awt.GridLayout;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

import javax.swing.BorderFactory;
import javax.swing.JComponent;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;

public class MouseEvents extends JPanel implements MouseListener {

	private JTextArea txarea;
	private JTextArea mouseArea;
	
	private static final String NEWLINE = System.getProperty("line.separator");

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		JFrame frame = new JFrame("Mouevents");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		JComponent newContentPane = new MouseEvents();
		newContentPane.setOpaque(true);
		frame.setContentPane(newContentPane);
		frame.pack();
		frame.setVisible(true);
		frame.setLocationRelativeTo(null);
	}

	/**
	 * Create the application.
	 */
	public MouseEvents() {
		super(new GridLayout(0, 1));
		mouseArea = new JTextArea();
		mouseArea.setBackground(Color.BLUE);
		add(mouseArea);
		
		txarea = new JTextArea();
		txarea.setEditable(false);
		
		JScrollPane scrollPane = new JScrollPane(txarea);
		scrollPane.setVerticalScrollBarPolicy(JScrollPane.VERTICAL_SCROLLBAR_ALWAYS);
		scrollPane.setPreferredSize(new Dimension(200, 75));
		add(scrollPane);
		
		mouseArea.addMouseListener(this);
		addMouseListener(this);
		setPreferredSize(new Dimension(450,450));
		setBorder(BorderFactory.createEmptyBorder(20,20,20,20));
	}
	
	void eventOutput(String eventDescription, MouseEvent e) {
		txarea.append(eventDescription + " detected on " + e.getComponent().getClass().getName() + "." + NEWLINE);
		
	}

	@Override
	public void mouseClicked(MouseEvent e) {
		eventOutput("Mouse clicked (# of clicks: " + e.getClickCount() + ")", e);
	}

	@Override
	public void mousePressed(MouseEvent e) {
		eventOutput("Mouse pressed (# of clicks: " + e.getClickCount() + ")", e);
	}

	@Override
	public void mouseReleased(MouseEvent e) {
		eventOutput("Mouse released (# of clicks: " + e.getClickCount() + ")", e);
	}

	@Override
	public void mouseEntered(MouseEvent e) {
		eventOutput("Mouse entered", e);
		
	}

	@Override
	public void mouseExited(MouseEvent e) {
		eventOutput("Mouse exited", e);
	}

}
