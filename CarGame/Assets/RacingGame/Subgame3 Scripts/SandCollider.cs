using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Rigidbody>().drag = 2.5f;
            Debug.Log("In");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Rigidbody>().drag = 0f;
            Debug.Log("Out");
        }
    }

    /*
    public void OnTriggerEnter(Collision collision)
    {
        if(collision.gameObject.tag == "")
        {
            this.GetComponent<Rigidbody>().drag = 1.5f;
            Debug.Log(collision.gameObject.name);
        }
    }

    public void OnTriggerExit(Collision collision)
    {
        if (collision.gameObject.tag == "SandArea")
        {
            this.GetComponent<Rigidbody>().drag = 0;
            Debug.Log(collision.gameObject.name);
        }
    }*/
}
