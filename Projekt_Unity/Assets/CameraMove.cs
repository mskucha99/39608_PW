using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    void Update()
    {
        PositionChanging();
    }

    void PositionChanging()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position = new Vector3(-40, 54, 0);
            transform.rotation = Quaternion.Euler(35, 135, 0);
        }
            
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position = new Vector3(40, 54, 0);
            transform.rotation = Quaternion.Euler(35, -135, 0);
        }
    }
}
