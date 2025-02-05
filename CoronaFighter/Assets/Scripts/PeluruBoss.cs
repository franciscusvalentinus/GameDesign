using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeluruBoss : MonoBehaviour
{
     Vector3 translationVec;
    //float speed = 0.1f;
    float speed = 0.01f;
    float Batas_Kanan = 9f;
    float Batas_Kiri = -9f;
    float Batas_Atas = 5f;
    float Batas_Bawah = -5f;
    float vers= 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += translationVec * speed;

        if (transform.localPosition.x > Batas_Kanan || transform.localPosition.x < Batas_Kiri || 
            transform.localPosition.y > Batas_Atas || transform.localPosition.y < Batas_Bawah)
        {
            Destroy(this.gameObject);
        }
    }

     public void TembakDariBoss (Vector3 posAwal, Vector3 direction)
    {
        transform.localPosition = new Vector3(posAwal.x, posAwal.y, posAwal.z);
        // transform.localPosition = new Vector3(0, posAwal.y, 0);


        translationVec = new Vector3(-direction.x - vers, direction.y, direction.z);
       // translationVec = new Vector3(direction.x, 0,0);
    }
}
