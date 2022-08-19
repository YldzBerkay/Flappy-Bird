using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] float move = 1.5f;
    void Update()
    {
        transform.Translate(Time.deltaTime * move * -1, 0, 0);
    }
}
