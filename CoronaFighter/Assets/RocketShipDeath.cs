using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RocketShipDeath : MonoBehaviour
{
    public GameObject prefabExplosion;
     int life = 3;
     public Text textlife;
     public GameAlien gameku;
     //public GameOver over;
    // public GameAlien games;

    void Start()
    {
        textlife.text = "" + life;
    }
     

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "alien" )
        {
            if(life == 1)
            {
                var explosion = Instantiate(prefabExplosion);
                explosion.transform.position = this.transform.position;
                Destroy(this.gameObject);

                //Cara Barbar
                //SceneManager.LoadScene("GameOver");

                //Cara lebih pro
                gameku.GameOver();
            }
            else
            {
                life -= 1;
                
            }
           // games.AddLife(1);
            
        }

         if(collision.collider.tag == "gpeluru" )
        {
            if(life == 1)
            {
                Destroy(collision.collider.gameObject);
                var explosion = Instantiate(prefabExplosion);
                explosion.transform.position = this.transform.position;
                Destroy(this.gameObject);
                Destroy(collision.collider.gameObject);

                //Cara Barbar
                SceneManager.LoadScene("GameOver");

                //Cara lebih pro
                //gameku.GameOver();
            }
            else
            {
                life -= 1;
                Destroy(collision.collider.gameObject);
                
            }
            //games.AddLife(1);
            
        }
        textlife.text = "" + life;
    }

}
