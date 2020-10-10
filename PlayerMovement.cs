using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //private float speed = 5.0f;
    public float speed = 0.0f;
    
    public GameObject WelcomeText;

    // Start is called before the first frame update
    /* void Start()
     {

     }

     // Update is called once per frame
     void Update()
     {
         if (Input.GetKey(KeyCode.D))
         {
             transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
         }
         if (Input.GetKey(KeyCode.A))
         {
             transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
         }
         if (Input.GetKey(KeyCode.S))
         {
             transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
         }
         if (Input.GetKey(KeyCode.W))
         {
             transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
         }
     }*/

    void Start()
    {
        WelcomeText.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) && speed >= -4)
        {
            WelcomeText.SetActive(false);
            speed--;
        }

        if (Input.GetKey(KeyCode.S))
        {
            WelcomeText.SetActive(false);
            speed = 0;
        }

        if (Input.GetKey(KeyCode.A))
        {
            WelcomeText.SetActive(false);
            transform.Rotate(0, -60 * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            WelcomeText.SetActive(false);
            transform.Rotate(0, 60 * Time.deltaTime, 0);
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0, Space.Self);
    }
}
