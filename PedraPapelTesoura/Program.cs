
//Console.WriteLine("Hello World");
return1:
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("=".PadLeft(27,'='));
Console.WriteLine("- PEDRA, PAPEL OU TESOURA -");
Console.WriteLine("=".PadLeft(27,'='));
Console.ResetColor();

return2:
Console.WriteLine("        Vamos jogar!");
Console.Write("\nPedra, Papel ou Tesoura?\n\nSua jogada: ");
string jogadausuario = Console.ReadLine().ToLower();
int nju;
Random randNum = new Random();
int jogadasistema = randNum.Next(1, 4);

if (jogadausuario == "pedra")
{
    nju = 1;

    if (jogadasistema == nju)
    {
        Console.WriteLine("Jogada do computador: Pedra");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n- EMPATE -");
        Console.WriteLine("- jogo reiniciado -\n");
        Console.ResetColor();
        goto return1;
    }
    else
    {
        if (jogadasistema == 2)
        {
            Console.WriteLine("Jogada do computador: Papel");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nVOCÊ PERDEU!\n");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Jogada do computador: Tesoura");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nVOCÊ GANHOU!\n");
            Console.ResetColor();
        }
    }
}
else if (jogadausuario == "papel")
{
    nju = 2;

    if (jogadasistema == nju)
    {
        Console.WriteLine("Jogada do computador: Papel");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n- EMPATE -");
        Console.WriteLine("- jogo reiniciado -\n");
        Console.ResetColor();
        goto return1;
    }
    else
    {
        if (jogadasistema == 1)
        {
            Console.WriteLine("Jogada do computador: Pedra");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nVOCÊ GANHOU!\n");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Jogada do computador: Tesoura");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nVOCÊ PERDEU!\n");
            Console.ResetColor();
        }
    }
}
else if (jogadausuario == "tesoura")
{
    nju = 3;

    if (jogadasistema == nju)
    {
        Console.WriteLine("Jogada do computador: Tesoura");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n- EMPATE -");
        Console.WriteLine("- jogo reiniciado -\n");
        Console.ResetColor();
        goto return1;
    }
    else
    {
        if (jogadasistema == 1)
        {
            Console.WriteLine("Jogada do computador: Pedra");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nVOCÊ PERDEU!\n");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Jogada do computador: Papel");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nVOCÊ GANHOU!\n");
            Console.ResetColor();
        }
    }
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n- O valor inserido não é válido, tente novamente -\n");
    Console.ResetColor();
    goto return2;
}
return3:
Console.Write("Deseja continuar jogando? (responda com S ou N) ");
string recomecar = Console.ReadLine().ToLower();
if (recomecar == "s")
{
    Console.Clear();
    goto return1;
}
else if (recomecar == "n")
{
    Console.Clear();
    Console.WriteLine("\nok ;)\n");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n- O valor inserido não é válido, tente novamente -\n");
    Console.ResetColor();
    goto return3;
}