using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egootan : MonoBehaviour
{
    public float speed = 10.0f;
    float moveX, moveZ, movexv2,moveXv3,temp;
    public Rigidbody rb;
    public Vector3 movement;
    [SerializeField] private GameObject pew, pewpistol;
    public Vector3 fireVelocity = new Vector3(10, 8, 0);
    private Animator animatorr;
    AudioSource auto;
    public static Transform egootanime;
    [SerializeField] private Camera cam1, cam2;
    private bool cambool = false;

    // Use this for initialization
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;

        auto = this.GetComponent<AudioSource>();
        rb = this.GetComponent<Rigidbody>();
        animatorr = this.GetComponent<Animator>();
        moveXv3 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        egootanime = this.transform;
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");
        movexv2 = Input.GetAxis("Mouse X");
        //Debug.Log(movexv2);
        if (movexv2 > 0)
        {
            moveXv3 += 1;
        }
        else if (movexv2 < 0)
        {
            moveXv3 += -1;
        }
        else
        {
            moveXv3 = 0;
        }
        if (Input.GetButtonDown("Fire1"))
		{
            var temp = Instantiate(pew);
            temp.transform.position = pewpistol.transform.position;
            Rigidbody rb2=temp.GetComponent<Rigidbody>();
            rb2.velocity = fireVelocity;
		}
		if (Input.GetButtonDown("Fire2"))
        {
            animatorr.SetBool("berb", true);
            Invoke("unberb", 0.3f);
		}
        this.transform.Rotate(0, moveXv3, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cambool = !cambool;
            SWITCH_CAM();
        }
    }

    void FixedUpdate()
    {
     
        rb.velocity = new Vector3(moveX * speed, rb.velocity.y , moveZ * speed);
       

    }
    void unberb()
	{
        animatorr.SetBool("berb", false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("edo");
    }
    private void SWITCH_CAM()
    {
        if (cambool)
        {
            cam2.enabled = true;
            cam1.enabled = false;
        }
        else
        {
            cam1.enabled = true;
            cam2.enabled = false;
        }
    }
}





