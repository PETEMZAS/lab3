using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egootan : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody rb;
    public Vector3 movement;
    [SerializeField] private GameObject pew, pewpistol;
    public Vector3 fireVelocity = new Vector3(10, 8, 0);


    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (Input.GetButtonDown("Fire1"))
		{
            var temp = Instantiate(pew);
            temp.transform.position = pewpistol.transform.position;
            Rigidbody rb2=temp.GetComponent<Rigidbody>();
            rb2.velocity = fireVelocity;
		}
    }


    void FixedUpdate()
    {
        moveCharacter(movement);
    }


    void moveCharacter(Vector3 direction)
    {
        rb.velocity = direction * speed;
    }
}
