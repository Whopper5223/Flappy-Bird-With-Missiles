using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public float spawnrate = 3;
    public float timer = 0;
    public float offsetheight;
    public float offsetheightforbuttons;
    public GameObject pipes;
    public GameObject ButtonPipes;
    public float variety = 5f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        { int x = (int)Random.Range(0f, variety);
            if (x == variety - 1)
            {
                SpawnButtonPipe();
                timer = 0;
            }
            else
            {
                SpawnPipe();
                timer = 0;
            }
        }
    }
    void SpawnPipe()
    {
        float lowestpoint = transform.position.y - offsetheight;
        float highestpoint = transform.position.y + offsetheight;
        Instantiate(pipes, new Vector3(transform.position.x, Random.Range(lowestpoint,highestpoint), 0), transform.rotation);
    }
    void SpawnButtonPipe()
    {
        float lowestpoint = transform.position.y - offsetheightforbuttons;
        float highestpoint = transform.position.y + offsetheightforbuttons;
        Instantiate(ButtonPipes, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
    }
}
