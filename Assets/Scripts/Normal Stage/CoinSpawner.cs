using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public static CoinSpawner instance;
    public float moveSpeed = 10f;
    public float spawnRate = 1f;
    //public float shrinkSpeed = 1f;
    //private float elapsedSeconds = 0;
    private float nextTimeToSpawn = 0;
    private int spawnDistance = 50;
    private float screenHeight;
    private float screenWidth;
    private Rect spawnArea;

    public GameObject Coin;
    [SerializeField] Vector3 pointToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        screenHeight = Camera.main.orthographicSize * 2;
        screenWidth = screenHeight * Screen.width / Screen.height;

       

        
    }

    // Update is called once per frame
    void Update()
    {
        int randomIndex = Random.Range(0, 2) * 2 - 1;
        Vector3 bottomLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));
        spawnArea = new Rect(Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x, bottomLeft.y, randomIndex * spawnDistance, screenHeight);
        if (Time.time >= nextTimeToSpawn)
        {
            SpawnObject();
            nextTimeToSpawn = Time.time + 1 / spawnRate;
        }
    }

    void SpawnObject()
    {
        Vector2 randomPoint = spawnArea.center + Random.insideUnitCircle * spawnArea.width * 0.5f;
        Instantiate(Coin, new Vector3(randomPoint.x, randomPoint.y, 0), Quaternion.identity);
    }

}

