using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float leftSpeed = 3;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.left * leftSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        // Destory pipes which have left the screen
        if (transform.position.x < -10) { Destroy(this.gameObject); }
    }
}
