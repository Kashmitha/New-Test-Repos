int[] arr = { 4, 5, 2, 1, 5, 4, 7, 8, 9, 6 };
int sum = 0;

foreach (int i in arr)
{
    if(i%2 == 0)
    {
        sum += i;
    }
}
    Console.WriteLine(sum);
