import java.util.Scanner;
public class First {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		 Scanner sc = new Scanner(System.in);
	        int x=0;double f=0; double u=0;double xn=0;
	        System.out.println("Введите значение x");
	        x=sc.nextInt();
	        		if (x>2) 
	        		{
	        		u=Math.atan(x);
	        		System.out.println("Первое условие ");
	        		}      	       		
	        		if (x<=2)
	        		{
	        			for (int k=1; k<5; k++)
	        			{
	        			u+=k*Math.pow(x, 2)-x+k;
	        			}
	        		
	        	
	        			System.out.println("Второе условие ");
	        		}
	    	        	while(xn<5)
	    	        	{ 
	    	        		f+=1.5*Math.abs(Math.sin(u));
	    	        		System.out.printf(" Ответ: "+"%f" , f);
	    	        		System.out.println("");
	    	        		xn+=0.25; 
	        		}
	    	        		       	
	        }	

	}


