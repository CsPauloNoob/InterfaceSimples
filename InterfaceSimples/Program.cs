namespace InterfaceSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string? option;
            var player = new Player();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - Open Inventory");
                Console.WriteLine("2 - Entrar na Loja");
                
                option = Console.ReadLine();

                switch (option)
                {
                    case "1": 
                        player.Inventario.Draw();
                        break;

                        case "2":
                            new Store(player).Draw();
                        break;

                    default:
                        Console.WriteLine("Escolha uma opção Válida!");
                        break;
                }
            }
        }
    }
}