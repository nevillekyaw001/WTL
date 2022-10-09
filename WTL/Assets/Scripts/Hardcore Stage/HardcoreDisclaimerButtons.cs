using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HardcoreDisclaimerButtons : MonoBehaviour
{
    public Slider loading;
    public GameObject LoadingScreen;

    private void Awake()
    {
        AdmobManager.instance.ShowInterstitialAd();
    }

    // Start is called before the first frame update
    public void PlayHardcore()
    {

        StartCoroutine(LoadAsynchronously());
    }

    public void Back()
    {

        SceneManager.LoadScene("StartMenu");
    }

    public IEnumerator LoadAsynchronously()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(9);

        while (!operation.isDone)
        {
            LoadingScreen.SetActive(true);
            float progress = Mathf.Clamp01(operation.progress / 9f);
            loading.value = progress;

            yield return null;
        }
    }

}
