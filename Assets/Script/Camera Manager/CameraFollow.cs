using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform playerPos;
    [SerializeField] float speedZoom;
    private void Update()
    {
        this.GetComponent<Camera>().orthographicSize -= this.speedZoom * Input.mouseScrollDelta.y * Time.deltaTime;
    }
    private void FixedUpdate()
    {
        this.transform.position = this.posCamera();
    }
    private Vector3 posCamera()
    {
        return new Vector3(this.playerPos.position.x, this.playerPos.position.y, this.transform.position.z);
    }
}
