using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableOnAwake : MonoBehaviour
{
    [SerializeField]
    Behaviour ToBeEnabled;
    //use this to hide objects in scene view that need to be enabled in play mode
    private void Awake()
    {
        if (ToBeEnabled)
        {
            ToBeEnabled.enabled = true;
        } else
        {
            //By default will work on the gameobject itself
            gameObject.SetActive(true);
        }
    }
}
