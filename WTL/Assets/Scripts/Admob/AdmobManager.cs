using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;


public class AdmobManager : MonoBehaviour
{
    public static AdmobManager instance;

    private InterstitialAd interstitialAd;
    private RewardedAd rewardedAd;
    private BannerView bannerAd;

    private string interstitialAd_ID;
    private string rewardedAd_ID;
    private string bannerAd_ID;

    public bool InterPointToGive = false;
    public bool RewardPointToGive = false;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {   //Sample App ID = ca-app-pub-3940256099942544~3347511713
        // Official App ID = ca-app-pub-7497487718598745~7933445310

        interstitialAd_ID = "ca-app-pub-3940256099942544/1033173712";

        //sample Inter ID - ca-app-pub-3940256099942544/1033173712 //official Inter ID ca-app-pub-7497487718598745/2681118631

        rewardedAd_ID = "ca-app-pub-3940256099942544/5224354917";
        //sample RE ID ca-app-pub-3940256099942544/5224354917 //official Re ID = ca-app-pub-7497487718598745/7915642756

        bannerAd_ID = "ca-app-pub-3940256099942544/6300978111";
        //sample Banner ID = ca-app-pub-3940256099942544/6300978111 //official banner ID = ca-app-pub-7497487718598745/5983639637

        MobileAds.Initialize(InitializationStatus => { });

        //RequestInterstitialAd();
        //RequestRewardedAd();

    }

    //public void RequestBannerAD()
    //{
    //    bannerAd = new BannerView(bannerAd_ID, AdSize.Banner , AdPosition.Bottom);
    //    AdRequest request = new AdRequest.Builder().Build();
    //    bannerAd.LoadAd(request);
    //}

    //private void RequestInterstitialAd()
    //{
    //    interstitialAd = new InterstitialAd(interstitialAd_ID);
    //    interstitialAd.OnAdLoaded += HandleOnAdLoaded;
    //    AdRequest request = new AdRequest.Builder().Build();
    //    interstitialAd.LoadAd(request);
    //}

    //private void RequestRewardedAd()
    //{

    //    rewardedAd = new RewardedAd(rewardedAd_ID);
    //    rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
    //    rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
    //    rewardedAd.OnAdClosed += HandleRewardedAdClosed;
    //    rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
    //    AdRequest request = new AdRequest.Builder().Build();
    //    rewardedAd.LoadAd(request);

    //}

    //public void ShowInterstitialAd()
    //{
    //    if (interstitialAd.IsLoaded() && InterPointToGive)
    //    {
    //        interstitialAd.Show();

    //        PointSystem.AdsPoints += 1;
    //        PointSystem.updateAdsPoints();

    //        RequestInterstitialAd();
    //    }
    //}
    //public void ShowRewardedAd()
    //{
    //    if (rewardedAd.IsLoaded() && RewardPointToGive)
    //    {
    //        rewardedAd.Show();

    //        PointSystem.AdsPoints += 10;
    //        PointSystem.updateAdsPoints();
    //    }
    //}

    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        InterPointToGive = true;
    }

    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        RewardPointToGive = true;
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        //RequestRewardedAd();
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {

        //RequestRewardedAd();
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        //RequestRewardedAd();
    }
}