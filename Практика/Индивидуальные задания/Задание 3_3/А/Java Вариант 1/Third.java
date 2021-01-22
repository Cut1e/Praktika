import java.util.Scanner;
public class Third {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		int [][] mas = new int [5][5];
		int c=0;
		int kol=0;
		 System.out.println("¬ведите значение c");
	     c=sc.nextInt();
		for(int i =0; i<mas.length; i++){
		for(int j =0; j<mas.length; j++){
		mas[i][j] = (int)(Math.random()*9-1);
		System. out.print(mas[i][j]+" ");
		}
		System.out.println();
		}
		for(int i =0; i<mas.length; i++)
			for(int j =0; j<mas.length; j++)
	if(mas[i][j]>c)
	{
	kol++;
	}
		 System.out.println("„исел больше c: "+kol);
	}
		
	}

