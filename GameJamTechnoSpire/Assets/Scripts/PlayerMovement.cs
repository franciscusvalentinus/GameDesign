using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed;
    float batasAtas = 3.50f;
    float batasBawah = -3.00f;
    Vector3 translationVec;
    public GameObject prefabPeluru;
    public GameObject firePoint;
    public ScoringSystem scoringSystem;
    public Animator animator;
    public ParticleSystem particleSystem;
    public AudioSource bang;

    // Start is called before the first frame update
    void Start()
    {
        particleSystem.Stop();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow)){
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
            //Tembak
            //Buat pelurunya
            var peluruBaru = Instantiate(prefabPeluru);

            //set awal dan arah dari peluru
            peluruBaru.GetComponent<BulletMove>().TembakDari(firePoint, translationVec);
            peluruBaru.GetComponent<BulletDestroy>().scoringSystem = scoringSystem;

            bang.Play();
        }
        
    }
}
