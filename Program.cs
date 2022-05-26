using System;
					
public class Program
{
	public static void Main(String[] args)
	{
	
		Console.WriteLine("Do you want to check more (Y/N)");
		string check= Console.ReadLine();
		while(check == "y"){
			
			int sum = 0;
			int sum_a = 0;
		float per =0;
		Console.WriteLine("Enter the Subject Code:");
		string subject_code = Console.ReadLine();
	
		Console.WriteLine("Enter the number of Sessions:");
		int number_session = int.Parse(Console.ReadLine());
		
		Console.WriteLine(subject_code);
		Console.WriteLine(number_session);
		
		
		for(int i=1; i< number_session+1 ; i++) {
			Console.WriteLine("Attence " + i + " contiunes ? yes[y] : no [n] ");
			string a = Console.ReadLine();
			if(a=="y") {
				sum = sum + 1;
			}
			else if(a=="n") {
				sum_a= sum_a + 1;
			}
			else {
				Console.WriteLine("Value not valied");
			}
		}
		
		per = ((float)((float)sum / (float)number_session) * 100 );
		
		Console.WriteLine("Total attandance for the subject: "+sum);
		Console.WriteLine("Total Absent of the Subject: "+sum_a);
		Console.WriteLine("Attendance persentage: " + per + "%");
		
		if(per > 80) {
			Console.WriteLine("The Candidate is Site for Exam");
		}
		else {
			Console.WriteLine("The Candidate is Not Site for Exam");
		}
		
			
			
			Console.WriteLine("Do you want to check more (Y/N)");
			check= Console.ReadLine();
			
		}
	 
	
	}
}