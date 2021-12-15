using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipes_spawning : MonoBehaviour
{

    public GameObject pipes;
    public float timer_MAX = 1;
    private float timer = 0;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        GameObject new_pipes = Instantiate(pipes);
        new_pipes.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        
            if(timer > timer_MAX){
                GameObject new_pipes = Instantiate(pipes);
                new_pipes.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                Destroy(new_pipes, 15);
                timer = 0;
            }

            timer += Time.deltaTime;
        
    }
}
