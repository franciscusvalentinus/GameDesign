using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    private static SoundSystem sound;
    

    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this);
        if(sound == null)
        {
            sound = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

}
