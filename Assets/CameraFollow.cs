using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;//follow this target
    public Vector3 offsrt;//use this distance from the target
    public float smothSpeed = 0.125f;

    //runs right after update
    void LateUpdate()
    {
        transform.position = target.position + offsrt;
    }
}