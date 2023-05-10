using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusTankCollision : MonoBehaviour
{
    public GameObject prefabExplosion;
    public int life = 3;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            if(life < 1)
            {
                var explosion = Instantiate(prefabExplosion);
                explosion.transform.position = this.transform.position;
                Destroy(this.gameObject);
                print("player Collided");
            }
            else
            {
                life -= 1;
            }

        }
        if (collision.collider.tag == "Bullet")
        {
            if(life < 1)
            {
                var explosion = Instantiate(prefabExplosion);
                explosion.transform.position = this.transform.position;

                Destroy(this.gameObject);
                Destroy(collision.collider.gameObject);
            }
            else
            {
                life -= 1;
            }

        }
    }
}
