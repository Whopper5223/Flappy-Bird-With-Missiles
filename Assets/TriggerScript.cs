using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public MarioScript Mario;
    public LogicScript Logic;
    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        Mario = GameObject.FindGameObjectWithTag("Player").GetComponent<MarioScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3 && Mario.Alive == true)
        {
            Logic.addScore(1);
        }
        
    }
}
