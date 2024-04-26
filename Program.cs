string [] GetUserArray()
{
    Console.WriteLine("Введите элементы массива строк:");
    int count = 0;
    string[] array = new string[count];
    string[] arr = new string[count];     
    string s = "";
    do
    {
       s = Console.ReadLine();
       if (s!="")
       {
         count++;
         arr = new string [count];
         for (int i=0; i<arr.Length-1; i++)
         {
            arr[i] = array[i]; 
         }
         arr[count-1] = s;
         array = arr;    
       }
    } while (s!="");
    return arr;
}

void PrintArray (string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length-1)
        {
            Console.Write(array[i]);
        }
        else 
        {  
            Console.Write($"{array[i]}, ");
        }
    }
    Console.WriteLine("]");
}

string[] GetNewArr (string[] arr)
{
    int count = 0;
    string[] newarr = new string[count]; 
    string[] newarr2 = new string[count];
    //string s = "";
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            count++;
            newarr = new string [count];
            for (int j = 0; j < newarr.Length - 1; j++)
            {
                newarr[j] = newarr2 [j];
            }
            newarr [count-1] = arr [i];
            newarr2 = newarr; 
        }
    }
    return newarr;
}

string[] ArrayStr = GetUserArray();
string[] NewArr = GetNewArr(ArrayStr);
Console.Write("Исходный массив: ");
PrintArray (ArrayStr);
Console.Write("Новый массив: ");  
PrintArray (NewArr);