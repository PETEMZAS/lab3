using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jake : MonoBehaviour
{
    [SerializeField] private GameObject ego;
    [SerializeField]private float speed = 1;
    private void Awake()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position,egootan.egootanime.position, speed * Time.deltaTime);

        

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ego")
        {
            Destroy(this.gameObject);
            PAPI.stevecount--;
        }
    }
}
