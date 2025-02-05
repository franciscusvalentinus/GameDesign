using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAwal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //  SoundController.instance.PlayBGM(BGMType.BGMI);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlayButton()
    {
        SceneManager.LoadScene("GameSceneNew");
    }
}
