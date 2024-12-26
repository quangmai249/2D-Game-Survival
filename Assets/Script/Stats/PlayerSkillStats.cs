public class PlayerSkillStats
{
    private float countDown;
    private float damage;
    private float range;
    public PlayerSkillStats() { }
    public PlayerSkillStats(float countDown, float damage, float range)
    {
        this.CountDown = countDown;
        this.Damage = damage;
        this.Range = range;
    }
    public float CountDown { get => countDown; set => countDown = value; }
    public float Damage { get => damage; set => damage = value; }
    public float Range { get => range; set => range = value; }
}
