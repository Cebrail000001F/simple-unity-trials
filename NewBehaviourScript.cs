using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Camera Bir;
    public Camera Iki;
    public Camera Uc;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Bir.enabled = true;
            Iki.enabled = false;
            Uc.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Bir.enabled = false;
            Iki.enabled = true;
            Uc.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Bir.enabled = false;
            Iki.enabled = false;
            Uc.enabled = true;
        }
    }
}
