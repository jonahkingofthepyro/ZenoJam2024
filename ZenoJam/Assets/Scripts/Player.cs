using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public float movementSpeed = 10f;
    public float rotationSpeed = 10f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    private Vector2 PlayerInput;
    private bool isGrounded = false;
    private bool fit = false;
    private float initialmovementSpeed;
    private float curmovementSpeed;
    private float horizontal;
    private float up;
    private float camera;
    private float vertical;
    private float speed = 10f;
    private float normalizer = 10f;
    private bool toggle;
    public Vector2 forceToApply = new Vector2(0,0);
    public float forceDamping;




    // Start is called before the first frame update
    //
    [Header("Events")] 
    public GameEvents Interact;
    void Start()
    {
        
       
   
    
        
    
        initialmovementSpeed = movementSpeed;
        curmovementSpeed = movementSpeed;
        speed = movementSpeed;

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        interact(); 
        PlayerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        
      //  moving();
       
    }
    void FixedUpdate()
    {
        rb.velocity = PlayerInput * movementSpeed;
    }
    private void moving()
        {
            horizontal = Input.GetAxis("Horizontal");
            up = Input.GetAxis("Jump");

            vertical = Input.GetAxis("Vertical");

            rb.AddForce(Vector2.right * horizontal * movementSpeed * Time.deltaTime, ForceMode2D.Force);
            rb.AddForce(Vector2.up * vertical * movementSpeed * Time.deltaTime, ForceMode2D.Impulse);
            //transform.Translate(Vector3.up* vertical * movementSpeed * Time.deltaTime);
            // transform.Translate(Vector3.right * horizontal * movementSpeed * Time.deltaTime);



        }

        private void interact()
        {
            if (Input.GetKeyDown(KeyCode.E)) {
                bool toggle = true;
                GameObject[] Interactables = GameObject.FindGameObjectsWithTag("Interactable");
                foreach (GameObject target in Interactables)
                {
                    float distance = Vector3.Distance(target.transform.position, transform.position);
                    if (distance < 1)
                    {
                        if (toggle)
                        {
                            toggle = false;
                            Interact.Raise(this, target);
                        }

                    }
                }
            }

        }





    }

    
