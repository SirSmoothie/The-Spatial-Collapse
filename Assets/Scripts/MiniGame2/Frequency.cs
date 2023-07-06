using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sinewaves : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public int numPoints;
    public float amplitude = 1f;
    public float frequency = 1f;
    public float xOffset = 0f;
    public float yOffset = 0f;
    public Slider amplitudeSlider;
    public Slider frequencySlider;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = numPoints;
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

    public void OnAmplitudeSliderValueChanged()
    {
        amplitude = amplitudeSlider.value;
        UpdateWave();
    }

    public void OnFrequencySliderValueChanged()
    {
        frequency = frequencySlider.value;
        UpdateWave();
    }
}