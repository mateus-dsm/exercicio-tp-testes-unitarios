namespace Exercicio35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contactService = new ContactService();

            while (true)
            {
                Console.WriteLine("Gerenciador de Tarefas");
                Console.WriteLine("1 - Adicionar contato");
                Console.WriteLine("2 - Listar contatos");
                Console.WriteLine("3 - Atualizar contato");
                Console.WriteLine("4 - Remover contato");
                Console.WriteLine("5 - Sair");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Digite o contato a ser adicionado (nome, telefone e email):");
                        var retornoAdiciona = contactService.AddContact(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                        break;
                    case 2:
                        var lista = contactService.ListContacts();
                        Console.WriteLine("Lista de contatos:");
                        foreach (var contato in lista)
                        {
                            Console.WriteLine($"- {contato}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Digite o índice do contato a ser adicionado e suas novas informações (nome, telefone e email):");
                        var retornoAtualiza = contactService.UpdateContact(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Digite o índice do contato a ser removido:");
                        var retornoRemove = contactService.RemoveContact(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}