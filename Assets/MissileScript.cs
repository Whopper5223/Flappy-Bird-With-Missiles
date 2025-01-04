using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileScript : MonoBehaviour
{
    public float missilespeed = 5;
    public BoxCollider2D MISSILECOLLIDER;
    public Rigidbody2D MissileBody2D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MissileBody2D.velocity = Vector2.right * missilespeed;
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
