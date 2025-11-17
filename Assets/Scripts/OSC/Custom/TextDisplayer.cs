using UnityEngine;
using UnityEngine.UI;

namespace CustomSample
{
    public class TextDisplayer : MonoBehaviour
    {
        [SerializeField] Text _displayText;
        [SerializeField] OSCReceiver _oscReceiver;

        void Start()
        {
            _oscReceiver.OnIntReceived += Display;
        }

        public void Display(int message)
        {
            Debug.Log($"Displaying message: {message}");
            _displayText.text = message.ToString();
        }
    }
}
