using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] float speedZoom;
    private Transform playerPos;
    [SerializeField] int smooth;
    Vector3 offSet;
    private void Start()
    {
        this.playerPos = GameObject.FindGameObjectWithTag(NameManager.PlayerTag).GetComponent<Transform>();
        offSet = this.transform.position - this.playerPos.position;
    }
    private void Update()
    {
        this.ZoomCamera();
    }
    private void FixedUpdate()
    {
        this.transform.position = this.posCamera();
    }

    private Vector3 posCamera()
    {
        Vector3 targetCam = this.playerPos.position + offSet;
        return Vector3.Lerp(this.transform.position, targetCam, smooth * Time.deltaTime);
    }
    private void ZoomCamera()
    {
        this.GetComponent<Camera>().orthographicSize -= this.speedZoom * Input.mouseScrollDelta.y * Time.deltaTime;
    }
}
