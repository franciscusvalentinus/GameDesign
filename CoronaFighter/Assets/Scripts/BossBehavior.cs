using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    private Vector3 translationVec;
    public GameObject prefabPeluruMonster;
    public GameObject prefabPeluruBoss;
    private float timer = 3f;
    private float timer2 = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        Attack2();
        
    }
     private void Attack()
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                var peluruBaru = Instantiate(prefabPeluruMonster);
                // Spawn Bullet or whatever else
                peluruBaru.GetComponent<PeluruMonster>().TembakDari(transform.localPosition, translationVec);
                // peluruBaru.GetComponent<BulletMove>().TembakDari(transform.localPosition, translationVec);
               // peluruBaru.GetComponent<SpriteRenderer>().color = Color.red;
                timer = 3f;
            }
            
        }

        private void Attack2()
        {
            timer2 -= Time.deltaTime;

            if (timer2 <= 0)
            { 
                var peluruBaru2 = Instantiate(prefabPeluruBoss);
                // Spawn Bullet or whatever else
                peluruBaru2.GetComponent<PeluruBoss>().TembakDariBoss(transform.localPosition, translationVec);
                // peluruBaru.GetComponent<BulletMove>().TembakDari(transform.localPosition, translationVec);
               // peluruBaru2.GetComponent<SpriteRenderer>().color = Color.red;

                timer2 = 1f;
            }
            
        }
}
