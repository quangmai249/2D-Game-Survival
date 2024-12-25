using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speedMoving;
    private PlayerStats _playerStats;
    private void Awake()
    {
        this._playerStats = new PlayerStats(this.speedMoving);
    }
    private void FixedUpdate()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
            this.transform.Translate(Vector2.right * Input.GetAxisRaw("Horizontal") * this._playerStats.SpeedMoving * Time.deltaTime);
        if (Input.GetAxisRaw("Vertical") != 0)
            this.transform.Translate(Vector2.up * Input.GetAxisRaw("Vertical") * this._playerStats.SpeedMoving * Time.deltaTime);
    }
}
