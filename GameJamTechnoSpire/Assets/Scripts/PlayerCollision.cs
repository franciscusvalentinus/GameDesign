using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public GameObject prefabExplosion;
    public GameObject lifesys;
    public Text textlife;
    public ScoringSystem scoringSystem;
    

    // Start is called before the first frame update
    void Start()
    {
        textlife.text = "" + lifesys.GetComponent<LifeSystem>().life;
        print(lifesys.GetComponent<LifeSystem>().life);
    }

    private void Update()
    {
        textlife.text = "" + lifesys.GetComponent<LifeSystem>().life;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 translationvec = new Vector3(collision.collider.transform.position.x, collision.collider.transform.position.y, 0);
        if (collision.collider.tag == "Virus1")
        {
            if(lifesys.GetComponent<LifeSystem>().life == 1)
            {
                var explosion = Instantiate(prefabExplosion);
                explosion.transform.position = translationvec;
                Destroy(this.gameObject);
                GameOver();
            }
            else
            {
                var explosion = Instantiate(prefabExplosion);
                explosion.transform.position = translationvec;
                lifesys.GetComponent<LifeSystem>().life -= 1;
            }
        }
        if (collision.collider.tag == "Virus2")
        {
            if (lifesys.GetComponent<LifeSystem>().life == 1)
            {
                var explosion = Instantiate(prefabExplosion);
                explosion.transform.position = translationvec;
                Destroy(this.gameObject);
                GameOver();
            }
            else
            {
                var explosion = Instantiate(prefabExplosion);
                explosion.transform.position = translationvec;
                lifesys.GetComponent<LifeSystem>().life -= 1;
            }
        }
        if (collision.collider.tag == "Virus3")
        {
            if (lifesys.GetComponent<LifeSystem>().life == 1)
            {
                var explosion = Instantiate(prefabExplosion);
                explosion.transform.position = translationvec;
                Destroy(this.gameObject);
                GameOver();
            }
            else
            {
                var explosion = Instantiate(prefabExplosion);
                explosion.transform.position = translationvec;
                lifesys.GetComponent<LifeSystem>().life -= 1;
            }
        }
        if (collision.collider.tag == "Vbullet")
        {
            if (lifesys.GetComponent<LifeSystem>().life == 1)
            {
                var explosion = Instantiate(prefabExplosion);
                explosion.transform.position = translationvec;
                Destroy(this.gameObject);
                GameOver();

            }
            else
            {
                var explosion = Instantiate(prefabExplosion);
                explosion.transform.position = translationvec;
                lifesys.GetComponent<LifeSystem>().life -= 1;
            }
        }
        textlife.text = "" + lifesys.GetComponent<LifeSystem>().life;
    }

    public void GameOver()
    {
        PlayerPrefs.SetInt("MyScore", scoringSystem.score);
        SceneManager.LoadScene("GameOverScene");
    }
}
