using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputControlleri : MonoBehaviour
{
    float xEkseni;
    float yEkseni;
    float zEkseni;
    private Rigidbody rg;

    public float hiz = 15f;
    // Start is called before the first frame update
    void Start()
    {
        rg = transform.GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {/*
        xEkseni = Input.GetAxis("Horizontal");
        yEkseni = Input.GetAxis("Jump");
        zEkseni = Input.GetAxis("Vertical");

        Vector3 hareket = new Vector3(xEkseni, yEkseni, zEkseni) * hiz * Time.deltaTime;
        rg.AddForce(hareket * hiz);
        */
    }
    // Update is called once per frame
    void Update()
    {   /*
        //a ya bas�ld�g� surece cal�s�r
        if (Input.GetKey("a"))
        {
            Debug.Log("a ya basildi");
        }
        */
        //1 kez �al���r
        /*
        if (Input.GetKeyDown("a"))
        {
            Debug.Log("a ya basildi");
        }
        */
        //b�rakt�kran sonra 1 kez �al���r
        /*
        if (Input.GetKeyUp("a"))
        {
            Debug.Log("a ya b�rakmak");
        }
        */
        //herhangi bir tu�a bas�ld���nda �al���r.. mause dahil
        /*
        if (Input.anyKey)
        {
            Debug.Log("Herhangi bir tu�a bas�ld�");
        }
        */
        //herhangi bir tu�a bas�ld���nda bir kez �al���r.. mause dahil
        /*
        if (Input.anyKeyDown)
        {
            Debug.Log("Herhangi bir tu�a bas�ld�");
        }
        */
        // mause i�lemleri
        /*
        if (Input.GetMouseButton(0))
        {
            Debug.Log("sol t�k");
        }
        if (Input.GetMouseButton(1))
        {
            Debug.Log("sa� t�k");
        }
        if (Input.GetMouseButton(2))
        {
            Debug.Log("mauses misket t�k");
        }
        */

    }
}
