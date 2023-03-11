internal class Program
{
    private static void Main(string[] args)
    {
        var nome = "";
        var opcao = "";

        Console.WriteLine("\n|======================================================================================| \n");
        Console.WriteLine("\n                     Olá, Seja Bem-Vindo ao Banco Brigant's");
        Console.WriteLine("     ----------------------------------------------------------------------\n\n");
        Console.Write("\n     Por favor digite seu nome: ");
        nome = Console.ReadLine();

       do{ 
        Console.WriteLine("\n\n                                   Menu opcões");
        Console.WriteLine("                 -------------------------------------------------\n\n");
        Console.WriteLine("  --------------------------------------------------------------------------------------");
        Console.WriteLine(" | 1 - Saque  |  2 - Deposito  |  3 - Transferencia  |  4 - Saldo da Conta  |  0 - Sair |");
        Console.WriteLine("  --------------------------------------------------------------------------------------\n\n");
        Console.Write("    "+ nome + ", por favor digite um opção: ");
        opcao = Console.ReadLine();
        Console.WriteLine("\n");
            switch(opcao)
            {
                case "1":
                Console.WriteLine("     ---> Saque Selecionado <---");
                break;

                case "2":
                Console.WriteLine("     ---> Deposito Selecionado <---");
                break;

                case "3":
                Console.WriteLine("     ---> Transferencia Selecionada <---");
                break;

                case "4":
                Console.WriteLine("    ---> Saldo em conta de R$ 1.556,00 <---");
                break;
            }  
        }      
        while(opcao != "0");   
        Console.WriteLine("\n   Banco Brigante Agradece, volte sempre " + nome +"!\n\n");     
    }
    
}