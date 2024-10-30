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
        StartCoroutine(initializeyodoxd());
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

    public IEnumerator initializeyodoxd()
    {
        yield return new WaitForSeconds(1f);
        this.gameObject.GetComponent<yodomanager>().enabled = true;
    }
}
