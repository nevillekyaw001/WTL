using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScore : MonoBehaviour
{
    public SpriteRenderer sr;
    public Text highScoreText;
    int hs;
    public Sprite[] sprites;
    public Text rankName;
    public Text levelUp;
    
    private int rankNumber = 0;

    

    private void Awake()
    {
        AdmobManager.instance.ShowRewardedAd();
        highScoreText.text = "Highscore : " + PlayerPrefs.GetInt("highScore").ToString();
        sr = GetComponent<SpriteRenderer>();
        hs = PlayerPrefs.GetInt("highScore");
        updateImage();
        
    }
    

    public void updateImage()
    {
        if (hs < 25)
        {
            rankName.text = "Rank - Rabbit".ToString();
            levelUp.text = "Get 25 scores for next rank";
        }
        if (hs >= 25)
        {
            rankNumber = 0;
            sr.sprite = sprites[rankNumber];
            rankName.text = "Rank - Raccoon".ToString();
            levelUp.text = "Get 50 scores for next rank";
        }

        if (hs >= 50)
        {
            rankNumber = 1;
            sr.sprite = sprites[rankNumber];
            rankName.text = "Rank - Doge".ToString();
            levelUp.text = "Get 75 scores for next rank";
        }

        if (hs >= 75)
        {
            rankNumber = 2;
            sr.sprite = sprites[rankNumber];
            rankName.text = "Rank - Monkey".ToString();
            levelUp.text = "Get 100 scores for next rank";
        }
        if (hs >= 100)
        {
            rankNumber = 3;
            sr.sprite = sprites[rankNumber];
            rankName.text = "Rank - Piggy".ToString();
            levelUp.text = "Get 125 scores for next rank"; 
        }
        if (hs >= 125)
        {
            rankNumber = 4;
            sr.sprite = sprites[rankNumber];
            rankName.text = "Rank - Bear".ToString();
            levelUp.text = "Get 150 scores for next rank";
        }
        if (hs >= 150)
        {
            rankNumber = 5;
            sr.sprite = sprites[rankNumber];
            rankName.text = "Rank - Panda".ToString();
            levelUp.text = "Get 300 scores for next rank";
        }
        if (hs >= 300)
        {
            rankNumber = 6;
            sr.sprite = sprites[rankNumber];
            rankName.text = "Rank - Elephant".ToString();
            levelUp.text = "Get 500 scores for next rank";
        }
        if (hs >= 500)
        {
            rankNumber = 7;
            sr.sprite = sprites[rankNumber];
            rankName.text = "Rank - G.O.A.T".ToString();
            levelUp.text = "You've reached the maximum level!";
        }

    }
    public void back()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
