import java.awt.Color;
import java.awt.Dimension;
import java.awt.GridLayout;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

import javax.swing.JComponent;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextArea;

public class KeyListenerExample extends JPanel implements KeyListener{

	private JLabel lbl1;
	private JTextArea txKeyArea;
	private JTextArea txArea;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		JFrame frame = new JFrame("Key Listener");
		JComponent comp = new KeyListenerExample();
		comp.setOpaque(true);
		frame.setContentPane(comp);
		frame.pack();
		frame.setVisible(true);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setLocationRelativeTo(null);
	}

	/**
	 * Create the application.
	 */
	public KeyListenerExample() {
		super(new GridLayout(0,1));
		txKeyArea = new JTextArea();
		add(txKeyArea);
		
		lbl1 = new JLabel();
		lbl1.setBounds(20, 50, 100, 20);
		
		txArea = new JTextArea();
		txArea.setBounds(20, 80, 300, 300);
		txArea.addKeyListener(this);
		
		add(lbl1);
		add(txArea);
		
		setSize(400, 400);
		setLayout(null);
		setBackground(Color.CYAN);
		setVisible(true);
		setPreferredSize(new Dimension(450, 450));
	}

	@Override
	public void keyTyped(KeyEvent e) {
		lbl1.setText("Key Pressed");
	}

	@Override
	public void keyPressed(KeyEvent e) {
		lbl1.setText("Key Released");
	}

	@Override
	public void keyReleased(KeyEvent e) {
		lbl1.setText("Key Typed");
	}

}
