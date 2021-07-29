using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    public int degree;
    public bool right, left;

    void LateUpdate()
    {
        DetectSwipe();
        if(left)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(degree, -90, 0), .1f);

        }
        if (right)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(degree, -90, 0), .1f);
        }
    }

    public void DetectSwipe()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            left = true;
            right = false;
            degree += 90;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            left = false;
            right = true;
            degree -= 90;
        }
    }
}
