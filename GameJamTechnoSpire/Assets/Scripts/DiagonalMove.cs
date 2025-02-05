using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiagonalMove : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 0.01f;
    float BATAS_KANAN = 6f;
    float BATAS_KIRI = -6f;
    float BATAS_ATAS = 3f;
    float BATAS_BAWAH = -3f;
    int directx = 1, directy = 1;
    Vector3 translationVec;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.x > BATAS_KANAN)
        {
            // Buat Gerakan ke Kiri
            /*translationvec = new Vector3(-1, 0, 0);*/
            directx = -1;
        }

        if (transform.localPosition.x < BATAS_KIRI)
        {
            // Buat Gerakan ke Kanan
            //translationvec = new Vector3(1, 0, 0);
            directx = 1;
        }
        if (transform.localPosition.y > BATAS_ATAS)
        {
            //Buat Gerakan ke bawah
            //translationvec = new Vector3(0, -1, 0);
            directy = -1;
        }

        if (transform.localPosition.y < BATAS_BAWAH)
        {
            //Buat gerakan ke atas
            //translationvec = new Vector3(0, 1, 0);
            directy = 1;
        }

        translationVec = new Vector3(directx, directy, 0);
        transform.localPosition += translationVec * speed;
    }
}
