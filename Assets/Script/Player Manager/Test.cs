using UnityEngine;

public class Test : BaseCharacters
{
    private float hp = 100;
    private float speedMoving = 10;
    private float range = 1;
    private float damage = 100;
    private float damageRate = 1;
    private float critRate = 1;
    private float critDamage = 1;

    private PlayerStats playerStats;
    private void Awake()
    {
        this.playerStats = new PlayerStats(hp, speedMoving, range, damage, damageRate, critRate, critDamage);
    }
    protected override void Start()
    {
        base.Start();
    }
    private void Update()
    {
        this.TakeDamage(this.playerStats.Damage);
    }
    protected override void TakeDamage(float amout)
    {
        base.TakeDamage(amout);
    }
}
