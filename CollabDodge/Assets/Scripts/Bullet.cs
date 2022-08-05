using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float AliveTime = 3f;
    public float Speed = 0.3f;

    private void Awake()
    {
        Destroy(gameObject, AliveTime);
    }

    private void Update()
    {
        transform.Translate(0f, 0f, Speed);
    }
}
