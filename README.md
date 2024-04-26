# Итоговая контрольная работа по основному блоку
## ***Задача***
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

***Примеры:*** 

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

## Этапы решения:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

### 1. Создан репозиторий на GitHub

### 2. Блок-схема алгоритма решения: добавлен файл **diagram.drawio** в папку текущего репозитория.

### 3. Данный файл содержит текстовое описание решения.

### 4. Програмный код решения задачи

* Первоначальный  массив вводим с клавиатуры, для этого создаем функцию **GetUserArray**, которая будет запрашивать у пользователя ввести массив строк. Функция будет возвращать готовый сформированный массив строк, которые вводит пользователь с клавиатуры: 

``` C#
string [] GetUserArray() // Функция ввода массива строк с клавиатуры, которая возвращает полученный массив
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
```

* Пишем отдельный метод **PrintArray** для вывода массива на экран. В функцию передаем массив строк, в результате вызова функции переданный массив будет выводиться на экран в отформатированном виде:

``` C#
void PrintArray (string[] array) // Метод вывода массива на экран
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
```
* Создаем отдельный метод **GetNewArr**, который будет на вход принимать строковый массив и возвращать новый массив, который формируется из элементов исходного массива, длина которых равна или меньше 3.

Создаем ссылку ***count*** на текущее количество строк в новом массиве, который будем формировать из элементов исходного, удовлетворяющих нашему условию, и обнуляем его. 

Выделяем память для нуля строк, используем ссылки:

 `string[] newarr` и `string[] newarr2` - дополнительная переменная ссылка, которая будет сохранять старый массив строк, до добавления нового элемента. Эта часть кода будет выглядеть так:


``` C#
    int count = 0;
    string[] newarr = new string[count]; 
    string[] newarr2 = new string[count];
```

* Далее используем цикл ***for***, чтобы пройтись по всем элементам исходного массива:

```C#
for (int i = 0; i < arr.Length; i++)
```
 В цикле каждый элемент массива, нам нужно проверить, соответствует ли он нужному условию:

```C#
 if (arr[i].Length < 4)
```
1.  Если условие выполняется, то увеличиваем количество элементов в новом формируемом массиве, выделяем память для нового массива с количеством элементов ***count*** :

```C#
count++;
newarr = new string [count];
```
копируем временный массив, в котором на 1 элемент меньше, чем в новом формируемом в новый массив, а последнему элементу нового массива присваиваем значение данного i-того элемента исходного массива.
Во временный массив сохраняем получившийся новый массив:

```C#
for (int j = 0; j < newarr.Length - 1; j++)
     {
        newarr[j] = newarr2[j];
     }
    newarr [count-1] = arr [i];
    newarr2 = newarr; 
```
2. Если условие ***arr[i].Length < 4*** не выполняется, то возвращаемся в начало цикла и переходим к следующему элементу исходного массива в задаче. И повторяем проверку для следующего элемента.

* После того, как мы вышли из цикла, функция завершает свою работу и возвращает на выходе новый массив, который мы сформировали:

```
return newarr;
```
* После того, как у нас есть все необходимые функции, пропишем код основновной программы для решения задачи, используя вызов функций:

```C#
string[] ArrayStr = GetUserArray();//Вводим с клавиатуры исходный массив строк, используя функцию
string[] NewArr = GetNewArr(ArrayStr);//формируем новый массив, при помощи функции GetNewArr, передаем в нее исходный массив строк, на выходе получаем новый
Console.Write("Исходный массив: ");
PrintArray (ArrayStr);//На экран выводим Исходный массив, который ввели с клавиатуры
Console.Write("Новый массив: ");  
PrintArray (NewArr);//Выводим на экран новый массив, который сформирован из исходного по условию задачи - результат решения.
```
