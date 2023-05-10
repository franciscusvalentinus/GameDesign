using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] virus;
    public GameObject camera;
    float z_pos = 10f;

    float timer = 0f;
    int seconds;
    int random;

    float timer2 = 0f;
    int seconds2;
    int random2;

    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(0, 3);
        spawnPattern(random + 2);
    }

    // Update is called once per frame
    void Update()
    {
        //random = Random.Range(0, 3);
        //print(random + 2);
        
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;

        seconds = (int)(timer % 60);
        seconds2 = (int)(timer2 % 60);

        if (seconds >= 5)
        {
            seconds = 0;
            timer = 0;
            random = Random.Range(0, 3);
            //print(random + 2);
            spawnPattern(random + 2);
        }

        if (seconds2 >= 2)
        {
            seconds2 = 0;
            timer2 = 0;
            random2 = Random.Range(0, 3);
            spawnVirus(virus[random2], new Vector3(Random.Range(4.5f, 9f), Random.Range(-3.35f, 3.85f), 0f));
        }

        // untuk sementara, nanti pake random spawn per berapa detik
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            spawnPattern(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spawnPattern(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            spawnPattern(4);
        }
    }

    void spawnPattern(int pattern)
    {
        Vector3 pos;

        switch (pattern)
        {
            // random spawn
            case 1:
                break;

            // 2 dan seterusnya buat pattern
            case 2:
                // spawn virus 1
                spawnVirus(virus[0], new Vector3(5f, 0f, 0f));
                spawnVirus(virus[0], new Vector3(6.5f, -1.35f, 0f));
                spawnVirus(virus[0], new Vector3(6.5f, 1.35f, 0f));
                spawnVirus(virus[0], new Vector3(8f, -2.7f, 0f));
                spawnVirus(virus[0], new Vector3(8f, 2.7f, 0f));
                // spawn virus 2
                spawnVirus(virus[1], new Vector3(4.5f, 3.85f, 0f));
                spawnVirus(virus[1], new Vector3(6.5f, 3.85f, 0f));
                spawnVirus(virus[1], new Vector3(4.5f, -3.85f, 0f));
                spawnVirus(virus[1], new Vector3(6.5f, -3.85f, 0f));
                // spawn virus 3
                spawnVirus(virus[2], new Vector3(8, 0, 0));
                break;

            case 3:
                // spawn virus 1
                spawnVirus(virus[0], new Vector3(8.5f, 3f, 0));
                spawnVirus(virus[0], new Vector3(8.5f, 1.5f, 0));
                spawnVirus(virus[0], new Vector3(8.5f, -3f, 0));
                spawnVirus(virus[0], new Vector3(8.5f, -1.5f, 0));
                // spawn virus 2
                spawnVirus(virus[1], new Vector3(4.85f, 1f, 0));
                spawnVirus(virus[1], new Vector3(4.85f, -1f, 0));
                spawnVirus(virus[1], new Vector3(5.5f, 3.5f, 0));
                spawnVirus(virus[1], new Vector3(5.5f, -3.5f, 0));
                spawnVirus(virus[1], new Vector3(6.5f, 1f, 0));
                spawnVirus(virus[1], new Vector3(6.5f, -1f, 0));
                // spawn virus 3
                spawnVirus(virus[2], new Vector3(3.5f, 0, 0));
                spawnVirus(virus[2], new Vector3(5f, 3f, 0));
                spawnVirus(virus[2], new Vector3(5f, -3f, 0));
                break;

            case 4:

                // spawn virus 1
                spawnVirus(virus[0], new Vector3(9.5f, 3.75f, 0));
                spawnVirus(virus[0], new Vector3(9.5f, 1.5f, 0));
                spawnVirus(virus[0], new Vector3(9.5f, -1f, 0));
                spawnVirus(virus[0], new Vector3(9.5f, -3.35f, 0));
                spawnVirus(virus[0], new Vector3(8f, 2.65f, 0));
                spawnVirus(virus[0], new Vector3(8f, 0.25f, 0));
                spawnVirus(virus[0], new Vector3(8f, -2.25f, 0));
                spawnVirus(virus[0], new Vector3(6.5f, 3.75f, 0));
                spawnVirus(virus[0], new Vector3(6.5f, 1.5f, 0));
                spawnVirus(virus[0], new Vector3(6.5f, -1f, 0));
                spawnVirus(virus[0], new Vector3(6.5f, -3.35f, 0));
                spawnVirus(virus[0], new Vector3(5f, 2.65f, 0));
                spawnVirus(virus[0], new Vector3(5f, 0.25f, 0));
                spawnVirus(virus[0], new Vector3(5f, -2.25f, 0));
                break;
        }
    }

    void spawnVirus(GameObject virusType, Vector3 position)
    {
        //var newVirus1 = Instantiate(virusType);
        GameObject go = Instantiate(virusType,
                                    new Vector3(camera.transform.position.x + position.x,
                                                camera.transform.position.y + position.y,
                                                z_pos),
                                    Quaternion.identity) as GameObject;
        go.transform.parent = GameObject.Find("Main Camera").transform;
        //newVirus1.transform.position = position;
    }
}
