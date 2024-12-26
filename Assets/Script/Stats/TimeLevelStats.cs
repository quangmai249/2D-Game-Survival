public class TimeLevelStats
{
    private float countTine;
    private float maxCountTime;
    public TimeLevelStats() { }
    public TimeLevelStats(float countTine, float maxCountTime)
    {
        this.CountTine = countTine;
        this.MaxCountTime = maxCountTime;
    }
    public float CountTine { get => countTine; set => countTine = value; }
    public float MaxCountTime { get => maxCountTime; set => maxCountTime = value; }
}
