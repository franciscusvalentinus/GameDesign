using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    public ScoringSystem scoringSystem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Virus1")
        {
            /*var explosion = Instantiate(prefabExplosion);
            explosion.transform.position = this.transform.position;*/
            Destroy(this.gameObject);
            scoringSystem.AddScore(10);
        }
        if (collision.collider.tag == "Virus2")
        {
            /*var explosion = Instantiate(prefabExplosion);
            explosion.transform.position = this.transform.position;*/
            Destroy(this.gameObject);
            scoringSystem.AddScore(10);
        }
        if (collision.collider.tag == "Virus3")
        {
            /*var explosion = Instantiate(prefabExplosion);
            explosion.transform.position = this.transform.position;*/
            Destroy(this.gameObject);
            scoringSystem.AddScore(10);
        }
    }
}
