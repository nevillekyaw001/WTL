using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointSystem : MonoBehaviour
{
    public static PointSystem instance;
    public static int Coin = 0;
    public TextMeshProUGUI coinText;

    public bool level2 = false;
    public bool level3 = false;
    public bool level4 = false;
    public bool level5 = false;

    private void Awake()
    {
        //DontDestroyOnLoad(gameObject.transform);
        instance = this;
        
    }
    private void Start()
    {
        Coin = PlayerPrefs.GetInt("Coins");
        coinText.text = " " + Coin.ToString();
    }

    public void AddCoin(int CoinValue)
    {
        Coin += CoinValue;
        coinText.text = " " + Coin.ToString();
    }
    public static void UpdateCoins()
    {
        PlayerPrefs.SetInt("Coins", Coin);
        Coin = PlayerPrefs.GetInt("Coins");
        PlayerPrefs.Save();
    }

    
}
