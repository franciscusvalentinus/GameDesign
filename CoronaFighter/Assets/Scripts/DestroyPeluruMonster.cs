using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPeluruMonster : MonoBehaviour
{
    public GameObject prefabExplosion;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "peluru")
        {
            
            var explosion = Instantiate(prefabExplosion);
            explosion.transform.position = this.transform.position;
            Destroy(this.gameObject);
            Destroy(collision.collider.gameObject);
        }
        else
        {
            var explosion = Instantiate(prefabExplosion);
            explosion.transform.position = this.transform.position;
            Destroy(this.gameObject);
        }
    }
}
