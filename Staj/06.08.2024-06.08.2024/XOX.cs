using System;
class HelloWorld {
  static void Main() {
    char[,] numbers = {{' ',' ',' '},{' ',' ',' '},{' ',' ',' '}};
    do 
    {
        //Hamle Algoritması
      try
      {
        Console.WriteLine("Hamle İçin Sütun Yazınız.");
        int sutun = int.Parse(Console.ReadLine());
        Console.WriteLine("Hamle İçin Satır Yazınız.");
        int satır = int.Parse(Console.ReadLine());
        Console.WriteLine("Hamle Yazınız (X or O).");
        char hamle = Console.ReadKey().KeyChar;
        if(numbers[satır-1,sutun-1]==' ')
        {
            if(hamle == 'X' || hamle == 'O')
            {numbers[satır-1,sutun-1]=hamle;}
            else
            {
                Console.WriteLine("Lütfen X veya O Giriniz");
            }
        }
        else
        {
            Console.WriteLine("\nLütfen Boş Bir Yer Seçiniz.");
        }
        Console.WriteLine("-----------------------------");
        //numbers[satır-1,sutun-1]=hamle;
        Console.Write("  1  2  3\n");
        for(int i=0;i<3;i++){
            Console.Write(i+1);
            for(int j=0;j<3;j++){ 
                 Console.Write( " "+numbers[i,j]+" ");
            }
            Console.Write("\n");
        }
      }
      catch(FormatException ex){Console.WriteLine("Lütfen Sayıyla Giriş Yapınız.");}
      catch(IndexOutOfRangeException ex){Console.WriteLine("\nLütfen İstenilen Değerlerden Birini Giriniz.");}
      catch(OverflowException ex){Console.WriteLine("\nLütfen İstenilen Değerlerden Birini Giriniz.");}
        // 1.Satır
       /* if(sutun == sutun1 && satır == satır1){Console.Write(numbers[4,0]);}
        if(sutun == sutun2 && satır == satır1){Console.Write(numbers[4,1]);}
        if(sutun == sutun3 && satır == satır1){Console.Write(numbers[4,2]);}
        // 2.Satır
        //if(sutun == sutun1 && satır == satır2){sutundegeri=numbers[4,0];}
        //if(sutun == sutun2 && satır == satır2){sutundegeri2=numbers[4,1];}
        //if(sutun == sutun3 && satır == satır2){sutundegeri3=numbers[4,2];}
       
        Console.Write("   "+numbers[0,1]);
        Console.Write("   "+numbers[0,2]+"\n");
        Console.WriteLine("\n"+numbers[1,0]+"  "+sutundegeri+"   "+sutundegeri2+"   "+sutundegeri3+"\n");
        Console.WriteLine(numbers[1,1]+"\n");
        Console.WriteLine(numbers[1,2]+"\n");*/
    }
    while (true);
    
  }
}