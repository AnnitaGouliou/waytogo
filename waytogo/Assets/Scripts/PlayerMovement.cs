using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] AudioSource jumpSoundEffect;
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Animator anim;
    private bool grounded;

    private void Awake()
    {       //grab references fro rigidbody and animator from object 
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

    // Flip player when moving left / right 
        if(horizontalInput > 0.01f) //means the playr is moving right
            transform.localScale = new Vector3(1.5f, 1.5f, 1f);
       else if(horizontalInput < -0.01f) //players turns left
            transform.localScale = new Vector3(-1.5f, 1.5f, 1f);

        if(Input.GetKey(KeyCode.Space) && grounded)
            Jump();

            //set animator parameteres
            anim.SetBool("run", horizontalInput !=0);
            anim.SetBool("grounded", grounded);

            
    }

private void Jump()
{

body.velocity = new Vector2(body.velocity.x, speed);
anim.SetTrigger("jump");
grounded = false;
 jumpSoundEffect.Play();
}

private void OnCollisionEnter2D(Collision2D collision)
{
        if(collision.gameObject.tag == "Ground")
            grounded = true;
}

}
