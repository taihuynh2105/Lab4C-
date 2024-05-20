class Program
{

    public class userDataLab4
    {
        public string Name;
        public int Level;
        public userDataLab4(string name, int level)

        {
            Name = name;
            Level = level;
        }
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        List<userDataLab4> list = new List<userDataLab4>();
        list.Add(new userDataLab4("GTA 5", 10));
        list.Add(new userDataLab4("Genshin Impact", 15));
        list.Add(new userDataLab4("Gunny", 5));
        list.Add(new userDataLab4("Liên Minh Huyền Thoại", 100));
        var selectedData = list.Select(u => new { u.Name, u.Level });
        foreach (var item in selectedData)
        {
            Console.WriteLine("| NameGame: " + item.Name + "| Level: " + item.Level);
        }

       
        var sapXep = list.OrderByDescending(u => u.Level);
        Console.WriteLine("\n Sắp xếp theo level giảm dần: ");
        foreach (var item in sapXep)
        {
            Console.WriteLine("| NameGame: " + item.Name + "| Level: " + item.Level);
        }

    }
}