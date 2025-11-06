using UnityEngine;
using UnityEngine.UI;

namespace OscCore
{
    public class OSCSenderController : MonoBehaviour
    {
        [SerializeField] Button _sendButton;
        [SerializeField] OscSender _sender;
        private const string IP_ADDRESS_TEST_STRING = "/test/string"; // Replace with actual IP
        private const string IP_ADDRESS_TEST_INT = "/test/int"; // Replace with actual IP

        private void Start()
        {
            _sendButton.onClick.AddListener(HandleSendButtonClick);
        }

        private void HandleSendButtonClick()
        {
            _sender.Client.Send(IP_ADDRESS_TEST_STRING, "Hello, OSC!");
            _sender.Client.Send(IP_ADDRESS_TEST_INT, 1);
        }
    }
}
