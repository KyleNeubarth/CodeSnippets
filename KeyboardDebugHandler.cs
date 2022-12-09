using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyboardDebugHandler : MonoBehaviour
{
    [Serializable]
    public struct Hotkey
    {
        public KeyCode KeyCode;
        public UnityEvent Event;
    }

    public List<Hotkey> Hotkeys;

    private void Update()
    {
        foreach (Hotkey h in Hotkeys)
        {
            if (Input.GetKeyDown(h.KeyCode))
            {
                if (h.Event != null)
                {
                    h.Event.Invoke();
                }
            }
        }
    }
}
