using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDetect : MonoBehaviour
{
    public static AudioSource audioSource;
    public static float[] samples = new float[512];
    public static float[] freqBand = new float[8];
    public static float[] bandbuffer = new float[8];
    float[] bufferDecrease = new float[8];

    float[] freqBandHighest = new float[8];
    public static float[] audioBand = new float[8];
    public static float[] audioBandBuffer = new float[8];
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource();
        MakeFrequencyBands();
        BandBuffer();
        CreateAudioBands();
    }

    void CreateAudioBands(){
        for(int i = 0; i<8;i++){
            if(freqBand[i]>freqBandHighest[i]){
                freqBandHighest[i] = freqBand[i];
            }
            audioBand[i] = (freqBand[i]/freqBandHighest[i]);
            audioBandBuffer[i] = (bandbuffer[i]/freqBandHighest[i]);
        }
    }
    void BandBuffer(){
        for(int g = 0; g< 8; ++g){
            if(freqBand[g]>bandbuffer[g]){
                bandbuffer[g] = freqBand[g];
                bufferDecrease[g] = 0.005f;
            }

            if(freqBand[g]<bandbuffer[g]){
                bandbuffer[g] -= bufferDecrease[g];
                bufferDecrease[g] *= 1.2f;
            }
        }
    }

    void GetSpectrumAudioSource(){
        audioSource.GetSpectrumData(samples, 0, FFTWindow.Blackman);
    }

    void MakeFrequencyBands(){
        int count = 0;
        for (int i = 0; i < 8; i++){

            float average = 0;
            int sampleCount = (int)Mathf.Pow(2,i) * 2;
            if(i==7){
                sampleCount +=2;
            }
            for(int j = 0; j < sampleCount; j++){
                average += samples[count]*(count+1);
                count++;
            }
            average/= count;
            
            freqBand[i] = average*10;
        }
    }
}
