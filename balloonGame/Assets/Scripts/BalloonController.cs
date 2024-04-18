using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Speed = 4f; 
    public Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 6f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, Speed);

       
    }
}
