using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad = 5.0f;
    public float salto = 5f;
    public float horizontalInput;
    public float forwardInput;
    private Rigidbody jugadorRB;
    void Start()
    {
        jugadorRB = GetComponent<Rigidbody>();
    }
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * velocidad * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * velocidad * horizontalInput);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jugadorRB.AddForce(Vector3.up * salto, ForceMode.Impulse);
        }
    }

    /*
     public float velocidad;
     public float rotation;
     public Camera cam;
     public Rigidbody cuerpo;
     public float jump;

     bool ground;

     private void Start()
     {
         cuerpo = GetComponent<Rigidbody>();
     }

     void Update()
     {
         Vector3 camForward = cam.transform.forward;
         Vector3 camRight = cam.transform.right;
         camForward.y = 0;
         camRight.y = 0;
         camForward.Normalize();
         camRight.Normalize();

         Vector3 moveDirection = Vector3.zero;



         if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
         {
             transform.position += transform.forward * velocidad * Time.deltaTime;
         }
         if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
         {
             transform.position -= transform.forward * velocidad * Time.deltaTime;
         }

         if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
         {
             moveDirection -= camRight;
         }
         if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
         {
             moveDirection += camRight;
         }

         void OnCollisionEnter(Collision collision)
         {
             if (collision.gameObject.CompareTag("Ground"))
             {
                 ground = true;
             }
         }
     }*/
}






    /*
    public float velocidad;
    public float rotation;
    public Transform Camara;
    public Rigidbody cuerpo;
    public float jump;

    bool ground;

    private void Start()
    {
        cuerpo = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float InputHorizontal = 0f;

        
        
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            InputHorizontal = -1f;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            InputHorizontal = 1f;
        }



        Vector3 camforward = Camara.transform.forward;
        camforward.y = 0f;
        camforward.Normalize();



        Vector3 moveDirection = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            moveDirection += camforward;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            moveDirection -= camforward;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

            cuerpo.AddForce(Vector3.up * jump, ForceMode.Impulse);
            ground = false;

        }
       
        if (moveDirection != Vector3.zero) 
        {
            transform.position += moveDirection * velocidad * Time.deltaTime;
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotation * Time.deltaTime);
           
        
        }
        

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                ground = true;
            }
        }
    */




