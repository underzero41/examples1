//нахождение индекса по запрашиваемому числу

int[] array = {11,21,61,14,51,61,17,18};
int n = array.Length;
int find = 61;
int index = 0;
while(index<n)
{
    
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}
