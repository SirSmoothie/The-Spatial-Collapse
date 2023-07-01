using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinewavesRed : MonoBehaviour
{
    // refrefence the line renderer
    public LineRenderer myLineRenderer;
    public int points;
    public float startingpoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        myLineRenderer = GetComponent<LineRenderer>();
    }

    //code for sinewaves
    void Draw()
    {
        float xStart = startingpoint;
        float Tau = 2 * Mathf.PI;
        float xFinish = Tau;
        
        myLineRenderer.positionCount = points;
        for (int currentpoints = 0; currentpoints < points; currentpoints++)
        {
            float progress = (float)currentpoints/(points-1);
            float x = Mathf.Lerp(xStart,xFinish,progress);
            float y = Mathf.Sin(x+Time.timeSinceLevelLoad);
            myLineRenderer.SetPosition(currentpoints, new Vector3(x,y,10));
        }                                              

    }

    // Update is called once per frame
    // draws the sinewaves
    void Update()
    {
        Draw();
    }
}
