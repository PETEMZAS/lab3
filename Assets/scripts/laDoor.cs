using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laDoor : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 fireVelocity = new Vector3(100, 20, 0);

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void LMAO()
    {   
            rb.velocity = 50*fireVelocity;
    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ego")
        {
            Debug.Log("aaaaa");
            Invoke("Kys", 2);
            GetComponent<BoxCollider>().isTrigger = false;
            rb.useGravity = true;
        }
    }
  void Kys()
    {
        Destroy(this.gameObject);
    }
}
