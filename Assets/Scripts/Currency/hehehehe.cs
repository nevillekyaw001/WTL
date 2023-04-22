using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class hehehehe : MonoBehaviour
{
    public TextMeshProUGUI point;
    public SpriteRenderer sr;
    public Sprite[] newSprites;
    int ads;
    int level;
    
    

    // Start is called before the first frame update
    void Awake()
    {

        point.text = "Coins : " + PointSystem.Coin.ToString();
        sr = GetComponent<SpriteRenderer>();
        ads = PlayerPrefs.GetInt("Coins");
        
    }


    
    public void ResetADspoint()
    {
        PlayerPrefs.SetInt("Coins", 0);
        
    }
}
