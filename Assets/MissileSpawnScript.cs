using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSpawnScript : MonoBehaviour
{
    public float delay = 3;
    public float timer = 0;
    public GameObject Missile; 
    public GameObject Mario;
    public MarioScript Mario1;
    
    // Start is called before the first frame update
    void Start()
    {
        //Mario = GameObject.FindGameObjectWithTag("Player").GetComponent<MarioScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Z)) && (timer >= delay) && Mario1.Alive == true)
        {
            float yaxis = Mario.transform.position.y;
            float xaxis = Mario.transform.position.x;
            float zaxis = Mario.transform.position.z;
            Instantiate(Missile, new Vector3(transform.position.x, Mario.transform.position.y, zaxis), Missile.transform.rotation);
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
