using OscCore;
using UnityEngine;

namespace OscCore
{
    public class OscReceiverController : MonoBehaviour
    {
        [SerializeField] OscReceiver _receiver;

        // アドレスは 「/test/string」 と 「/test/int」のように 「/」 で始まる形式にする必要がある
        private const string IP_ADDRESS_TEST_STRING = "/test/string";
        private const string IP_ADDRESS_TEST_INT = "/test/int";

        void Start()
        {
            _receiver.Server.TryAddMethod(IP_ADDRESS_TEST_STRING, HandleStringMessage);
            _receiver.Server.TryAddMethod(IP_ADDRESS_TEST_INT, HandleIntMessage);
        }

        void HandleStringMessage(OscMessageValues values)
        {
            string value = values.ReadStringElement(0);
            Debug.Log($"Received string value: {value}");
        }

        void HandleIntMessage(OscMessageValues values)
        {
            int value = values.ReadIntElement(0);
            Debug.Log($"Received int value: {value}");
        }
    }
}