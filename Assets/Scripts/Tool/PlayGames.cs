using UnityEngine;
using System;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.UI;


public class PlayGames : MonoBehaviour
{
    

    public string leaderboardID = "CgkIh_6N8rcQEAIQAA";
    
    //public static PlayGamesPlatform platform;

    void Start()
    {

        //if (platform == null)
        //{
        //    //PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        //    //PlayGamesPlatform.InitializeInstance(config);
        //    //PlayGamesPlatform.DebugLogEnabled = true;
        //    //platform = PlayGamesPlatform.Activate();
        //}

        Social.Active.localUser.Authenticate(success =>
        {
            if (success)
            {
                Debug.Log("Logged in successfully");
            }
            else
            {
                Debug.Log("Login Failed");
            }
        });
        
    }

    public static void AddScoreToLeaderboard()
    {
        Debug.Log("This is from Play Games");

        if (Social.Active.localUser.authenticated)
        {
            
            Social.ReportScore(PlayerPrefs.GetInt("highScore"), "CgkIh_6N8rcQEAIQAA", success => { });
        }
    }

    public void ShowLeaderboard()
    {
        if (Social.Active.localUser.authenticated)
        {
            //platform.ShowLeaderboardUI();
        }
    }

}