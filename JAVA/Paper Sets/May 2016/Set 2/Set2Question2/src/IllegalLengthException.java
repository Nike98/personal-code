
public class IllegalLengthException extends Exception {

	String excp_str;
	
	// Constructor to call this class whenever the exception is raised
	// And the parameter to store the String passed by the Throw block
	public IllegalLengthException( String throw_str ) {
		
		excp_str = throw_str;
	}
	
	// Returns the Exception String
	public String getMessage() {
		
		return excp_str;
	}
}
