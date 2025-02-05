using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus2Behavior : MonoBehaviour
{
    private Vector3 translationVec;
    public GameObject prefabPeluruMonster;
    public GameObject FirePoint;
    private float timer = 2f;

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
        if(timer <= 0)
        {
            var peluruBaru = Instantiate(prefabPeluruMonster);
            peluruBaru.GetComponent<PeluruVirus>().TembakDari(FirePoint.transform.position, -translationVec);
            //print("Firepoint X : " + FirePoint.transform.position.x);
            //print("Firepoint Y : " + FirePoint.transform.position.y);
            //print("Firepoint Z : " + FirePoint.transform.position.z);
            timer = 3f;
        }
    }
}
