using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void LoadLevel(string GameScene)
    {
        StartCoroutine(LoadAsynchronously(GameScene));
    }

    IEnumerator LoadAsynchronously (string GameScene)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(GameScene);

        while (!operation.isDone)
        {
            Debug.Log("Scene is Loaded");
            yield return null;
        }
    }
}
