using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Preloading : MonoBehaviour
{
    

    public Slider slider;
    public GameObject LoadingScreen;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadAsynchronously());
        
    }

    public IEnumerator LoadAsynchronously()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(1);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 9f);
            slider.value = progress;
            yield return null;
        }
        
    }
}
