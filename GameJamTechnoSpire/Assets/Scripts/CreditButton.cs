using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditButton : MonoBehaviour
{
    public GameObject credit;

    public void OnPlayButton()
    {
        credit.SetActive(true);
    }
}
