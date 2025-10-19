namespace Consolas;

class Entity(string name)
{
  private int _attack;
  private int _health = 100;
  public string EntityName { get; set; } = name;
  public int EntityHealth { get => _health; set
  {
    if (_health < 0)
    {
       value = 0; 
    }
    else if (_health > 100)
    {
       value = 100; 
    }
  } 
  }
  public virtual string DisplayName() => EntityName;
  public virtual int Attack(int attack){
    _attack = attack;
    return _attack;
  }
}

class Player(string name) : Entity(name)
{
  public string PlayerName { get; set; } = name;
  public override string DisplayName() => PlayerName;
}

class Enemy(string name) : Entity(name)
{

}


