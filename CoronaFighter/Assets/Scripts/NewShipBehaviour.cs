using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewShipBehaviour : MonoBehaviour
{
    private Vector3 translation;
    private Vector3 translationVec;
    float speed;
    float angle;
    public GameObject prefabPeluru;
    public GameObject prefabExplosion;
    //double directionX = 1;
    //double directionY = 1;
    float var = 0.025f;
   // float cpt = 0.01f;
    private float timer = 0.2f;
    int tambah ;

    // Start is called before the first frame update
    void Start()
    {
       // speed = Random.Range(0.01f, 0.05f);
        //gerak atas bawah
      //   translationVec = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        //ujung layar kembali
        if (transform.position.x > 10)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        if(transform.position.y > 5)
        {
            transform.position = new Vector3(transform.position.x, -5, transform.position.z);
        }
        if (transform.position.x < -10)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }
        if (transform.position.y < -5)
        {
            transform.position = new Vector3(transform.position.x, 5, transform.position.z);
        }
        
        //gerak ke kanan
        //transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);

        //rotasi
      //  transform.rotation = Quaternion.Euler(0, 0, angle * (180 / Mathf.PI));

        //Rotate translation vector according to the angle
       /* Vector3 translationVec = new Vector3(Mathf.Cos(angle),
                                                Mathf.Sin(angle),
                                                0);*/
      // Vector3 translationVec = new Vector3(0,transform.position.y ,0);
                                                
      // transform.position += translationVec * speed;
      //transform.localPosition = new Vector3(transform.position.x, transform.position.y , transform.position.z);

       
        //react berdasarkan input
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            angle += 0.05f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            angle -= 0.05f;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            //gerak atas bawah
           // transform.position = new Vector3(transform.position.x, transform.position.y + var, transform.position.z);
            transform.localPosition = new Vector3(transform.position.x, transform.position.y + var, transform.position.z);
            //gvelocity = cepat;
           // speed += 0.01f;
            if (speed > 1) speed = 1;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //gerak atas bawah
         // transform.position = new Vector3(transform.position.x, transform.position.y - var, transform.position.z);
           transform.localPosition = new Vector3(transform.position.x, transform.position.y - var, transform.position.z);
           // gvelocity = -cepat;
           // speed -= 0.01f;
            if (speed < 0) speed = 0;
        }
       /* else if (Input.GetKeyDown(KeyCode.Space))
        {
            var peluruBaru = Instantiate(prefabPeluru);

            peluruBaru.GetComponent<BulletMove>().TembakDari(transform.localPosition, translationVec);
           // peluruBaru.GetComponent<BulletMove>().TembakDari(transform.localPosition, translationVec);
            peluruBaru.GetComponent<SpriteRenderer>().color = Color.red;
        }*/



         timer -= Time.deltaTime;
        if (timer <= 0)
        {
           var peluruBaru = Instantiate(prefabPeluru);

           //peluruBaru.GetComponent<BulletMove>().TembakDari(transform.localPosition, translationVec);
           peluruBaru.GetComponent<BulletMove>().TembakDari(transform.localPosition, translationVec);
           SoundController.instance.PlaySound(SFXType.LASER);
           
            //peluruBaru.GetComponent<SpriteRenderer>().color = Color.red;

            timer = 0.2f;
        }
       
    }

   

    
}
