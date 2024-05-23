using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _compRigidbody2D;
    private SpriteRenderer _compspriteRenderer;
    public float speed;
    public float xDirection = 1;
    public float yDirection = 1;

    private void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        _compspriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(speed * xDirection,speed * yDirection);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Horizontal")
        {
            xDirection = xDirection * -1;
            _compspriteRenderer.flipX = !_compspriteRenderer.flipX; ;
        }
        else if (collision.gameObject.tag == "Vertical")
        {
            yDirection = yDirection * -1;
            _compspriteRenderer.flipY = !_compspriteRenderer.flipY; ;
        }
    }
}
