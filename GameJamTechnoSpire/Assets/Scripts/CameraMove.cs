using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Vector3 translationVec;
    float speed = 0.020f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        translationVec = new Vector3(3, 0, 0);

        transform.localPosition += translationVec * speed;
    }
}
