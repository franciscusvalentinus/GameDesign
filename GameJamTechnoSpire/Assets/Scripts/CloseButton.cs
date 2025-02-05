using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public GameObject help1;
    public GameObject help2;
    public GameObject help3;
    public GameObject help4;

    public void OnPlayButton()
    {
        help1.SetActive(false);
        help2.SetActive(false);
        help3.SetActive(false);
        help4.SetActive(false);
    }
}
