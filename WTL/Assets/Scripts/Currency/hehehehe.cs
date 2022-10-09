using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hehehehe : MonoBehaviour
{
    public Text point;
    public SpriteRenderer sr;
    public Sprite[] newSprites;
    int ads;
    int level;
    
    

    // Start is called before the first frame update
    void Awake()
    {

        point.text = "Ads Points : " +PointSystem.AdsPoints.ToString();
        sr = GetComponent<SpriteRenderer>();
        ads = PlayerPrefs.GetInt("AdsPoints");
        
    }


    
    public void ResetADspoint()
    {
        PlayerPrefs.SetInt("AdsPoints", 0);
        
    }
}
