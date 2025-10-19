namespace Consolas;

public enum Options
{
  Start,
  Exit
}
class UI
{
  readonly Game game = new();
  public Options PlayerOptions(string? options) =>
  options switch
  {
    "Exit" => game.ExitGame(),
    "Start" => game.StartGame(),
    _ => throw new ArgumentException("No arguments for option ", nameof(options)),
  };
  public void ShowUI()
  {
    List<int> bullets = [1,2];
    Console.WriteLine($"{bullets[0]}. Start Game");
    Console.WriteLine($"{bullets[1]}. Exit Game");
    PlayerOptions(Console.ReadLine());
  }

}

class Game
{
  public Options ExitGame()
  {
    Environment.Exit(0);
    return Options.Exit;
  }
  public Options StartGame()
  {
    Console.WriteLine($"welcome to Consolas");
    return Options.Start;
  }
}
