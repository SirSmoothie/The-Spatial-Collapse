using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SineWaveGenerator : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public Winner winner;
    public int numPoints;
    public float amplitude = 1f;
    public float frequency = 1f;
    public float xOffset = 0f;
    public float yOffset = 0f;


    public float frequencyMin = 6f;
    public float frequencyMax = 9f;

    public float AmplitudeyMin = 0.3f;
    public float AmplitudeMax = 2f;



    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = numPoints;

        RandomizeFrequency();
        RandomizeAmplitude();

    }

    void Update()
    {
        UpdateWave();
    }

    void UpdateWave()
    {
        lineRenderer.positionCount = numPoints;

        for (int i = 0; i < numPoints; i++)
        {
            float t = (float)i / (numPoints - 1);
            float x = t * frequency;
            float y = Mathf.Sin(x * 2 * Mathf.PI) * amplitude;

            Vector3 position = new Vector3(x + xOffset, y + yOffset, 0f);
            lineRenderer.SetPosition(i, position);
        }
    }



    public void RandomizeFrequency()
    {
        frequency = Random.Range(frequencyMin, frequencyMax);
        winner.RedFrequency(frequency);
        UpdateWave();
    }

    public void RandomizeAmplitude()
    {
        amplitude = Random.Range(AmplitudeyMin, AmplitudeMax);
        winner.RedAmplitude(amplitude);
        UpdateWave();
    }


}