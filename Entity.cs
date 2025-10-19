namespace Consolas;

class Entity(string name)
{
  public string EntityName { get; set; } = name;
}

class Player(string name) : Entity(name)
{
  public string PlayerName { get; set; } = name;
  public string DisplayName() => PlayerName;
}


