using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class ExampleClass : MonoBehaviour

{
    AudioSource audioSource;
    Animator aController;
    public GameObject cylinder;
    public GameObject ball2;
    public InputAction MoveAction;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        aController = GetComponent<Animator>();
        MoveAction.Enable();
    }

    void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.F) || Input.GetButtonDown("Jump"))
        GetComponent<Rigidbody>().useGravity = true;
 

       if (Input.GetKeyDown(KeyCode.A)) 
        aController.SetBool("isStretching", true)


    }



    //only runs when "event" happens
    void OnCollisionEnter(Collision collision)
    {
        // Debug-draw all contact points and normals
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }

        // Play a sound if the colliding objects had a big impact.
        if (collision.relativeVelocity.magnitude > 2)
            audioSource.Play();
            ball2.GetComponent<Rigidbody>().useGravity = true;

    }

    private void OnTriggerEnter(Collider other)
    {
        print("entered" + other.name);
        other.GetComponent<Renderer>().material.SetColor("_BaseColor",Color.blue);
        cylinder.GetComponent<Renderer>().material.SetColor("_BaseColor",Color.green);
    }

    private void OnTriggerExit(Collider other)
    {
        print("exited");
        other.GetComponent<Renderer>().material.SetColor("_BaseColor",Color.green);
        cylinder.GetComponent<Renderer>().material.SetColor("_BaseColor",Color.blue);
    }

    public void EventTrigger() {
        print("works!");
    }

}