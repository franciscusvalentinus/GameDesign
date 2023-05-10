using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawn : MonoBehaviour
{

    public GameObject[] spot;
    public GameObject[] bubble;
    float timer = 0f;
    int seconds;
    int random_bubble;
    int random_spot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        seconds = (int)(timer % 60);

        if (seconds >= 20)
        {
            seconds = 0;
            timer = 0;
            random_bubble = Random.Range(0, 3);
            random_spot = Random.Range(0, 3);
            print("Bubble " + random_bubble + " spawned at spot " + random_spot);
            //print(random + 2);
            var bubble_baru = Instantiate(bubble[random_bubble]);
            bubble_baru.transform.position = new Vector3(spot[random_spot].transform.position.x,
                                                      spot[random_spot].transform.position.y,
                                                      0);
        }
    }
}
