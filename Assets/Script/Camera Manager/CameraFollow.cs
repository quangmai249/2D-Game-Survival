using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] float speedZoom;
    private Transform playerPos;
    private void Start()
    {
        this.playerPos = GameObject.FindGameObjectWithTag(NameManager.PlayerTag).GetComponent<Transform>();
    }
    private void Update()
    {
        this.ZoomCamera();
    }
    private void FixedUpdate()
    {
        this.CameraMoving();
    }
    private void CameraMoving()
    {
        this.transform.position = this.posCamera();
    }
    private Vector3 posCamera()
    {
        return new Vector3(this.playerPos.position.x, this.playerPos.position.y, this.transform.position.z);
    }
    private void ZoomCamera()
    {
        this.GetComponent<Camera>().orthographicSize -= this.speedZoom * Input.mouseScrollDelta.y * Time.deltaTime;
    }
}
