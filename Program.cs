// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длинна которых меньше или равна 3 символа
string[] ss={"Hello", "sho", "sf", "sdaad", "123", "1234","e"};
void Stringlength(string[]a)
{
 for (int i=0;i < ss.Length; i++)
    if (ss[i].Length <= 3)
    System.Console.Write($"{ss[i]}  ");
}    
Stringlength(ss);