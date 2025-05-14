using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endofgame : MonoBehaviour
{
    [SerializeField] private Canvas uiprefab;
    private void OnTriggerEnter(Collider other)
    {
        hudmanager.addtoscreen(uiprefab);
    }
}
