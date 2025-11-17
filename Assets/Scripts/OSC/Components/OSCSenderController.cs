using UnityEngine;
using UnityEngine.UI;
using OscCore;

namespace OscCoreSample
{
    public class OSCSenderController : MonoBehaviour
    {
        [SerializeField] Button _sendButton;
        [SerializeField] OscSender _sender;
        [SerializeField] string _addressTestString = "/test/string";
        [SerializeField] string _addressTestInt = "/test/int";

        void Start()
        {
            _sendButton.onClick.AddListener(HandleSendButtonClick);
        }

        void HandleSendButtonClick()
        {
            _sender.Client.Send(_addressTestString, "Hello, OSC!");
            _sender.Client.Send(_addressTestInt, 1);
        }
    }
}
