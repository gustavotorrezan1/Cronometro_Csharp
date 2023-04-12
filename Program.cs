Menu();
static void Menu()
{
    Console.Clear();
    Console.WriteLine("Escolha como gostaria de ser contado");
    Console.WriteLine("1 = Segundo");
    Console.WriteLine("2 = Minuto");
    Console.WriteLine("0 = Sair");
    short.TryParse(Console.ReadLine(), out var tipo);
    //checa se pode sair do sistema
    if(tipo == 0){
        System.Environment.Exit(0);
    }
    Console.WriteLine("Quanto tempo gostaria de contar?");
    int.TryParse(Console.ReadLine(), out var tempo);
    switch (tipo)
    {
        case 1: Iniciar(tempo); break;
        case 2: Iniciar(tempo * 60); break;
        default:
            Console.WriteLine("Operação incorreta, Aperte qualquer botão para reiniciar");
            Console.ReadKey();
            Menu();
            break;
    }
}
static void Iniciar(int tempo)
{
    int tempoAtual = 0;
    while (tempoAtual != tempo)
    {
        Console.Clear();
        tempoAtual++;
        Console.WriteLine(tempoAtual);
        Thread.Sleep(1000);
    }
    Console.Clear();
    Console.WriteLine("Cronômetro finalizado");
    Thread.Sleep(2000);
}