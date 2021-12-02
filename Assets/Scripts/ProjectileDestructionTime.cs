using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestructionTime : MonoBehaviour
{
    float timer = 0;
    public float lifeTime = 3f;
    void Start()
    {

    }
    void Update()
    {
        if (timer < lifeTime)
            timer += Time.deltaTime;
        else
        {
            Destroy(gameObject);
        }
    }
}