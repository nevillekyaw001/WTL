using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public static PointSystem instance;
    public static int AdsPoints = 0;

    public bool level2 = false;
    public bool level3 = false;
    public bool level4 = false;
    public bool level5 = false;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject.transform);
        instance = this;
        


    }
    private void Start()
    {
        AdsPoints = PlayerPrefs.GetInt("AdsPoints");
        
    }



    public static void updateAdsPoints()
    {
        PlayerPrefs.SetInt("AdsPoints", AdsPoints);
        AdsPoints = PlayerPrefs.GetInt("AdsPoints");
        PlayerPrefs.Save();
    }

    
}
