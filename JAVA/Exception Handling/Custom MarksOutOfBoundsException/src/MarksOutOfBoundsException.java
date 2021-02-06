
public class MarksOutOfBoundsException extends Exception {

	public MarksOutOfBoundsException(String message) {
		super(message);
	}
	
	public void showErrorMessage() {
		System.out.println("\n ERROR: Invalid Marks (Marks cannot be greater than 100)");
	}

}
