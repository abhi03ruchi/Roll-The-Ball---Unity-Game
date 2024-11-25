using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;
    public float xOffset , yOffset, zOffset;

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + new Vector3(xOffset, yOffset, zOffset);
        transform.LookAt(target.transform.position);
    }
}
