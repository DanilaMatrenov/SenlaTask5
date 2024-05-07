Console.Write("Введите длину интервала ");
int end=int.Parse(Console.ReadLine());
int start = 0;
if (end <= 100)
{
    countPal(start, end);
}
else
{
    Console.WriteLine("По условиям задачи длина не должна быть больше 100");
}

 static int CheckPal(int num)
{
    int back = 0;
    for (int i = num; i > 0;i /= 10)
    {
        back = back * 10 + i % 10;
        
    }
    if (num == back)
    {
        return 1;
    }
    else
    {
        return 0;
    }

}
static void countPal(int st,int nd)
{
    for(int i=st;i<=nd;i++)
    {
        if(CheckPal(i)==1)
        {
            Console.Write(i + " ");
        }
    }
}
