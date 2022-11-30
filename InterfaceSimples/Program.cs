namespace InterfaceSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string? option;
            var player = new Inventario();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - Open Inventory");
                Console.WriteLine("2 - Enter Store");

                option = Console.ReadLine();

                switch (option)
                {
                    case "1": 
                        new Inventario().Draw();
                        break;

                    default:
                        Console.WriteLine("Escolha uma opção Válida!");
                        break;
                }
            }

        }
    }
}