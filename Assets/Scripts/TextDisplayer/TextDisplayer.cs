using UnityEngine;
using UnityEngine.UI;

public class TextDisplayer : MonoBehaviour
{
    [SerializeField] Text _displayText;
    public void Display(string message)
    {
        _displayText.text = message;
    }

    public void DebugInt(int value)
    {
        Debug.Log("Received int value: " + value);
    }

    public void DebugFloat(float value)
    {
        Debug.Log("Received float value: " + value);
    }
}
