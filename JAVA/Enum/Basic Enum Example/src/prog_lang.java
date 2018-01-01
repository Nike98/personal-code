/*
 * ############################################################################
 * ############################################################################
 * 
 * 			This is the Enum class which contains the names of the 
 * 			  most popular programming languages of 2017, the name 
 * 		   of their developers and the percentage of it's popularity.
 * 
 * ############################################################################
 * ############################################################################
*/

public enum prog_lang {
	Java("James Gosling", "13.27%"),
	C("Dennis Ritchie", "10.16%"),
	C_plus_plus("Bjarne Stroustrup", "4.72%"),
	Pyhton("Guido Van Rossum", "3.78%"),
	C_Sharp("Bill Joy", "2.82%"),
	JavaScript("Brendan Eich", "2.47%"),
	VB_dot_NET("Microsoft Corp", "2.47%"),
	R("Ross Ihaka and Robert Gentleman", "1.91%"),
	PHP("Rasmus Lerdorf","1.59%"),
	MATLAB("Cleve Moler", "1.57%"),
	Swift("Apple Corp", "1.50%");
	
	private final String developer;
	private final String popularity;
	
	prog_lang(String dev, String popu){
		developer = dev;
		popularity = popu;
	}
	
	public String getDeveloper () {
		return developer;
	}
	
	public String getPopularity () {
		return popularity;
	}
}
	