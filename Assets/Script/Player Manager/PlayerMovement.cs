using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speedMoving;
    private PlayerStats _playerStats;
    private Rigidbody2D _playerRigid;
    private void Awake()
    {
        this._playerStats = new PlayerStats(this.speedMoving);
        this._playerRigid = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        this.Move();
    }
    private void Move()
    {
        this._playerRigid.linearVelocityX = Input.GetAxisRaw("Horizontal") * this._playerStats.SpeedMoving;
        this._playerRigid.linearVelocityY = Input.GetAxisRaw("Vertical") * this._playerStats.SpeedMoving;
    }
}
