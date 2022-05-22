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
        //a ya basýldýgý surece calýsýr
        if (Input.GetKey("a"))
        {
            Debug.Log("a ya basildi");
        }
        */
        //1 kez çalýþýr
        /*
        if (Input.GetKeyDown("a"))
        {
            Debug.Log("a ya basildi");
        }
        */
        //býraktýkran sonra 1 kez çalýþýr
        /*
        if (Input.GetKeyUp("a"))
        {
            Debug.Log("a ya býrakmak");
        }
        */
        //herhangi bir tuþa basýldýðýnda çalýþýr.. mause dahil
        /*
        if (Input.anyKey)
        {
            Debug.Log("Herhangi bir tuþa basýldý");
        }
        */
        //herhangi bir tuþa basýldýðýnda bir kez çalýþýr.. mause dahil
        /*
        if (Input.anyKeyDown)
        {
            Debug.Log("Herhangi bir tuþa basýldý");
        }
        */
        // mause iþlemleri
        /*
        if (Input.GetMouseButton(0))
        {
            Debug.Log("sol týk");
        }
        if (Input.GetMouseButton(1))
        {
            Debug.Log("sað týk");
        }
        if (Input.GetMouseButton(2))
        {
            Debug.Log("mauses misket týk");
        }
        */

    }
}
