// Вид 1
void Method1(){
    Console.WriteLine("Автор Кондратьев Иван");
}
Method1();

// Вид 2
void Method2(string msg){
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count){
    
    int i = 0;
    while(i < count){
        Console.WriteLine(msg);
        i++;
    }
    
}
Method21("Текст сообщения", 4); //переменные по порядку, в котором рассположенны при введении метода
Method21(count: 4, msg:"Текст сообщения"); //обращение к переменной

//Вид 3

int Method3(){
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4

string Method4(int count, string text){
    int i = 0;
    string result = string.Empty;
    while(i<count){
        i++;
        result = result + text;
    }
    return result;
}
string res = Method4(10, "qwerty");
Console.WriteLine(res);

//цикл for собрали метод 4

string Method5(int count, string text){
    string result = string.Empty;
    for(int i = 0; i<count; i++){
        result = result + text;
    }    
    return result;
}
string res1 = Method5(10, "qwerty");
Console.WriteLine(res1);

//цикл в цикле с выводом таблицы умножения на экран

for(int i = 2; i <= 10; i++){
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}*{j}={i*j}");
    }
    Console.WriteLine(); // разделяем исскуственно циклы 
}

// Работа с текстом 
// Дан текст. В тексте нужно заменить все пробелы черточками, маленькие буквы "к" заменить большими,
// а большие "С" заменить маленькими.

string text = "- Я думаю, - сказал князь, улыбаясь, -что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//            012345
// s[3] = r

string Replace(string text, char oldValue, char newValue)
{
    string result1 = string.Empty;
    int lenght = text.Length;
    for(int i=0; i<lenght; i++)
    {
        if(text[i] == oldValue) result1 = result1 + $"{newValue}";
        else result1 = result1 + $"{text[i]}";
    }
    return result1;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'C', 'c');
Console.WriteLine(newText);

//сортировка массива от минимального к максимальному

int[] arr = {1, 5, 3, 2, 4, 8, 7, 6, 9, 1, 1};
void printArray(int[] array)
{
    int count = array.Length;
    for ( int g = 0; g < count; g++ )
    {
        Console.Write($"{array[g]} ");
    }
   Console.WriteLine(); 
}

void SelectionSort(int[] array)
{
    for ( int g = 0; g < array.Length - 1; g++ )
    {
        int minPosition = g;
        for ( int k = g+1; k < array.Length; k++ )
        {
            if(array[k]< array[minPosition]) minPosition =k;    
        }
        int temporary = array[g];
        array[g] = array[minPosition];
        array[minPosition] = temporary;
    }
}

printArray(arr);
SelectionSort(arr);
printArray(arr);


