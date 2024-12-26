public class EnemyStats : EnemyMoveSet
{
    private int hp;
    private float speed;
    private float damage;
    private float damageRate;
    public EnemyStats() { }
    public EnemyStats(int hp, float speed, float damage, float damageRate)
    {
        this.Hp = hp;
        this.Speed = speed;
        this.Damage = damage;
        this.DamageRate = damageRate;
    }
    public int Hp { get => hp; set => hp = value; }
    public float Speed { get => speed; set => speed = value; }
    public float Damage { get => damage; set => damage = value; }
    public float DamageRate { get => damageRate; set => damageRate = value; }
    public void ComboFirst()
    {
        throw new System.NotImplementedException();
    }
    public void ComboSecond()
    {
        throw new System.NotImplementedException();
    }
}
