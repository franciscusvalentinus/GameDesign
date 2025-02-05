using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, startpos;
    public GameObject cam;
    public float parallaxEffect;

    private void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;

    }

    private void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 + parallaxEffect));
        float dist = (cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startpos - dist, transform.position.y, transform.position.z);

        if (temp > startpos + length)
        {
            startpos += length;

        }
        else if (temp < startpos - length)
        {
            startpos -= length;
        }

    }


    /*    float speed = 0.020f;
        float batasKiri = -23.42f;
        float batasKanan = 52.84f;
        Vector3 translationVec;
        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            //float temp = (cam.transform.position.x * (1 - parallaxEffect));
            //float dist = (cam.transform.position.x * parallaxEffect);

            //transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);
            if (transform.localPosition.x <= batasKiri)
            {
                transform.localPosition = new Vector3(batasKanan, transform.localPosition.y, transform.localPosition.z);
            }


            translationVec = new Vector3(-3, 0, 0);

            transform.localPosition += translationVec * speed;
        }*/
}
