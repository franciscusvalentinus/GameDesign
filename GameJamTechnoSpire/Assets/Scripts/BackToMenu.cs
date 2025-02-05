using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMenu : MonoBehaviour
{
    public GameObject credit;

    public void OnPlayButton()
    {
        credit.SetActive(false);
    }
}
