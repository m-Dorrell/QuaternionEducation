using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Wrapper class for triggering behaviour through GUI
/// </summary>
public class TriggerKey : MonoBehaviour
{

    [Header("----Add key to trigger on pressed----")]
    public string key;
    public UnityEvent OnTriggerKey;

    public void OnGUI()
    {
        if (Event.current.Equals(Event.KeyboardEvent(key)))
        {
            OnTriggerKey.Invoke();
        }

    }
}