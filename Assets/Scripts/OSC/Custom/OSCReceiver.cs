using System;
using UnityEngine;
using OscCore;

namespace CustomSample
{
    public class OSCReceiver : MonoBehaviour
    {
        [Header("OSC Settings")]
        [Tooltip("The address to listen for incoming messages on")]
        [SerializeField]
        string _address = "/sample/int";
        [Tooltip("The local port to listen for incoming messages on")]
        [SerializeField]
        int _portNumber = 9000;
        OscServer _server;
        public event Action<int> OnIntReceived;
        int _receivedInt;

        void Start()
        {
            Initialize();
        }

        void Update()
        {
            _server?.Update();
        }

        void OnDestroy()
        {
            _server?.Dispose();
        }

        void Initialize()
        {
            try
            {
                OscServer.Remove(_portNumber);
                // _server = new OscServer(_portNumber); ← 非推奨
                _server = OscServer.GetOrCreate(_portNumber);
                _server.TryAddMethodPair(_address, ReadInt, ProcessIntOnMainThread);
            }
            catch (System.Exception e)
            {
                Debug.LogError($"Failed to initialize OSC server on port {_portNumber}: {e.Message}");
            }
        }

        void ReadInt(OscMessageValues values)
        {
            _receivedInt = values.ReadIntElement(0);
            Debug.Log($"Read int: {_receivedInt}");
        }

        void ProcessIntOnMainThread()
        {
            Debug.Log($"Received int: {_receivedInt}");
            OnIntReceived?.Invoke(_receivedInt);
        }
    }
}

