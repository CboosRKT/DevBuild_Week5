namespace Pizzazz
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

    }



    public class ProgName
    {
        string Name { get; set; }
        int Length { get; set; }
        int TotLenght { get; set; }
        public string TopLine { get; set; }

        public ProgName(string _name)
        {
            this.Name = _name;
            this.Length = _name.Length;
            this.TotLenght = Length + 37;

            string _topline = "*****   ****************";
            for (int i = 0; i <= Length; i++)
            {
                _topline = _topline + "*";
            }
            _topline = _topline + "******   *****\n";
            string botLine = _topline;
            _topline = _topline + "*****   ***** DevBuild 8 " + Name + " *****   *****\n";
            _topline = _topline + botLine;

            this.TopLine = _topline;
        }

        public void PrintHead()
        {

            Console.Clear();
            Console.WriteLine(TopLine);

        }

        public void PrintHead(string _menu, out string uInput)
        {

            Console.Clear();
            Console.WriteLine(TopLine);
            Console.WriteLine(_menu);
            uInput = Console.ReadLine();


        }


    }




}