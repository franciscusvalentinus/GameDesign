using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeluruVirus : MonoBehaviour
{
    Vector3 translationVec;
    float speed = 0.05f;
    float BATAS_KIRI = -10f;
    float vers = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += translationVec * speed;

        if(transform.localPosition.x < BATAS_KIRI) {
            Destroy(this.gameObject);
        }
    }

    public void TembakDari(Vector3 posAwal, Vector3 direction)
    {
        transform.localPosition = new Vector3(posAwal.x, posAwal.y, posAwal.z);

        translationVec = new Vector3(-Mathf.Cos(0), Mathf.Sin(0), 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            /*var explosion = Instantiate(prefabExplosion);
            explosion.transform.position = this.transform.position;*/
            Destroy(this.gameObject);
            
        }
        if (collision.collider.tag == "Bullet")
        {
            /*var explosion = Instantiate(prefabExplosion);
            explosion.transform.position = this.transform.position;*/
            Destroy(this.gameObject);
            Destroy(collision.collider.gameObject);
        }
    }
}
