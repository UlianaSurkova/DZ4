//Console.WriteLine("сумма цифр в числе");
Console.Write("Введите число K ");
int numberK = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberK){
    
    int counter = Convert.ToString(numberK).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numberK - numberK % 10;
      result = result + (numberK - advance);
      numberK = numberK / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberK);
Console.WriteLine("Сумма цифр " + sumNumber);
