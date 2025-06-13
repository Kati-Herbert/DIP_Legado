using DIP_Legado;

class Program
{
    static void Main(string[] args)
    {
        IDevices lamp = new Lamp();

        Console.WriteLine("A lâmpada está desligada!");

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Ligar");
            Console.WriteLine("2 - Desligar");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    lamp.Ligar();
                    break;
                case "2":
                    lamp.Desligar();
                    break;
                case "3":
                    Console.WriteLine("Programa encerrado.");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}