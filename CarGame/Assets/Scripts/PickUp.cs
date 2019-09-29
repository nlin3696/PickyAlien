using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform onHand;
    Vector3 newPosition;

    void OnMouseDown()
    {
        newPosition.Set(0,1,0);
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = onHand.transform.position + newPosition;
        this.transform.rotation = Quaternion.Euler(90, 0, 0);
        this.transform.parent = GameObject.Find("Car").transform;
    }

    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
    }

}
