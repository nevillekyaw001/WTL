using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    int score = 0;
    public int highScore = 0;
    
    

    private void Awake()
    {
        instance = this; //reference from Score script for addpoint() in hexagon script
    }

    // Start is called before the first frame update
    public void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore", 0); 
        scoreText.text = " "+ score.ToString(); //announce value of highscore in score gameobject
        highScoreText.text = "High Score : " + highScore.ToString(); //announce value of highscore in Highscore gameobject
        
     
    }

    //add point system for destorying enemies
    public void AddPoint(int Svalue) //argument in hexagon script
    {
        score += Svalue;
        scoreText.text = score.ToString();

        if (highScore < score)
        {
            PlayerPrefs.SetInt("highScore", score); // save hs vaule to highest in-game score value

            PlayGames.AddScoreToLeaderboard();
            Debug.Log("This is from scores");
        }

    }

    


    //save value of Last scene score for gameover scene
    public void OnDestroy()
    {
        PlayerPrefs.SetInt("GotScore", score);
    }

    //For Debugging Highscore value to 0
    public void ResetHS()
    {
        PlayerPrefs.SetInt("highScore", 0);
    }
}
