using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yodo1.MAS;
using System;

public class pruba : MonoBehaviour
{
    private int retryAttempt = 0;

    void OnEnable(){
SetupEventCallbacks();
        LoadRewardedInterstitial();
    }
    private void Start()
    {
        
    }

    private void SetupEventCallbacks()
    {
        Yodo1U3dRewardedInterstitialAd.GetInstance().OnAdLoadedEvent += OnRewardedInterstitialAdLoadedEvent;
        Yodo1U3dRewardedInterstitialAd.GetInstance().OnAdLoadFailedEvent += OnRewardedInterstitialAdLoadFailedEvent;
        Yodo1U3dRewardedInterstitialAd.GetInstance().OnAdOpenedEvent += OnRewardedInterstitialAdOpenedEvent;
        Yodo1U3dRewardedInterstitialAd.GetInstance().OnAdOpenFailedEvent += OnRewardedInterstitialAdOpenFailedEvent;
        Yodo1U3dRewardedInterstitialAd.GetInstance().OnAdClosedEvent += OnRewardedInterstitialAdClosedEvent;
        Yodo1U3dRewardedInterstitialAd.GetInstance().OnAdEarnedEvent += OnRewardedInterstitialAdEarnedEvent;
    }

    private void LoadRewardedInterstitial()
    {
        //Yodo1U3dRewardedInterstitialAd.GetInstance().SetAdPlacement("Your placement ID");
        Yodo1U3dRewardedInterstitialAd.GetInstance().LoadAd();
    }

    private void OnRewardedInterstitialAdLoadedEvent(Yodo1U3dRewardedInterstitialAd ad)
    {
        // Code to be executed when an ad finishes loading.
        retryAttempt = 0;
        Yodo1U3dRewardedInterstitialAd.GetInstance().ShowAd();
    }

    private void OnRewardedInterstitialAdLoadFailedEvent(Yodo1U3dRewardedInterstitialAd ad, Yodo1U3dAdError adError)
    {
        // Code to be executed when an ad request fails.
        retryAttempt++;
        double retryDelay = Math.Pow(2, Math.Min(6, retryAttempt));
        Invoke("LoadRewardedInterstitial", (float)retryDelay);
    }

    private void OnRewardedInterstitialAdOpenedEvent(Yodo1U3dRewardedInterstitialAd ad)
    {
        // Code to be executed when an ad opened
    }

    private void OnRewardedInterstitialAdOpenFailedEvent(Yodo1U3dRewardedInterstitialAd ad, Yodo1U3dAdError adError)
    {
        // Code to be executed when an ad open fails.
        LoadRewardedInterstitial();
    }

    private void OnRewardedInterstitialAdClosedEvent(Yodo1U3dRewardedInterstitialAd ad)
    {
        // Code to be executed when the ad closed
        // LoadRewardedInterstitial();
    }

    private void OnRewardedInterstitialAdEarnedEvent(Yodo1U3dRewardedInterstitialAd ad)
    {
        this.enabled = false;
        
    }
}