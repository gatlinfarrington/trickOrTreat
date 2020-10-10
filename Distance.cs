using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public Distance(){
        
    }
    
    public GameObject cam;
    public GameObject distSphere1;
    public GameObject distSphere2;
    public GameObject distSphere3;
    public GameObject distSphere4;
    
    public static double requiredDist = 3.0;
    
    public float dist1;
    public float dist2;
    public float dist3;
    public float dist4;
    
    public static bool withinRange1;
    public static bool withinRange2;
    public static bool withinRange3;
    public static bool withinRange4;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dist1 = Vector3.Distance(distSphere1.transform.position,cam.transform.position);
        dist2 = Vector3.Distance(distSphere2.transform.position,cam.transform.position);
        dist3 = Vector3.Distance(distSphere3.transform.position,cam.transform.position);
        dist4 = Vector3.Distance(distSphere4.transform.position,cam.transform.position);

//        Debug.Log("Dist from house 1: " + dist1 + "\n dist from house 2: " +dist2 +"\n Dist from house 3: " + dist3 + "\n Dist from house 4:  " + dist4);
    
        if(dist1 < requiredDist){
            withinRange1 = true;
        }else{
            withinRange1 = false;
        }
        
        if(dist2 < requiredDist){
            withinRange2 = true;
        }else{
            withinRange2 = false;
        }
        
        if(dist3 < requiredDist){
            withinRange3 = true;
        }else{
            withinRange3 = false;
        }
        
        if(dist4 < requiredDist){
            withinRange4 = true;
        }else{
            withinRange4 = false;
        }
        
//        Debug.Log(withinRange1 + " " +withinRange2 +" "+ withinRange3 +" "+ withinRange4);
        
    }
}
