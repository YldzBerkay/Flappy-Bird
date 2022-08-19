using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] GameObject pipe;


    [SerializeField] float height;

    [SerializeField] float maxTime = 1;
    float timer = 0;
    
    void Awake()
    {
        GameObject newPipe = Instantiate(pipe);
        pipe.transform.position = transform.position + new Vector3(0,Random.Range(-height,height),0);
    }

    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            pipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
