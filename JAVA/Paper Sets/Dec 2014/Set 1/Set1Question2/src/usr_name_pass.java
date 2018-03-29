import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;

import java.awt.Font;
import javax.swing.JTextField;
import javax.swing.JPasswordField;
import java.awt.Color;
import java.awt.Toolkit;
import java.awt.Window.Type;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class usr_name_pass {

	private JFrame frmLogin;
	private JTextField txfUsrName;
	private JPasswordField psfPassword;
	private JButton btnLogin;
	private JButton btnExit;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					usr_name_pass window = new usr_name_pass();
					window.frmLogin.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public usr_name_pass() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frmLogin = new JFrame();
		frmLogin.getContentPane().setBackground(new Color(153, 255, 153));
		frmLogin.setTitle("Login");
		frmLogin.setResizable(false);
		frmLogin.setForeground(Color.DARK_GRAY);
		frmLogin.setBounds(100, 100, 350, 267);
		frmLogin.setLocationRelativeTo(null);
		frmLogin.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frmLogin.getContentPane().setLayout(null);
		
		JLabel lblUsername = new JLabel("Username");
		lblUsername.setFont(new Font("Trebuchet MS", Font.BOLD, 14));
		lblUsername.setBounds(30, 57, 71, 14);
		frmLogin.getContentPane().add(lblUsername);
		
		JLabel lblPassword = new JLabel("Password");
		lblPassword.setFont(new Font("Trebuchet MS", Font.BOLD, 14));
		lblPassword.setBounds(30, 116, 71, 14);
		frmLogin.getContentPane().add(lblPassword);
		
		txfUsrName = new JTextField();
		txfUsrName.setFont(new Font("Trebuchet MS", Font.PLAIN, 14));
		txfUsrName.setBounds(130, 54, 140, 20);
		frmLogin.getContentPane().add(txfUsrName);
		txfUsrName.setColumns(10);
		
		psfPassword = new JPasswordField();
		psfPassword.setFont(new Font("Trebuchet MS", Font.PLAIN, 14));
		psfPassword.setBounds(130, 113, 140, 20);
		frmLogin.getContentPane().add(psfPassword);
		
		JButton btnLogin = new JButton("Login");
		btnLogin.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				String usr_name = txfUsrName.getText();
				String pass = psfPassword.getText();
				
				if ( usr_name.equals("Nikhil") && pass.equals("123") ) {
					
					JOptionPane.showMessageDialog(null, "Login Successful !!");
				}
				
				else
					JOptionPane.showMessageDialog(null, "Login Unsuccessful !!");
			}
		});
		btnLogin.setFont(new Font("Trebuchet MS", Font.PLAIN, 12));
		btnLogin.setBounds(55, 181, 80, 23);
		frmLogin.getContentPane().add(btnLogin);
		
		JButton btnExit = new JButton("Exit");
		btnExit.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				System.exit(0);
			}
		});
		btnExit.setFont(new Font("Trebuchet MS", Font.PLAIN, 12));
		btnExit.setBounds(194, 182, 80, 23);
		frmLogin.getContentPane().add(btnExit);
	}
}
