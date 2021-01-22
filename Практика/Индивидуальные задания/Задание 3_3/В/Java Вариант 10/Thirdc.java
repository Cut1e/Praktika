import java.util.Scanner;

public class Thirdc {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		int [][] mas = new int [5][5];
		int str=0;
		int stb=0;
		for(int i =0; i<mas.length; i++){
		for(int j =0; j<mas.length; j++){
		mas[i][j] = (int)(Math.random()*9-1);
		System. out.print(mas[i][j]+" ");
		}
		System.out.println();
		}
		
		for(int i =0; i<mas.length; i++)
			for(int j =0; j<mas.length; j++)
	if(i==0 && mas[i][j]>0)
	{
	str++;
	}
		System.out.println("Кол-во положительные первой строки: "+str);
		
	for(int i =0; i<mas.length; i++)
		for(int j =0; j<mas.length; j++)
if(j==2 && mas[i][j]%2==0)
{
stb++;
}
	System.out.println("Кол-во чётных 3 столбца: "+stb);
	int raznost=0;
	raznost=str-stb;
	System.out.println("разность: "+raznost);
	
}
}
