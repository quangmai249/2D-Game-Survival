public class PlayerStats
{
    private float speedMoving;

    public PlayerStats(float speedMoving)
    {
        this.speedMoving = speedMoving;
    }
    public float SpeedMoving { get => this.speedMoving; set => this.speedMoving = value; }
}
