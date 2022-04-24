using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSet2 : MonoBehaviour
{
    private int saglik1 = 400;
    private int guc1;

    public int Saglik1
    {
        get { return saglik1; }
    }
    public int Guc1
    {
        set { saglik1 = value; }
    }
    void Start()
    {
        Debug.Log(Saglik1);
    }

    
    void Update()
    {
        Debug.Log(guc1);
    }
   
}


