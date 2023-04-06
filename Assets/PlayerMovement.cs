using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
  
        rigidbody2D= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float directionX = Input.GetAxisRaw("Horizontal");

        rigidbody2D.velocity = new Vector2(directionX * 7f,rigidbody2D.velocity.y);

      if(Input.GetButtonDown("Jump") || Input.GetKeyDown("up"))
        {
            rigidbody2D.velocity = new Vector3(rigidbody2D.velocity.x,14,rigidbody2D.velocity.y);
        }
    }
}
