using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
    int point = 10 ;
    public GameAlien gameku;
    public GameObject prefabExplosion;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "peluru")
        {
            //Mati
            var explosion = Instantiate(prefabExplosion);
            explosion.transform.position = this.transform.position;
            Destroy(this.gameObject);
            Destroy(collision.collider.gameObject);

            gameku.AddScore(point);
            gameku.AdaMusuhMati();
            //GameAlien.StaticAddScore(10)
            SoundController.instance.PlaySound(SFXType.SPLAT);
        }
        else
        {
            var explosion = Instantiate(prefabExplosion);
            explosion.transform.position = this.transform.position;
            Destroy(this.gameObject);
            gameku.AdaMusuhMati();
        }


    }
}
