using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class WaveGenerator : MonoBehaviour
{

    [SerializeField] LineRenderer wave;

    [Range(0,1000)] [SerializeField] float T;
    [SerializeField] float v;
    [SerializeField] float density;
    
    [SerializeField] float frequency;

    public float wavelength;
    public float time;
    public float amplitude;
    float xPos;
    [Range(0,100)] public int pointsOnWave;
    [Range(0,1000)] public float multiplier;
    void Start() {
        frequency = CalculateFrequency(time);
        v = CalculateVelocity(wavelength, frequency, false);
        wavelength = CalculateWaveLength(frequency,v);
        amplitude = CalculateAmplitude(v,frequency);
        wave.positionCount = pointsOnWave;
        xPos = CalculatexPos(wavelength,pointsOnWave/2);
        wave.SetPosition(pointsOnWave / 2, new Vector3(amplitude/xPos, pointsOnWave * multiplier,0 ));
        for(int i = pointsOnWave - 1; i > pointsOnWave / 2; i--)
        {
            xPos = CalculatexPos(wavelength,i);

            Vector3 pointPosition = new Vector3(amplitude/xPos * multiplier * 2,i  * multiplier, 0);

            wave.SetPosition(i, pointPosition);
        }
         for(int i = 0 ; i < (pointsOnWave / 2); i++)
        {
            xPos = CalculatexPos(wavelength,i + 1);

            Vector3 pointPosition = new Vector3(amplitude/xPos * multiplier * 2,i  * multiplier, 0);
            
            wave.SetPosition(i, pointPosition);
        }
    }


    float CalculateAmplitude(float v, float frequency)
    {
        float amplitude = ((v * 1 / frequency)) / Mathf.Sin(2* Mathf.PI);

        return amplitude / 10000000;
    }
    float CalculateWaveLength(float freq, float v)
    {
        return (v / freq);
    }
    float CalculateVelocity(float T, float density, bool forAmp){
        if(forAmp) {
            float v = Mathf.Sqrt(T / density);
         return v;
        } else {
            float v = T * density;
            return v;
        }
    }
   
    float CalculateFrequency(float time)
    {
         frequency = 1 / time;
         return frequency;
    }


    float CalculatexPos(float wavelength, int pointPosition)
    {
        float xPos  = wavelength / pointPosition ;

        return xPos;
    }

    
}
