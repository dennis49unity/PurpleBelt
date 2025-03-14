using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Target Object")]
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        if (target.position.y > transform.position.y)
        {
            transform.position = new Vector3(0, target.position.y, -10f);
        }
    }
}
