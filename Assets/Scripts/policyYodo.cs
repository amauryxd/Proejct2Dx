using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yodo1.MAS;

public class policyYodo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        mostrar();
        mostrar1(); 
        mostrar2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void mostrar(){
        Yodo1AdBuildConfig config = new Yodo1AdBuildConfig().enableUserPrivacyDialog(true);

    // Update the agreement link
    config = config.userAgreementUrl("Your user agreement url");

    // Update the privacy link
    config = config.privacyPolicyUrl("Your privacy policy url");

    Yodo1U3dMas.SetAdBuildConfig(config);

    
    }

    void mostrar1(){
        Yodo1MasUserPrivacyConfig userPrivacyConfig = new Yodo1MasUserPrivacyConfig()
    .titleBackgroundColor(Color.green)
    .titleTextColor(Color.blue)
    .contentBackgroundColor(Color.black)
    .contentTextColor(Color.white)
    .buttonBackgroundColor(Color.red)
    .buttonTextColor(Color.green);
        Yodo1AdBuildConfig config = new Yodo1AdBuildConfig()
    .enableUserPrivacyDialog(true)
    .userPrivacyConfig(userPrivacyConfig);

    Yodo1U3dMas.SetAdBuildConfig(config);
    }

    void mostrar2(){
        int age = Yodo1U3dMas.GetUserAge();

int attStatus = Yodo1U3dMas.GetAttrackingStatus();
switch(attStatus) {
    case Yodo1U3dAttrackingStatus.NotDetermined: break;
    case Yodo1U3dAttrackingStatus.Restricted: break;
    case Yodo1U3dAttrackingStatus.Denied: break;
    case Yodo1U3dAttrackingStatus.Authorized: break;
    case Yodo1U3dAttrackingStatus.SystemLow: break;  // iOS version below 14
}
    }

    void pruebaad(){
        Yodo1U3dBannerAdView bannerAdView = new Yodo1U3dBannerAdView(Yodo1U3dBannerAdSize.Banner, Yodo1U3dBannerAdPosition.BannerBottom | Yodo1U3dBannerAdPosition.BannerHorizontalCenter);
bannerAdView.LoadAd();
bannerAdView.Show();
    }
}
