namespace InterfaceSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string? option;
            Player player1 = new Player();
            var player = new Inventario();

            player1.Inventario.Itens.Add(1,new Item("HP", 150));
            player1.Inventario.Itens.Add(2,new Item("MN", 150));
            player1.Inventario.Itens.Add(3,new Item("Espada", 350));
            player1.Inventario.Itens.Add(4,new Item("Katana", 400));
            player1.Inventario.Itens.Add(5,new Item("Shuriken", 100));
            player1.Inventario.Itens.Add(6,new Item("PC Gamer", 15000));


            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - Open Inventory");
                Console.WriteLine("2 - Enter Store");

                option = Console.ReadLine();

                switch (option)//fix
                {
                    case "1":
                        player1.Inventario.Draw();
                        break;

                    default:
                        Console.WriteLine("Escolha uma opção Válida!");
                        break;
                }
            }

        }
    }
}