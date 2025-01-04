using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioScript : MonoBehaviour
{
    public float flapstrength = 5;
    public Rigidbody2D myRigidBody;
    public LogicScript Logic;
    public bool Alive = true;
    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Alive)
        {
            myRigidBody.velocity = Vector2.up * flapstrength;
        }
        if ((transform.position.y < -17.5 || transform.position.y > 17.5) && Alive == true)
        {
            Logic.gameOver();
            Alive = false;
        }
    
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Logic.gameOver();
        Alive = false;
    }
}
