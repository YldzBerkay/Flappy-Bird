using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countScore : MonoBehaviour
{
    public static int point;

    private void Update()
    {
        Debug.Log(point);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Point"))
        {
            point += 1;

        }


    }
}
