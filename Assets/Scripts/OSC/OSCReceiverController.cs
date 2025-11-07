using OscCore;
using UnityEngine;

namespace OscCore
{
    public class OscReceiverController : MonoBehaviour
    {
        [SerializeField] OscReceiver _receiver;
        [SerializeField] TopView _topView;

        // アドレスは 「/test/string」 と 「/test/int」のように 「/」 で始まる形式にする必要がある
        private const string IP_ADDRESS_TEST_STRING = "/test/string";
        private const string IP_ADDRESS_TEST_INT = "/test/int";

        // Mainスレッドで扱うための変数
        private string _receivedStringValue;
        private int _receivedIntValue;

        void Start()
        {
            _receiver.Server.TryAddMethodPair(IP_ADDRESS_TEST_STRING, ReadStringValue, HandleStringValue);
            // _receiver.Server.TryAddMethodPair(IP_ADDRESS_TEST_INT, ReadIntValue, HandleIntValue);
        }

        void ReadStringValue(OscMessageValues values)
        {
            string value = values.ReadStringElement(0);
            Debug.Log($"Received string value: {value}");
            _receivedStringValue = value;
        }

        void HandleStringValue()
        {
            _topView.UpdateDisplayText($"Received string value: {_receivedStringValue}");
        }

        void ReadIntValue(OscMessageValues values)
        {
            int value = values.ReadIntElement(0);
            Debug.Log($"Received int value: {value}");
            _receivedIntValue = value;
        }

        void HandleIntValue()
        {
            // _topView.UpdateDisplayText($"Received int value: {_receivedIntValue}");
        }
    }
}