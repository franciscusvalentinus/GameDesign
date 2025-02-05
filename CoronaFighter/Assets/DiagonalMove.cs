using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiagonalMove : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 0.01f;
    float Batas_Kanan = 9f;
    float Batas_Kiri = -9f;
    float Batas_Atas = 5f;
    float Batas_Bawah = -5f;
    Vector3 translationVec;
    int directionX = 1, directionY = 1;
   

    void Start()
    {
        translationVec = new Vector3(directionX, directionY, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.x > Batas_Kanan || transform.localPosition.x < Batas_Kiri)
        {
            directionX = -directionX;
        }

        if (transform.localPosition.y > Batas_Atas || transform.localPosition.y < Batas_Bawah)
        {
            directionY = -directionY;
        }

       
       // translationVec = new Vector3(-directionX, 0, 0);
        translationVec = new Vector3(directionX, directionY, 0);
        translationVec = new Vector3(-directionX, -directionY, 0);
        
        transform.localPosition += translationVec * speed;
    }
}
