using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShotgun : MonoBehaviour
{
    float speed;
    float bullet_speed;
    float batasAtas = 3.50f;
    float batasBawah = -3.00f;
    Vector3 translationVec;
    public GameObject prefabPeluru;
    public GameObject firePoint;
    public ScoringSystem scoringSystem;
    public Animator animator;
    public ParticleSystem particleSystem;
    public AudioSource shotgun;

    [SerializeField]
    private Transform barrel;

    [SerializeField]
    private Rigidbody2D bullet;


    // Start is called before the first frame update
    void Start()
    {
        particleSystem.Stop();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            speed = 0.075f;
            animator.SetBool("Jump", true);
        }
        else
        {
            //entah kenapa play sama stop nya kebalik, kalau diplay, malah stop
            particleSystem.Play();
        }

        translationVec = new Vector3(0, 1, 0);

        transform.localPosition += translationVec * speed;

        if (transform.localPosition.y < batasBawah)
        {
            speed = 0f;
            animator.SetBool("Jump", false);
        }
        else
        {
            speed = -0.075f;
            //particleSystem.Stop();
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            bullet_speed = 100f;
            for (int i = 0; i <= 2; i++)
            {
                var spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
               
                switch (i)
                {
                    case 0:
                        spawnedBullet.AddForce(new Vector2(300f, -90f));
                        //spawnedBullet.AddForce(barrel.up * bullet_speed + new Vector3(300f, -90f, 0f));
                        break;
                    case 1:
                        spawnedBullet.AddForce(new Vector2(300f, 0f));
                        break;
                    case 2:
                        spawnedBullet.AddForce(new Vector2(300f, 90f));
                        break;
                }
                //spawnedBullet.GetComponent<Jarum>().TembakDari(firePoint, translationVec);
                spawnedBullet.GetComponent<BulletDestroy>().scoringSystem = scoringSystem;
            }

            shotgun.Play();

            //Tembak
            //Buat pelurunya

            //set awal dan arah dari peluru
            

        }

    }
}
