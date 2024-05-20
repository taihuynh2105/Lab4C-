class Program
{
    public class studentLab4
    {
        public string ID;
        public string Name;
        public int Age;
        public studentLab4(string ID, string Name, int Age)

        {
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;

        }
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        List<studentLab4> list = new List<studentLab4>();
        list.Add(new studentLab4("1", "Bảo Trâm", 13));
        list.Add(new studentLab4("2", "Quốc Trung", 12));
        list.Add(new studentLab4("3", "Huyền Trang", 15));
        list.Add(new studentLab4("4", "Gia Lâm", 20));
        list.Add(new studentLab4("5", "Vân Anh", 16));

        var query = from ds in list
                    where ds.Age >12 && ds.Age <20
                    select ds;

        foreach (var ds in query)
        {
            Console.WriteLine("Danh sách học sinh lớn hơn 12 tuổi và bé hơn 20 tuổi: |Tên: " + ds.Name + " |Tuổi: " + ds.Age);
        }
        var danhsach = list.Where(student => student.Age > 12 && student.Age < 20);

        foreach (var student in danhsach)
        {
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");

        }

    }
}