using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TouchtoContinue : MonoBehaviour
{
    public static TouchtoContinue instance;

    public GameObject Credit;
    
    
    

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void TTC(int number)
    {
        if (number == 1)
        {
            SceneManager.LoadScene("Skin");
            
        }

        if (number == 2)
        {
            SceneManager.LoadScene("HardcoreDisclaimer");
            
        }
    }
    
    public void highScore()
    {
        SceneManager.LoadScene("HighScore");
    }
    public void Info()
    {
        SceneManager.LoadScene("Information");
    }

    public void CreditTrue()
    {
        Credit.SetActive(true);
    }

    public void CreditFalse()
    {
        Credit.SetActive(false);
    }

    public void OpenFB (string link)
    {
        Application.OpenURL(link);
    }

    public void OpenDiscord(string link)
    {
        Application.OpenURL(link);
    }


}
