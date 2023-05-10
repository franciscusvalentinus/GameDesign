using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text highScore;
    //public GameAlien gameku;
    int score ;
    // Start is called before the first frame update
    void Start()
    {
        highScore.text = HighScore.global_score+ "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreFinal (){
        HighScore.global_score ++;
        highScore.text = HighScore.global_score + "";
    }

    public void OnBackToMenu()
    {
         HighScore.global_score = 0;
        SceneManager.LoadSceneAsync("MenuAwal");
    }
}
