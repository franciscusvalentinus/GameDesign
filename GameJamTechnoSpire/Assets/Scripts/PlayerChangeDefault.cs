using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChangeDefault : MonoBehaviour
{
    public static bool CharacterChanged = false;

    public GameObject[] playerUI;
    public GameObject lifesys;

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

        if (collision.collider.tag == "ItemHealth")
        {
            lifesys.GetComponent<LifeSystem>().life += 1;

        }
    }
}
