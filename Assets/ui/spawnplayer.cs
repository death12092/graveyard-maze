using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class spawnplayer : MonoBehaviour
{
    [SerializeField]PlayerInputManager inputManager;
    void Start()
    {
        inputManager.JoinPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
