using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{ public float OpenSpeed = 4.75f;
    public BoxCollider2D ButtonCollider;
    public GameObject TopPipe;
    public GameObject BottomPipe;
    public Rigidbody2D ButtonBody2D;
    public PipeSpawnScript PSpawnScript;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

        TopPipe.transform.position = new Vector3(TopPipe.transform.position.x, TopPipe.transform.position.y + OpenSpeed, TopPipe.transform.position.z);


        BottomPipe.transform.position = new Vector3(BottomPipe.transform.position.x, BottomPipe.transform.position.y - OpenSpeed, BottomPipe.transform.position.z);

    }
}
