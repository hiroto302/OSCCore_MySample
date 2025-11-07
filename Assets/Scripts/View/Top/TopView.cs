using UnityEngine;
using UnityEngine.UI;
using System;

/// <summary>
/// TOP画面 (View)
/// </summary>
public class TopView : MonoBehaviour
{
    [SerializeField] Text _displayText;
    [SerializeField] Button _sendButton;
    [SerializeField] Button _settingButton;
    public event Action OnSendButtonTapped;
    public event Action OnSettingButtonTapped;

    void Start()
    {
      _sendButton.onClick.AddListener(() => OnSendButtonTapped?.Invoke());
      _settingButton.onClick.AddListener(() => OnSettingButtonTapped?.Invoke());
    }

    public void UpdateDisplayText(string message)
    {
        _displayText.text = message;
    }
}
