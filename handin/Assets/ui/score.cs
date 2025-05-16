using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{

    public TextMeshProUGUI myTextMeshPro;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myTextMeshPro.text = "YOUR FINAL SCORE IS "  + collection.collected.ToString() + "/6";
    }
}
