import java.util.Scanner;

public class Second2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
        double y=0;double x=-2;
    	System.out.println("Таблица значений");
    	System.out.println("_____________________________");
    	System.out.println("Аргумент           "+"Функция");
    	System.out.println("_____________________________");
    	        		while(x<4)
    	        		{
    	        			y=(2*Math.PI)/(Math.pow(x, 2)-Math.PI);
    	        			System.out.printf("X="+"%8.3f",x);
    	        			System.out.printf("        Y="+"%8.3f",y);
    	        			System.out.println("");
    	        	x+=0.5;
    	        		}
    	        		System.out.println("_____________________________");
    	        		System.out.println("Составил Буцаев В.И.");
	}

}
