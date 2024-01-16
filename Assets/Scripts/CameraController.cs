using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform cameraTarget;

    void LateUpdate()
    {
        if (cameraTarget != null)
        {
            transform.position = new Vector3(cameraTarget.position.x, transform.position.y, transform.position.z);
        }
    }
}
