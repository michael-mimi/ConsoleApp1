
namespace Out
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> {"Milk", "Bread", "Nuts" };
            int index = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals("nut"))
                {
                    index = i;
                }
            }
            Console.WriteLine(index > -1 ? "Found": "Not Found");
        }

    }
}
