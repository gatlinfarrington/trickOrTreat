using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House4Interaction : MonoBehaviour
{
    public GameObject cam;
    public GameObject distSphere4;
    public GameObject Canvas;
    float m_LastPressTime;
    float m_PressDelay = 0.60f;

    // Start is called before the first frame update
    void Start()
    {
        Canvas.SetActive(true);
    }
    
    void onButtonPress()
    {
        if (m_LastPressTime + m_PressDelay > Time.unscaledTime)
            return;
        m_LastPressTime = Time.unscaledTime;

//        Debug.Log();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(distSphere4.transform.position, cam.transform.position) < 7.5 /*|| timer > 60 seconds*/)
        {
//            GameObject.House1Canvas = SetActive(true);
            Canvas.SetActive(true);
            Debug.Log("true");
            /*
            if(Vector3.Distance(distSphere4.transform.position, cam.transform.position) > 7.5){
                //start timer
            }
            */
        }
        else
        {
//            GameObject.House1Canvas = SetActive(false);
            Canvas.SetActive(false);
        }
        
    }
}
