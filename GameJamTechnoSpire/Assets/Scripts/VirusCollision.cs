using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusCollision : MonoBehaviour
{
    public GameObject prefabExplosion;
    public AudioSource death;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            death.Play();
            var explosion = Instantiate(prefabExplosion);
            explosion.transform.position = this.transform.position;
            Destroy(this.gameObject);
            print("player Collided");

        }
        if (collision.collider.tag == "Bullet")
        {
            death.Play();
            var explosion = Instantiate(prefabExplosion);
            explosion.transform.position = this.transform.position;
            
            Destroy(this.gameObject);
            Destroy(collision.collider.gameObject);

        }
    }
}
