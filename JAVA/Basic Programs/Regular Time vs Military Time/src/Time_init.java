
public class Time_init {
	private int hours;
	private int minutes;
	private int seconds;
	
	public void SetTime (int h, int m, int s) {
		/*
		 * 		Here, in this function we check whether
		 * 		the specified variable input is within 
		 * 		bounds. If the input is above the specified 
		 * 		time bounds then by default 0 is printed. 
		 */
		
		hours = ((h >= 0 && h < 24) ? h : 0);
		minutes = ((m >= 0 && m < 60) ? m : 0);
		seconds = ((s >= 0 && s < 60) ? s : 0);
	}
	
	public String ToMilitary () {
		// This function Displays the Time in Military Format
		
		return String.format(" %02d : %02d : %02d", hours, minutes, seconds);
	}
	
	public String ToRegular () {
		// This function Displays the Time in Regular Format
		
		return String.format(" %d : %02d : %02d %s",((hours == 0 || hours == 12) ? 12 : hours % 12), minutes, seconds, (hours < 12 ? "AM" : "PM"));
	}
}
