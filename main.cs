internal class Program
{
    private static void Main(string[] args)
    {
        string[] lista = new string[100];
        for (int i = 0; i < 1; i = 0)
        {
            Console.WriteLine("Escolhe a operação que voce quer fazer : ");
            Console.WriteLine("1 - Adicionar");
            Console.WriteLine("2 - Remover");
            Console.WriteLine("3 - Marcar Concluida ");
            Console.WriteLine("4 - Ver Tarefa ");
            int operação = int.Parse(Console.ReadLine());

            switch (operação)
            {
                case 1:
                    Console.WriteLine("Adicione uma tarefa a lista : ");
                    string tarefa = Console.ReadLine();
                    Console.WriteLine("Escolha qual espaço da lista de ser colocado a tarefa : ");
                    int num = int.Parse(Console.ReadLine());
                    lista[num] = tarefa;
                break;
                case 2:
                    Console.WriteLine("Escolha qual espaço da lista de ser removido da lista : ");
                    int tarefarem = int.Parse(Console.ReadLine());
                    lista[tarefarem] = "";
                break;
                case 3:
                    Console.WriteLine("Escolha qual espaço da lista de ser removido da lista : ");
                    int concluida = int.Parse(Console.ReadLine());
                    lista[concluida] = "Esta tarefa foi Concluida";
                break;
                case 4:
                    Console.WriteLine("Escolha qual espaço da lista para ser mostrado : ");
                    int ver = int.Parse(Console.ReadLine());
                    Console.WriteLine(lista[ver]);
                break;
            }
            Console.WriteLine("");
        }
    }
}