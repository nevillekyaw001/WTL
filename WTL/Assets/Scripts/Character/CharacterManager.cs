using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterManager : MonoBehaviour
{
    public CharacterDatabase CharacterDB;

    public SpriteRenderer artworkSprite;

    private int selectedOption = 0;

    public GameObject LoadingScreen;
    public Slider slider;
    public Text unlock;

    // Start is called before the first frame update
    private void Awake()
    {
        AdmobSystem.instance.ShowInterstitialAd();
    }

    void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }

        UpdateCharacter(selectedOption);
    }

    public void Update()
    {
        if (selectedOption == 0)
        {
            unlock.text = " ";
        }
        if (selectedOption == 1 && PlayerPrefs.GetInt("AdsPoints") < 100)
        {
            unlock.text = "Get 100 Ads points to unlock this wheel!";
        }
        if (selectedOption == 1 && PlayerPrefs.GetInt("AdsPoints") >= 100)
        {
            unlock.text = " ";
        }

        if (selectedOption == 2 && PlayerPrefs.GetInt("AdsPoints") < 500)
        {
            unlock.text = "Get 500 Ads points to unlock this wheel!";
        }
        if (selectedOption == 2 && PlayerPrefs.GetInt("AdsPoints") >= 500)
        {
            unlock.text = " ";
        }

        if (selectedOption == 3 && PlayerPrefs.GetInt("AdsPoints") < 1000)
        {
            unlock.text = "Get 1000 Ads points to unlock this wheel!";
        }
        if (selectedOption == 3 && PlayerPrefs.GetInt("AdsPoints") >= 1000)
        {
            unlock.text = " ";
        }

        if (selectedOption == 4 && PlayerPrefs.GetInt("AdsPoints") < 2500)
        {
            unlock.text = "Get 2500 Ads points to unlock this wheel!";
        }
        if (selectedOption == 4 && PlayerPrefs.GetInt("AdsPoints") >= 2500)
        {
            unlock.text = " ";
        }

        if (selectedOption == 5 && PlayerPrefs.GetInt("AdsPoints") < 5000)
        {
            unlock.text = "Get 5000 Ads points to unlock this wheel!";
        }
        if (selectedOption == 5 && PlayerPrefs.GetInt("AdsPoints") >= 5000)
        {
            unlock.text = " ";
        }

        if (selectedOption == 6 && PlayerPrefs.GetInt("AdsPoints") < 10000)
        {
            unlock.text = "Get 10000 Ads points to unlock this wheel!";
        }
        if (selectedOption == 6 && PlayerPrefs.GetInt("AdsPoints") >= 10000)
        {
            unlock.text = " ";
        }

        if (selectedOption == 7 && PlayerPrefs.GetInt("AdsPoints") < 15000)
        {
            unlock.text = "Get 15000 Ads points to unlock this wheel!";
        }
        if (selectedOption == 7 && PlayerPrefs.GetInt("AdsPoints") >= 15000)
        {
            unlock.text = " ";
        }

        if (selectedOption == 8 && PlayerPrefs.GetInt("AdsPoints") < 20000)
        {
            unlock.text = "Get 20000 Ads points to unlock this wheel!";
        }
        if (selectedOption == 8 && PlayerPrefs.GetInt("AdsPoints") >= 20000)
        {
            unlock.text = " ";
        }


    }
    public void NextOption()
    {
        selectedOption++;

        if (selectedOption >= CharacterDB.CharacterCount)
        {
            selectedOption = 0;
        }

        UpdateCharacter(selectedOption);
        Save();
    }

    public void BackOption()
    {
        selectedOption--;
        if (selectedOption < 0)
        {
            selectedOption = CharacterDB.CharacterCount -1;
        }
        UpdateCharacter(selectedOption);
        Save();
    }

    private void UpdateCharacter(int selectedOption)
    {
        Character character = CharacterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
    }


    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

    private void Save()
    {
        PlayerPrefs.SetInt("selectedOption", selectedOption);
    }

    public void PlayGame(string GameScene)
    {
        if (selectedOption == 0)
        {
            StartCoroutine(LoadAsynchronously(GameScene));
        }
        if (selectedOption == 1 && PlayerPrefs.GetInt("AdsPoints") >= 100)
        {
            StartCoroutine(LoadAsynchronously(GameScene));
        }
        if (selectedOption == 1 && PlayerPrefs.GetInt("AdsPoints") < 100)
        {
            Debug.Log("You need to get 100 to unlock this");
        }
        if (selectedOption == 2 && PlayerPrefs.GetInt("AdsPoints") >= 500)
        {
            StartCoroutine(LoadAsynchronously(GameScene));
        }
        if (selectedOption == 2 && PlayerPrefs.GetInt("AdsPoints") < 500)
        {
            Debug.Log("You need to get 200 to unlock this");
        }
        if (selectedOption == 3 && PlayerPrefs.GetInt("AdsPoints") >= 1000)
        {
            StartCoroutine(LoadAsynchronously(GameScene));
        }
        if (selectedOption == 3 && PlayerPrefs.GetInt("AdsPoints") < 1000)
        {
            Debug.Log("You need to get 300 to unlock this");
        }
        if (selectedOption == 4 && PlayerPrefs.GetInt("AdsPoints") >= 2500)
        {
            StartCoroutine(LoadAsynchronously(GameScene));
        }
        if (selectedOption == 4 && PlayerPrefs.GetInt("AdsPoints") < 2500)
        {
            Debug.Log("You need to get 400 to unlock this");
        }
        if (selectedOption == 5 && PlayerPrefs.GetInt("AdsPoints") >= 5000)
        {
            StartCoroutine(LoadAsynchronously(GameScene));
        }
        if (selectedOption == 5 && PlayerPrefs.GetInt("AdsPoints") < 5000)
        {
            Debug.Log("You need to get 400 to unlock this");
        }
        if (selectedOption == 6 && PlayerPrefs.GetInt("AdsPoints") >= 10000)
        {
            StartCoroutine(LoadAsynchronously(GameScene));
        }
        if (selectedOption == 6 && PlayerPrefs.GetInt("AdsPoints") < 10000)
        {
            Debug.Log("You need to get 400 to unlock this");
        }
        if (selectedOption == 7 && PlayerPrefs.GetInt("AdsPoints") >= 15000)
        {
            StartCoroutine(LoadAsynchronously(GameScene));
        }
        if (selectedOption == 7 && PlayerPrefs.GetInt("AdsPoints") < 15000)
        {
            Debug.Log("You need to get 400 to unlock this");
        }
        if (selectedOption == 8 && PlayerPrefs.GetInt("AdsPoints") >= 20000)
        {
            StartCoroutine(LoadAsynchronously(GameScene));
        }
        if (selectedOption == 8 && PlayerPrefs.GetInt("AdsPoints") < 20000)
        {
            Debug.Log("You need to get 20000 to unlock this");
        }

    }

    public void BackMenu()
    {
        SceneManager.LoadScene("StartMenu");
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

