class Program
{
    static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
        var newList = list.FindAll(item => item % 2 == 0);
        foreach (var item in newList)
        {
            Console.WriteLine("Cac so chan trong danh sach: " + item);
        }
    }
}