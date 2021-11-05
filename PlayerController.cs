using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    private float currentMoveSpeed;
   // public float diagnalMoveModifier;

    private Animator anim;
    private Rigidbody2D myRigidbody;

    private bool playerMoving;
    public Vector2 lastMove;
    private Vector2 moveInput;

    private static bool playerExists;

    private bool attacking;
    public float attackTime;
    private float attackTimeCounter;

    public float knockback;
    public float knockbackLength;
    public float knockbackCount;
    public bool knockFromRight;
    public bool knockFromDown;

    public string startPoint;

    public bool canMove;

    private SFXManager sfxMan;

    void Start()
    {
        anim = GetComponent<Animator>();

        myRigidbody = GetComponent<Rigidbody2D>();

        sfxMan = FindObjectOfType<SFXManager>();

        if (!playerExists)
        {
            playerExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        lastMove = new Vector2(0, -1f);

    }


    void Update()
    {
        playerMoving = false;

        if (!canMove)
        {
            myRigidbody.velocity = Vector2.zero;
            return;
        }

        if (!attacking)
        {

            /*  if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
              {
                  //transform.Translate (new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f ,0f));
                  myRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * currentMoveSpeed, myRigidbody.velocity.y);
                  playerMoving = true;
                  lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
              }

              if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
              {
                  //transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
                  myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, Input.GetAxisRaw("Vertical") * currentMoveSpeed);
                  playerMoving = true;
                  lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
              }
              if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
              {
                  myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);
              }
              if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
              {
                  myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, 0f);
              }*/

            moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

            if (moveInput != Vector2.zero)
            {
                myRigidbody.velocity = new Vector2(moveInput.x * moveSpeed, moveInput.y * moveSpeed);
                playerMoving = true;
                lastMove = moveInput;
            }
            else
            {
                myRigidbody.velocity = Vector2.zero;
            }

            if (CrossPlatformInputManager.GetButtonDown("Attack"))
            {
                attackTimeCounter = attackTime;
                attacking = true;
                myRigidbody.velocity = Vector2.zero;
                anim.SetBool("Attack", true);

                sfxMan.playerAttack.Play();
            }

            /* if (Mathf.Abs (Input.GetAxisRaw("Horizontal")) > 0.5f && Mathf.Abs(Input.GetAxisRaw("Vertical")) > 0.5f)
                 {
                     currentMoveSpeed = moveSpeed * diagnalMoveModifier;
                 }
             else
                 {
                     currentMoveSpeed = moveSpeed;
                 } */
        }



        if (attackTimeCounter > 0)
        {
            attackTimeCounter -= Time.deltaTime;
        }

        if (attackTimeCounter <= 0)
        {
            attacking = false;
            anim.SetBool("Attack", false);
        }

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("PlayerMoving", playerMoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);

        if (CrossPlatformInputManager.GetButtonDown("Dash"))
        {
            moveSpeed = 8f;
        }
        if (CrossPlatformInputManager.GetButtonUp("Dash"))
        {
            moveSpeed = 5f;
        }
        if (knockbackCount <= 0)
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, myRigidbody.velocity.y);
            
        }
        else
        {
            if(knockFromRight)
            {
                myRigidbody.velocity = new Vector2(-knockback, 0);
                
            }
            if(!knockFromRight)
            {
                myRigidbody.velocity = new Vector2(knockback, 0);
            }
            if (knockFromDown)
            {
                myRigidbody.velocity = new Vector2(0, -knockback);

            }
            if (!knockFromDown)
            {
                myRigidbody.velocity = new Vector2(0, knockback);
            }
            knockbackCount -= Time.deltaTime;
        }
    }
    
    }

