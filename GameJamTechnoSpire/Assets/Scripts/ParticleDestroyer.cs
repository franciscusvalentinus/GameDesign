using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroyer : MonoBehaviour
{
    public float timer = 1f;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer == 0f)
        {
            Destroy(this.gameObject);
        }
    }
}
