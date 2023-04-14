using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandMaster : MonoBehaviour
{
    public GameObject catimg;

    // Start is called before the first frame update
    void Awake()
    {
        if (PlayerPrefs.GetInt("CGM") == 1)
        {
            catimg.SetActive(true);
        }
    }

}
