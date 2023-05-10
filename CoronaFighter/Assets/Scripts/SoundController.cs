using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SFXType{
    EXPLOSION,
    LASER,
    SPLAT
}

public enum BGMType{
    BGMI
}


public class SoundController : MonoBehaviour
{
    public static SoundController instance;
    public AudioClip[] sfxClips;
    public AudioClip[] BGMClips;

    AudioSource[] audioSources;

    const int BGMChannel = 0;
    int countSFXCHannel = 4 ;
    int currChannel = 1;
    int currSFXChannel = 1;
    int maxSFXChannel = 4;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        DontDestroyOnLoad(this);

        audioSources = GetComponents<AudioSource>();
        audioSources [BGMChannel].loop = true ;
    }

    public void PlaySound(SFXType type){
        audioSources[currSFXChannel].clip = sfxClips[(int)type];
         audioSources[currSFXChannel].Play();

         currSFXChannel++;
         if (currSFXChannel >= maxSFXChannel)
         currSFXChannel = 1;
    }

     public void PlayBGM(BGMType type){
         audioSources[BGMChannel].clip = BGMClips[(int)type];
         audioSources[BGMChannel].Play();
    }

     public void SetMasterVolume(float volume){
        for (int i = 0 ; i <maxSFXChannel; i++){
            audioSources[i].volume = volume ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
