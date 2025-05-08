using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class deathwall : MonoBehaviour
{
    [SerializeField] public float speed = 5f;
    [SerializeField] private Transform target;
    [SerializeField] private Canvas uiprefab;
    void Update()
    {
        if (collection.collected >= 1)
        {
            var step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        hudmanager.addtoscreen(uiprefab);
    }
}
