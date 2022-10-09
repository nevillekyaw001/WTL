using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    
    // Start is called before the first frame update

    

    public void Pause()
    {
        bool ableToMove = GameObject.FindWithTag("Player").GetComponent<Player>().ableToMove;
        pauseMenu.SetActive(true);
        ableToMove = false;
        Time.timeScale = 0f;

    }

    public void Resume()
    {

        
        bool ableToMove = GameObject.FindWithTag("Player").GetComponent<Player>().ableToMove;
        
        pauseMenu.SetActive(false);    
        ableToMove = true;
        StartCoroutine(WaitForSecond());

    }

    IEnumerator WaitForSecond()
    {
        float endpause = Time.realtimeSinceStartup + 3;
        while (Time.realtimeSinceStartup < endpause)
        {
            yield return 0;
        }
        Time.timeScale = 1f;
    }

}
