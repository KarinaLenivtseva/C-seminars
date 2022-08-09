Console.Clear();
string? YesOrNo = "";
while (YesOrNo.ToLower() != "yes" && YesOrNo.ToLower() != "no")
{
  Console.Write("Укажете интересующие строки? (yes/no): ");
  YesOrNo = Console.ReadLine();
}

string[] arrayOfStrings = new string[]  {};

if (YesOrNo.ToLower() == "yes") {
  int n = InputNumbers("Введите количество элементов массива: ");
  arrayOfStrings = new string[n];
  for (int i = 0; i < arrayOfStrings.Length; i++)
  {
    Console.Write($" Введите {i+1} строку: ");
    arrayOfStrings[i] = Console.ReadLine();
  }
}
else 
{
  arrayOfStrings = new string[]  {"hello", "2", "world", ":-)"};
}

int lengthLimit = 3;

int numbersItems = Array(arrayOfStrings, lengthLimit);

string[] newArrayOfStrings = new string[numbersItems];

FillNewArray(arrayOfStrings, newArrayOfStrings, lengthLimit);

Console.WriteLine($"{PrintArray(newArrayOfStrings)}");


void FillNewArray(string[] oldArray, string[] newArray, int lengthLimit)
{
  int temp = 0;
  for (int i = 0; i < oldArray.Length; i++)
  {
    if (oldArray[i].Length <= lengthLimit)
    {
      newArray[temp] = oldArray[i];
      temp++;
    }
  }
}

int Array(string[] array, int lengthLimit)
{
  int result = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= lengthLimit) result++;
  }
  return result;
}

string PrintArray(string[] array)
{ 
  string result = string.Empty;
  result = "[ ";
  for (int i = 0; i < array.Length; i++)
  {
    result += $"{array[i],1}";
    if (i < array.Length - 1) result += ", ";
  }
  result += " ]";
  return result;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
