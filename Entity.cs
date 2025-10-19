namespace Consolas;

class Entity(string name)
{
  private int _attack;
  private int _mana;
  private int _health;
  public required string EntityName { get; set; } = name;
  public int EntityHealth { get => _health; set => _health = value;}
  public int EntityMana{ get => _mana; set => _mana = value; }
  public virtual string DisplayName() => EntityName;
  public virtual int Attack(int attack){
    _attack = attack;
    return _attack;
  }
  public int TakeDamage()
  {
    int takeDamage = _health - Attack(_attack);
    return takeDamage;
  }
}

class Player(string name) : Entity(name)
{
  public string PlayerName { get; set; } = name;
  public override string DisplayName() => PlayerName;
  public override int Attack(int attack) => attack;
}

class Enemy(string name) : Entity(name)
{
  public string EnemyName {get;set;} = name;
  public override string DisplayName() => EnemyName;
  public override int Attack(int attack) => attack;
}


