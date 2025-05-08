using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collection : MonoBehaviour
{
    [SerializeField] public static int collected = 0;
    // Start is called before the first frame update
    void Start()
    {
        collected = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        collected++;
        Destroy(gameObject);
    }
    
        
    
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
