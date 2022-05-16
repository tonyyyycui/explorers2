using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;
public class playerBehavior : MonoBehaviour
{

    [SerializeField] public float moveSpeed = 5f;
    public Rigidbody2D rb;
    private SpriteRenderer s_renderer;
    Vector2 movement;
    // Start is called before the first frame update

    void Start()
    {
        s_renderer = GetComponent<SpriteRenderer>();
        if (this.gameObject.name == "Sia"){
            moveSpeed = moveSpeed * 0.7f;

        }

    }

    // Update is called once per frame
    void Update()
    {

        if (this.gameObject.name == "Sia")
        {
            movement.y = -Input.GetAxisRaw("Horizontal");
            movement.x = -Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        }


        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (Input.GetKey(KeyCode.A)){
            s_renderer.flipX = true;
        }
            
        else if (Input.GetKey(KeyCode.D)){
            s_renderer.flipX = false;
        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

}

