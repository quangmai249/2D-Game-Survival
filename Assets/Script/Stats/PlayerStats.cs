public class PlayerStats
{
    private int hp;
    private float speedMoving;
    private float range;
    private float damage;
    private float damageRate;
    private float critRate;
    private float critDamage;
    public PlayerStats() { }
    public PlayerStats(int hp, float speedMoving, float range, float damage, float damageRate, float critRate, float critDamage)
    {
        this.Hp = hp;
        this.SpeedMoving = speedMoving;
        this.Range = range;
        this.Damage = damage;
        this.DamageRate = damageRate;
        this.CritRate = critRate;
        this.CritDamage = critDamage;
    }
    public int Hp { get => hp; set => hp = value; }
    public float SpeedMoving { get => speedMoving; set => speedMoving = value; }
    public float Range { get => range; set => range = value; }
    public float Damage { get => damage; set => damage = value; }
    public float DamageRate { get => damageRate; set => damageRate = value; }
    public float CritRate { get => critRate; set => critRate = value; }
    public float CritDamage { get => critDamage; set => critDamage = value; }
}
