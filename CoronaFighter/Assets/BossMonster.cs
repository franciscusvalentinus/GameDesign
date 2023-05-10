using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMonster : MonoBehaviour
{
    public GameAlien gameku;
    
    public GameObject prefabExplosion;
    int life =10;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "peluru")
        {
             if(life < 1)
            {
            //Mati
            var explosion = Instantiate(prefabExplosion);
            explosion.transform.position = this.transform.position;
            Destroy(this.gameObject);
            Destroy(collision.collider.gameObject);

            gameku.AddScore(100);
           
            //gameku.AdaMusuhMati();
            //GameAlien.StaticAddScore(10)
            }else{
                life -= 1;
                Destroy(collision.collider.gameObject);
            }
        }
        else
        {
            //var explosion = Instantiate(prefabExplosion);
           // explosion.transform.position = this.transform.position;
           // Destroy(this.gameObject);
            //gameku.AdaMusuhMati();
        }


    }

}
