
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House1Interaction : MonoBehaviour
{
    public GameObject cam;
    public GameObject distSphere1;
    public GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(distSphere1.transform.position, cam.transform.position) < 7.5)
        {
//            GameObject.House1Canvas = SetActive(true);
            Canvas.SetActive(true);
            Debug.Log("true");
        }
        else
        {
//            GameObject.House1Canvas = SetActive(false);
            Canvas.SetActive(false);
        }
    }
}
