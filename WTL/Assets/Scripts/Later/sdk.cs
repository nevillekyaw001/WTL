//using UnityEngine;
//using UnityEngine.Advertisements;

//public class sdk : MonoBehaviour, IUnityAdsInitializationListener
//{
//    [SerializeField] string _androidGameId;
//    [SerializeField] string _iOsGameId;
//    [SerializeField] bool _testMode = true;
//    [SerializeField] bool _enablePerPlacementMode = true;
//    private string _gameId;

//    public bool adloaded = false;
    

//    void Awake()
//    {
        
//        DontDestroyOnLoad(transform.gameObject);
//        InitializeAds();
//    }

//    public void InitializeAds()
//    {
//        _gameId = (Application.platform == RuntimePlatform.IPhonePlayer)
//            ? _iOsGameId
//            : _androidGameId;
//        Advertisement.Initialize(_gameId, _testMode, _enablePerPlacementMode, this);
        
//    }

//    public void OnInitializationComplete()
//    {
//        Debug.Log("Unity Ads initialization complete.");
//        adloaded = true;
//    }

//    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
//    {
//        Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
        
//    }
//}