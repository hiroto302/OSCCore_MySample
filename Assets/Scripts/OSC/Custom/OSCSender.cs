using UnityEngine;
using OscCore;
using UnityEngine.UI;

namespace CustomSample
{
    public class OSCSender : MonoBehaviour
    {
        [Header("OSC Settings")]
        [Tooltip("The IP address to send to")]
        [SerializeField]
        string _ipAddress = "127.0.0.1";
        [SerializeField]
        string _addressInt = "/sample/int";

        [Tooltip("The port number to send to")]
        [SerializeField]
        int _portNumber = 9000;
        OscClient _client;

        [Header("Other")]
        [SerializeField] Button _sendButton;

        void Start()
        {
            Initialize();

            _sendButton.onClick.AddListener(() => {
                _client?.Send(_addressInt, 10);
            });
        }

        void OnDestroy()
        {
            _client = null;
        }

        void Initialize()
        {
            _client = null;
            _client = new OscClient(_ipAddress, _portNumber);
        }
    }
}

