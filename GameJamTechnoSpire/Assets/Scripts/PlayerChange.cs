using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChange : MonoBehaviour
{
    public static bool CharacterChanged = false;

    public GameObject[] playerUI;
    public float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 15.0f)
        {
            timer = 0;
            playerUI[0].SetActive(true);
            playerUI[1].SetActive(false);
            playerUI[2].SetActive(false);
            timer = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.tag == "ItemShotgun")
        {
            playerUI[0].SetActive(false);
            playerUI[1].SetActive(true);
            playerUI[2].SetActive(false);
            Destroy(collision.collider.gameObject);
            
        }

        if (collision.collider.tag == "ItemThrower")
        {
            playerUI[0].SetActive(false);
            playerUI[1].SetActive(false);
            playerUI[2].SetActive(true);
            Destroy(collision.collider.gameObject);
            
        }
    }
}
