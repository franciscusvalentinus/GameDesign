using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jarum : MonoBehaviour
{
    float speed = 0.5f;
    Vector3 translationVec;
    float BATAS_KANAN = 10f;
    //float BATAS_KIRI = -9f;
    //float BATAS_ATAS = 5f;
    //float BATAS_BAWAH = -5f;
    public GameObject firePoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.localPosition += translationVec * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "BatasKanan")
        {
            Destroy(this.gameObject);
        }
    }

    public void TembakDari(GameObject posAwal, Vector3 direction)
    {
        translationVec = new Vector3(direction.x, direction.y, direction.z);
    }

}
