using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameAlien : MonoBehaviour
{
    // Start is called before the first frame update
    int score = 0;
  //  int life = 3;
    public Text txtScore;
   // public Text txtLife;
    public GameObject[] prefabAliens;
    public GameObject[] prefabBoss;
    public GameOver over;
    float WorldWidth = 18;
    float WorldHeight = 10;
    int level = 1;
    //int levelboss = 1;
    int enemyDeadCounter = 0;
    int bossDeadCounter = 0;
    const float m_dropChance = 1f / 50f; 


    void Start()
    {
        StartLevel();
        //test
        txtScore.text = HighScore.global_score + "";
    }

    void StartLevel()
    {
        //Generate alien sebanyak level
        for(var i=0; i < level; i++)
        {
            GenerateAliens();
            GenerateBoss();
            
        }
        enemyDeadCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int scoreToAdd)
    {
        //test global
        HighScore.global_score += scoreToAdd;
         txtScore.text = HighScore.global_score + "";


        //score += scoreToAdd;

        //tampilkan di UI
       // txtScore.text = score + "";
    }

   /* public void AddLife(int lifeToAdd)
    {
        life += lifeToAdd;

        txtLife.text = life + "";
    }

    public static void StaticAddLife(int lifeToAdd)
    {
        
    }*/

    public static void StaticAddScore(int scoreToAdd)
    {
        
    }

    public void AdaMusuhMati()
    {
        enemyDeadCounter += 1;

        if(enemyDeadCounter == level)
        {
            level++;
            StartLevel();
        }
    }

    /* public void AdaBossMati()
    {
        bossDeadCounter += 1;

        if(bossDeadCounter == level)
        {
            level++;
            StartLevel();
        }
    }*/

    void GenerateAliens()
    {
        //generate alien baru
       var newAlien = Instantiate(prefabAliens[Random.Range(0, prefabAliens.Length)]);
        /*if(Random.Range(0f, 1f) <= m_dropChance )
        {
            // spawn a dropped item
            var newBoss = Instantiate(prefabBoss[prefabBoss.Length]);

            //game atas bawah
            newBoss.transform.position = new Vector3(Random.Range(3, WorldWidth/2),
                                                        Random.Range( -WorldHeight/2, WorldHeight/2),
                                                        0);

           newBoss.GetComponent<BossMonster>().gameku = this;
        }*/
        
        // var newAlien = Instantiate(prefabAliens[Random.Range(0, 4)]);
         //var newAlien = Instantiate(prefabAliens[4]);

        //ditaruh di tempat acak
       /* newAlien.transform.position = new Vector3(Random.Range(-WorldWidth/2, WorldWidth/2),
                                                    Random.Range(-WorldHeight/2, WorldHeight/2),
                                                    0);*/
        //game atas bawah
        newAlien.transform.position = new Vector3(Random.Range(0, WorldWidth/2),
                                                    Random.Range( -WorldHeight/2, WorldHeight/2),
                                                    0);

        newAlien.GetComponent<monster>().gameku = this;
    }

    void GenerateBoss()
    {
       if(Random.Range(0f, 1f) <= m_dropChance )
        {
            // spawn a dropped item
            var newBoss = Instantiate(prefabBoss[0]);

            //game atas bawah
            newBoss.transform.position = new Vector3(Random.Range(5, WorldWidth/2),
                                                        Random.Range( -WorldHeight/2, WorldHeight/2),
                                                        0);

           newBoss.GetComponent<BossMonster>().gameku = this;
        }
        //generate alien baru
        //var newAlien = Instantiate(prefabAliens[prefabAliens.Length]);
        // var newAlien = Instantiate(prefabAliens[0]);

        //ditaruh di tempat acak
       /* newAlien.transform.position = new Vector3(Random.Range(-WorldWidth/2, WorldWidth/2),
                                                    Random.Range(-WorldHeight/2, WorldHeight/2),
                                                    0);*/
        //game atas bawah
        //newAlien.transform.position = new Vector3(Random.Range(3, WorldWidth/2),
       //                                             Random.Range( -WorldHeight/2, WorldHeight/2),
       //                                             0);

       // newAlien.GetComponent<BossMonster>().gameku = this;
    }

    public void GameOver()
    {
        // over.ScoreFinal(score);
        SceneManager.LoadScene("GameOver");
        
        
    }
}
