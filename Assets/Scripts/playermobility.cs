using UnityEngine;
using System.Collections;

public class playermobility : MonoBehaviour
{

   //Use this for initialization
   /*/ public float speed;
    Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0)) ;
        anim.SetTrigger("Attack");
    }
    void FixedUpdate()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);
        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        GetComponent<Rigidbody2D>().angularVelocity = 0;

        var input = Input.GetAxis("Vertical");
        GetComponent<Rigidbody2D>().AddForce(gameObject.transform.up * speed * input);


    }*/
    
    
    Rigidbody2D rigibBody;
    public float speed;

    void Start()
    {
        rigibBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
        rigibBody.AddForce(transform.up * speed * Input.GetAxis("Vertical"));
    }
    



}

