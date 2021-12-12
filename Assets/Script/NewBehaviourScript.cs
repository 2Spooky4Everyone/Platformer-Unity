using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

	public float moveSpeed;
	public float jumpHeight;

	private Rigidbody2D myrigidbody2D;
    // Start is called before the first frame update

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

    void Start()
    {

    }

    void FixedUpdate() {
    	grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround) ;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Space) && grounded) {
        	GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }

        if(Input.GetKey (KeyCode.D)) {
        	GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed , GetComponent<Rigidbody2D>().velocity.y);
        }

        if(Input.GetKey (KeyCode.A)) {
        	GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed , GetComponent<Rigidbody2D>().velocity.y);
        }

    }
}
