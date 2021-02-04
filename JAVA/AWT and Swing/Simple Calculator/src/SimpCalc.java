import java.awt.EventQueue;
import javax.swing.JFrame;
import javax.swing.JTextField;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;

public class SimpCalc {

	private JFrame frame;
	private JTextField txfMain;
	
	double first;
	double second;
	double result;
	String operation;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					SimpCalc window = new SimpCalc();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public SimpCalc() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setResizable(false);
		frame.setBounds(100, 100, 385, 480);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setTitle("Simple Calculator");
		frame.getContentPane().setLayout(null);
		frame.setLocationRelativeTo(null);
		
		txfMain = new JTextField();
		txfMain.setFont(new Font("Arial", Font.BOLD, 26));
		txfMain.setBounds(11, 11, 349, 56);
		frame.getContentPane().add(txfMain);
		txfMain.setColumns(12);
		
		JButton btnClear = new JButton("C");
		btnClear.setFont(new Font("Arial", Font.BOLD, 24));
		btnClear.setBounds(100, 78, 80, 60);
		frame.getContentPane().add(btnClear);
		btnClear.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				txfMain.setText(null);				
			}
		});
		
		JButton btnBackspace = new JButton("\uF0E7");
		btnBackspace.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				String backSpace = null;
				if (txfMain.getText().length() > 0) {
					StringBuilder strb = new StringBuilder(txfMain.getText());
					strb.deleteCharAt(txfMain.getText().length() - 1);
					backSpace = strb.toString();
					txfMain.setText(backSpace);
				}
			}
		});
		btnBackspace.setFont(new Font("Windings", Font.BOLD, 24));
		btnBackspace.setBounds(10, 78, 80, 60);
		frame.getContentPane().add(btnBackspace);
				
		JButton btnAdd = new JButton("+");
		btnAdd.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				first = Double.parseDouble(txfMain.getText());
				txfMain.setText("");
				operation = "+";
			}
		});
		btnAdd.setFont(new Font("Arial", Font.BOLD, 24));
		btnAdd.setBounds(280, 78, 80, 60);
		frame.getContentPane().add(btnAdd);
		
		JButton btnSubtract = new JButton("-");
		btnSubtract.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				first = Double.parseDouble(txfMain.getText());
				txfMain.setText("");
				operation = "-";
			}
		});
		btnSubtract.setFont(new Font("Arial", Font.BOLD, 24));
		btnSubtract.setBounds(280, 149, 80, 60);
		frame.getContentPane().add(btnSubtract);

		JButton btnMultiply = new JButton("X");
		btnMultiply.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				first = Double.parseDouble(txfMain.getText());
				txfMain.setText("");
				operation = "*";
			}
		});
		btnMultiply.setFont(new Font("Arial", Font.BOLD, 24));
		btnMultiply.setBounds(281, 223, 80, 60);
		frame.getContentPane().add(btnMultiply);

		JButton btnDivide = new JButton("/");
		btnDivide.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				first = Double.parseDouble(txfMain.getText());
				txfMain.setText("");
				operation = "/";
			}
		});
		btnDivide.setFont(new Font("Arial", Font.BOLD, 24));
		btnDivide.setBounds(281, 294, 80, 60);
		frame.getContentPane().add(btnDivide);
		
		JButton btnPercentage = new JButton("%");
		btnPercentage.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				first = Double.parseDouble(txfMain.getText());
				txfMain.setText("");
				operation = "%";
			}
		});
		btnPercentage.setFont(new Font("Arial", Font.BOLD, 24));
		btnPercentage.setBounds(280, 365, 80, 60);
		frame.getContentPane().add(btnPercentage);
		
		JButton btnEquals = new JButton("=");
		btnEquals.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String answer;
				second = Double.parseDouble(txfMain.getText());
				
				if (operation == "+") {
					result = first + second;
					answer = String.format("%.2f", result);
					txfMain.setText(answer);
				} 
				
				else if (operation == "-") {
					result = first - second;
					answer = String.format("%.2f", result);
					txfMain.setText(answer);
				} 
				
				else if (operation == "*") {
					result = first * second;
					answer = String.format("%.2f", result);
					txfMain.setText(answer);
				}
				
				else if (operation == "/") {
					result = first / second;
					answer = String.format("%.2f", result);
					txfMain.setText(answer);
				}
				
				else if (operation == "%") {
					result = first % second;
					answer = String.format("%.2f", result);
					txfMain.setText(answer);
				}
			}
		});
		btnEquals.setFont(new Font("Arial", Font.BOLD, 24));
		btnEquals.setBounds(190, 365, 80, 60);
		frame.getContentPane().add(btnEquals);
		
		JButton btnDecimal = new JButton(".");
		btnDecimal.setFont(new Font("Arial", Font.BOLD, 24));
		btnDecimal.setBounds(100, 365, 80, 60);
		frame.getContentPane().add(btnDecimal);
		btnDecimal.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				String num = txfMain.getText() + btnDecimal.getText();
				txfMain.setText(num);
			}
		});
		
		JButton btn00 = new JButton("00");
		btn00.setFont(new Font("Arial", Font.BOLD, 24));
		btn00.setBounds(190, 78, 80, 60);
		frame.getContentPane().add(btn00);
		btn00.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				String num = txfMain.getText() + btn00.getText();
				txfMain.setText(num);
			}
		});
		
		JButton btn0 = new JButton("0");
		btn0.setFont(new Font("Arial", Font.BOLD, 24));
		btn0.setBounds(10, 365, 80, 60);
		frame.getContentPane().add(btn0);
		btn0.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				String num = txfMain.getText() + btn0.getText();
				txfMain.setText(num);
			}
		});
		
		JButton btn1 = new JButton("1");
		btn1.setFont(new Font("Arial", Font.BOLD, 24));
		btn1.setBounds(11, 294, 80, 60);
		frame.getContentPane().add(btn1);
		btn1.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				String num = txfMain.getText() + btn1.getText();
				txfMain.setText(num);
			}
		});
		
		JButton btn2 = new JButton("2");
		btn2.setFont(new Font("Arial", Font.BOLD, 24));
		btn2.setBounds(101, 294, 80, 60);
		frame.getContentPane().add(btn2);
		btn2.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				String num = txfMain.getText() + btn2.getText();
				txfMain.setText(num);
			}
		});
		
		JButton btn3 = new JButton("3");
		btn3.setFont(new Font("Arial", Font.BOLD, 24));
		btn3.setBounds(191, 294, 80, 60);
		frame.getContentPane().add(btn3);
		btn3.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				String num = txfMain.getText() + btn3.getText();
				txfMain.setText(num);
			}
		});

		JButton btn4 = new JButton("4");
		btn4.setFont(new Font("Arial", Font.BOLD, 24));
		btn4.setBounds(11, 223, 80, 60);
		frame.getContentPane().add(btn4);
		btn4.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				String num = txfMain.getText() + btn4.getText();
				txfMain.setText(num);
			}
		});
		
		JButton btn5 = new JButton("5");
		btn5.setFont(new Font("Arial", Font.BOLD, 24));
		btn5.setBounds(101, 223, 80, 60);
		frame.getContentPane().add(btn5);
		btn5.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				String num = txfMain.getText() + btn5.getText();
				txfMain.setText(num);
			}
		});
		
		JButton btn6 = new JButton("6");
		btn6.setFont(new Font("Arial", Font.BOLD, 24));
		btn6.setBounds(191, 223, 80, 60);
		frame.getContentPane().add(btn6);
		btn6.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				String num = txfMain.getText() + btn6.getText();
				txfMain.setText(num);
			}
		});
		
		JButton btn7 = new JButton("7");
		btn7.setFont(new Font("Arial", Font.BOLD, 24));
		btn7.setBounds(10, 149, 80, 60);
		frame.getContentPane().add(btn7);
		btn7.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				String num = txfMain.getText() + btn7.getText();
				txfMain.setText(num);
			}
		});
		
		JButton btn8 = new JButton("8");
		btn8.setFont(new Font("Arial", Font.BOLD, 24));
		btn8.setBounds(100, 149, 80, 60);
		frame.getContentPane().add(btn8);
		btn8.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				String num = txfMain.getText() + btn8.getText();
				txfMain.setText(num);
			}
		});
		
		JButton btn9 = new JButton("9");
		btn9.setFont(new Font("Arial", Font.BOLD, 24));
		btn9.setBounds(190, 149, 80, 60);
		frame.getContentPane().add(btn9);
		btn9.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				String num = txfMain.getText() + btn9.getText();
				txfMain.setText(num);
			}
		});
		
	}
}
