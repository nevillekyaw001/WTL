using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SkinManager : MonoBehaviour
{
    public SpriteRenderer sr;
    public List<Sprite> skins = new List<Sprite>(); //lists of skins to choose and announce in unity
    private int selectedSkin = 0;
    public GameObject knobSkin; //to insert selectedSkin prefab
    public GameObject LoadingScreen;
    public Text text;
    public Slider slider;


    public void NextOption() //when click next
    {
        selectedSkin = selectedSkin + 1;
        if (selectedSkin == skins.Count)
        {
            selectedSkin = 0;
        }

        sr.sprite = skins[selectedSkin]; 
    }

    public void BackOption() //when click back
    {
        selectedSkin = selectedSkin - 1;
        if (selectedSkin < 0)
        {
            selectedSkin = skins.Count - 1;
        }

        sr.sprite = skins[selectedSkin];
    }

    void PlayGame(string GameScene)
    {
        
        
        StartCoroutine(LoadAsynchronously(GameScene));
    }

    

    IEnumerator LoadAsynchronously(string GameScene)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(GameScene);

        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 9f);
            slider.value = progress;
            yield return null;
        }
    }
}