using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float sensitivityRoll = 100f;
    public float sensitivityYaw = 100f;
    public float sensitivityPitch = 100f;
    void Update()
    {
        transform.rotation *= Quaternion.AngleAxis( Time.deltaTime * sensitivityRoll * Input.GetAxis("Vertical"), Vector3.forward );
        transform.rotation *= Quaternion.AngleAxis( Time.deltaTime * sensitivityYaw * Input.GetAxis("Mouse X"), Vector3.up );
        transform.rotation *= Quaternion.AngleAxis( Time.deltaTime * sensitivityPitch * Input.GetAxis("Mouse Y"), Vector3.left );
        //Debug.Log("Camera rotation: "+transform.rotation);
    }
}
