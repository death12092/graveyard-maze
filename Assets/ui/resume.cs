using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.ShaderData;

public class resume : MonoBehaviour
{
    public void hide()
    {
        hudmanager.removefromsceane(this.gameObject.GetComponent<Canvas>());
    }
}
