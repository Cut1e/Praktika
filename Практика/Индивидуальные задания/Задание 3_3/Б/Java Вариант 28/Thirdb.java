import java.util.Scanner;

public class Thirdb {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		int [][] mas = new int [5][5];
		int ch=0;
		int nch=1;
		for(int i =0; i<mas.length; i++){
		for(int j =0; j<mas.length; j++){
		mas[i][j] = (int)(Math.random()*9+1);
		System. out.print(mas[i][j]+" ");
		}
		System.out.println();
		}
		
		for(int i =0; i<mas.length; i++)
			for(int j =0; j<mas.length; j++)
	if(i==j && mas[i][j]%2==0)
	{
	ch+=mas[i][j];
	}
		System.out.println("Произведение четных: "+ch);
		
		for(int i =0; i<mas.length; i++)
			for(int j =0; j<mas.length; j++)
		if(i==j && mas[i][j]%2!=0)
		{
		nch*=mas[i][j];
		}
		System.out.println("Произведение не четных: "+nch);
		int raznost=0;
		raznost=ch-nch;
		raznost=Math.abs(raznost);
		 System.out.println("Модуль разности: "+raznost);
	}

}
