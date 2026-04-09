namespace Week10;

public class Character
{
    public string Name { get; set; }
    public string Role { get; set; }
    public int Level { get; set; }
    public int MaxHealth { get; set; }
    public int  Health { get; set; }
    
    public int Gold { get; set; }
    public StatusCharacter Status { get; set; }

    public Character(string name, string role, int level, int health, int maxHealth, int gold, StatusCharacter status)
    {
        Name = name;
        Role = role;
        Level = level;
        MaxHealth = maxHealth;
        Health = health;
        Gold = gold;
        Status = status;
    }

    public void ChangeStatus()
    {
        if (Health < 0)
        {
            Status = StatusCharacter.Unconscious;
        }
        else if (Health < MaxHealth * 0.3)
        {
            Status = StatusCharacter.Wounded;
        }
        else
        {
            Status = StatusCharacter.Active;
        }
    }
    public override string ToString()
    {
        return $"{Name} ({Role}) " +
               $" Level: {Level} " +
               $" Health: {Health}/{MaxHealth} " +
               $" Gold: {Gold} " +
               $" Status: {Status}";
    }
}