using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jake : MonoBehaviour
{
    [SerializeField] private GameObject ego;
    [SerializeField]private float speed = 1;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, ego.gameObject.transform.position, speed * Time.deltaTime);
    }
}
