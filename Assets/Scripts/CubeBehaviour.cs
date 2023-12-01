using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    void FixedUpdate()
    {
        Vector3 vector = new Vector3(15, 30, 45);
        transform.Rotate(vector * 0.02f);
    }
}
