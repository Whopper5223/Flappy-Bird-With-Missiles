using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float Deadzone = -43;
    public float pipeSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * pipeSpeed) * Time.deltaTime;
        if (transform.position.x < -43)
        {
            Destroy(gameObject);
        }
    }
}
