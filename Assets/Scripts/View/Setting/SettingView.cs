using UnityEngine;
using UnityEngine.UI;
using System;

/// <summary>
/// 設定画面 (View)
/// IPアドレスやポート番号の設定を行う
/// </summary>
public class SettingView : MonoBehaviour
{
    [SerializeField] Button _nextButton;
    [SerializeField] Button _settingButton;

    public event Action OnNextTransitionTriggered;
    public event Action OnSettingButtonTapped;

    void Start()
    {
      _nextButton.onClick.AddListener(() => OnNextTransitionTriggered?.Invoke());
      _settingButton.onClick.AddListener(() => OnSettingButtonTapped?.Invoke());
    }

    public void ShowNextButton(bool isVisible)
    {
        _nextButton.gameObject.SetActive(isVisible);
    }
}
