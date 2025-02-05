using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvoGreenBehavior : MonoBehaviour
{
    private Vector3 translationVec;
    public GameObject prefabPeluruMonster;
    private float timer = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
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
        timer = 5f;
     }
 }
}
