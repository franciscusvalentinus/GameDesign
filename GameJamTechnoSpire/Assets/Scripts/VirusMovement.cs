using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusMovement : MonoBehaviour
{
    float speed;
    // virus 1 yang buta
    // virus 2 yang bisa nembak
    // virus 3 yang lambat
    public GameObject virus1, virus2, virus3;
    float BATAS_KANAN = 10f;
    float BATAS_KIRI = -10f;
    float BATAS_ATAS = 5f;
    float BATAS_BAWAH = -5f;
    int directx = 1, directy = 1;
    Vector3 translationVec;
    // Start is called before the first frame update
    void Start()
    {
        if(this.gameObject == virus1)
        {
            speed = 0.12f;
        }else if(this.gameObject == virus2)
        {
            speed = 0.09f;
        }else if(this.gameObject == virus3)
        {
            speed = 0.0075f;
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(this.gameObject == virus1 || this.gameObject == virus3)
        {
            translationVec = new Vector3(-1, 0, 0);
        }

        if(this.gameObject == virus2)
        {
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
            translationVec = new Vector3(0, directy, 0);
        }

        transform.localPosition += translationVec * speed;
    }
}
