using System.IO;
using System;

class Program
{
    static void Main()
    {
        while(true){
            Console.WriteLine("Введите номер задачи: ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 0:
                  System.Environment.Exit(1);
                  break;
                case 1:
                  task1();
                    break;
                case 2:
					        task2();
                    break;
                case 3:
                  task3();
                    break;
                case 4:
                  task4();
                    break;
                case 5:
                  task5();
                    break;
                case 6:
                  task6();
                    break;
                case 7:
                  task7();
                    break;
            
                default:
               		Console.WriteLine("Введите значение от 0 до 10!");
                    break;
			}
        }
    }
    
    static void task1(){
		string original_string = "Я буду усердно делать все задания по C# и заниматься дома";
		Console.WriteLine("Введите строку: ");
		string input_string = Console.ReadLine();
		if(String.Equals(original_string, input_string)){
			Console.WriteLine("За это ты получишь печеньку");
		}
		else{
			Console.WriteLine("За это ты не получишь печеньку");
		}
	}
	static void task2(){
		Console.WriteLine("Камень(1), Ножницы(2) или Бумага(3): ");
		int input = int.Parse(Console.ReadLine());
		Random rnd = new Random();
		int random_int = rnd.Next(1, 4);
		if(input == random_int){
      Console.WriteLine(String.Format("Ты выбрал {0}, Я выбрал {1}", input, random_int));
			Console.WriteLine("Ничья");
		}
		else{
			if(input == 1){
				if(random_int == 2){
          Console.WriteLine(String.Format("Ты выбрал {0}, Я выбрал {1}", input, random_int));
					Console.WriteLine("Ты победил!");
				}
				else{
          Console.WriteLine(String.Format("Ты выбрал {0}, Я выбрал {1}", input, random_int));
					Console.WriteLine("Ты проиграл!");
				}
			}
			else{
				if(input == 2 ){
          if(random_int == 3){
          Console.WriteLine(String.Format("Ты выбрал {0}, Я выбрал {1}", input, random_int));
					Console.WriteLine("Ты победил!");
				  }
				  else{
            Console.WriteLine(String.Format("Ты выбрал {0}, Я выбрал {1}", input, random_int));
					  Console.WriteLine("Ты проиграл!");
				  }
				}
        else{
          if(input == 3){
            if(random_int == 1){
              Console.WriteLine(String.Format("Ты выбрал {0}, Я выбрал {1}", input, random_int));
					    Console.WriteLine("Ты победил!");
				    }
				    else{
              Console.WriteLine(String.Format("Ты выбрал {0}, Я выбрал {1}", input, random_int));
					    Console.WriteLine("Ты проиграл!");
				    }
          }
        }
			}
		}
	}
  static void task3(){
		Console.WriteLine("Приближенная значение равно: ");
    for(int i = 0; i < 10000; i++){

    }
  }

  static void task4(){

  }

  static void task5(){

  }

  static void task6(){
    int[] arr1 = new int[9];
    int[] arr2 = new int[9];
    int[] arr3 = new int[9];
    Random rnd = new Random();
    for(int i = 0; i < 10; i++){
      arr1[i] = rnd.Next(10000000000);
    }
    Console.WriteLine("Массив 1: ");
    for(int i = 0; i < 10; i++){
      Console.WriteLine(String.Format("Ячейка[{0}] - Значение: ", i, arr1[i]));
    }

  }

  static void task7(){
    
  }
}
