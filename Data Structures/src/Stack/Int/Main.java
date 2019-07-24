package Stack.Int;

public class Main {

	public static void main(String[] args) {
		IntStack intStack = new IntStack();
		
		if (intStack.isEmpty())
			System.out.println("The Stack is currently empty.");
		if (!intStack.isFull()) {
			intStack.push(5);
			intStack.push(8);
			intStack.push(29);
			intStack.push(62);
			intStack.push(74);
			intStack.push(36);
			intStack.push(20);
		}
		
		System.out.println(intStack.pop());
	}

}
