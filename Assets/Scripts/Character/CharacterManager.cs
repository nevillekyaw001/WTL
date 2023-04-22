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
        //AdmobSystem.instance.ShowInterstitialAd();
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
        if (selectedOption == 1 && PlayerPrefs.GetInt("Coins") < 100)
        {
            unlock.text = "Get 100 Coins to unlock this wheel!";
        }
        if (selectedOption == 1 && PlayerPrefs.GetInt("Coins") >= 100)
        {
            unlock.text = " ";
        }

        if (selectedOption == 2 && PlayerPrefs.GetInt("Coins") < 250)
        {
            unlock.text = "Get 250 Coins to unlock this wheel!";
        }
        if (selectedOption == 2 && PlayerPrefs.GetInt("Coins") >= 250)
        {
            unlock.text = " ";
        }

        if (selectedOption == 3 && PlayerPrefs.GetInt("Coins") < 500)
        {
            unlock.text = "Get 500 Coins to unlock this wheel!";
        }
        if (selectedOption == 3 && PlayerPrefs.GetInt("Coins") >= 500)
        {
            unlock.text = " ";
        }

        if (selectedOption == 4 && PlayerPrefs.GetInt("Coins") < 1000)
        {
            unlock.text = "Get 1000 Coins to unlock this wheel!";
        }
        if (selectedOption == 4 && PlayerPrefs.GetInt("Coins") >= 1000)
        {
            unlock.text = " ";
        }

        if (selectedOption == 5 && PlayerPrefs.GetInt("Coins") < 2000)
        {
            unlock.text = "Get 2000 Coins to unlock this wheel!";
        }
        if (selectedOption == 5 && PlayerPrefs.GetInt("Coins") >= 2000)
        {
            unlock.text = " ";
        }

        if (selectedOption == 6 && PlayerPrefs.GetInt("Coins") < 3000)
        {
            unlock.text = "Get 3000 Coins to unlock this wheel!";
        }
        if (selectedOption == 6 && PlayerPrefs.GetInt("Coins") >= 3000)
        {
            unlock.text = " ";
        }

        if (selectedOption == 7 && PlayerPrefs.GetInt("Coins") < 4000)
        {
            unlock.text = "Get 4000 Coins to unlock this wheel!";
        }
        if (selectedOption == 7 && PlayerPrefs.GetInt("Coins") >= 4000)
        {
            unlock.text = " ";
        }

        if (selectedOption == 8 && PlayerPrefs.GetInt("Coins") < 5000)
        {
            unlock.text = "Get 5000 Coins to unlock this wheel!";
        }
        if (selectedOption == 8 && PlayerPrefs.GetInt("Coins") >= 5000)
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
        if (selectedOption == 1 && PlayerPrefs.GetInt("Coins") >= 100)
        {
            StartCoroutine(LoadAsynchronously(GameScene));
        }
        if (selectedOption == 1 && PlayerPrefs.GetInt("Coins") < 100)
        {
            Debug.Log("You need to get 100 to unlock this");
        }
        if (selectedOption == 2 && PlayerPrefs.GetInt("Coins") >= 250)
        {
            StartCoroutine(LoadAsynchronously(GameScene));
        }
        if (selectedOption == 2 && PlayerPrefs.GetInt("Coins") < 250)
        {
            Debug.Log("You need to get 250 to unlock this");
        }
        if (selectedOption == 3 && PlayerPrefs.GetInt("Coins") >= 500)
        {
            StartCoroutine(LoadAsynchronously(GameScene));
        }
        if (selectedOption == 3 && PlayerPrefs.GetInt("Coins") < 500)
        {
            Debug.Log("You need to get 500 to unlock this");
        }
        if (selectedOption == 4 && PlayerPrefs.GetInt("Coins") >= 1000)
        {
            StartCoroutine(LoadAsynchronously(GameScene));
        }
        if (selectedOption == 4 && PlayerPrefs.GetInt("Coins") < 1000)
        {
            Debug.Log("You need to get 1000 to unlock this");
        }
        if (selectedOption == 5 && PlayerPrefs.GetInt("Coins") >= 2000)
        {
            StartCoroutine(LoadAsynchronously(GameScene));
        }
        if (selectedOption == 5 && PlayerPrefs.GetInt("Coins") < 2000)
        {
            Debug.Log("You need to get 2000 to unlock this");
        }
        if (selectedOption == 6 && PlayerPrefs.GetInt("Coins") >= 3000)
        {
            StartCoroutine(LoadAsynchronously(GameScene));
        }
        if (selectedOption == 6 && PlayerPrefs.GetInt("Coins") < 3000)
        {
            Debug.Log("You need to get 3000 to unlock this");
        }
        if (selectedOption == 7 && PlayerPrefs.GetInt("Coins") >= 4000)
        {
            StartCoroutine(LoadAsynchronously(GameScene));
        }
        if (selectedOption == 7 && PlayerPrefs.GetInt("Coins") < 4000)
        {
            Debug.Log("You need to get 4000 to unlock this");
        }
        if (selectedOption == 8 && PlayerPrefs.GetInt("Coins") >= 5000)
        {
            StartCoroutine(LoadAsynchronously(GameScene));
        }
        if (selectedOption == 8 && PlayerPrefs.GetInt("Coins") < 5000)
        {
            Debug.Log("You need to get 5000 to unlock this");
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

