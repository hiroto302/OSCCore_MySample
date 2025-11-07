using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Top View Controller (Presenter)
/// OSC Sender のボタン操作を管理
/// OSC Receiver が受信したメッセージの処理を管理
/// </summary>
public class TopViewController : MonoBehaviour
{
    [SerializeField] TopView _topView;
    [SerializeField] SettingView _settingView;

    void Start()
    {
      _topView.OnSendButtonTapped += HandleSendButtonTapped;
      _topView.OnSettingButtonTapped += HandleSettingButtonTapped;
    }

    private void HandleSendButtonTapped()
    {
      // OSC送信ボタンがタップされたときの処理をここに記述
      Debug.Log("OSC送信ボタンがタップされました");
    }

    private void HandleSettingButtonTapped()
    {
      // _settingView.gameObject.SetActive(true);
    }
}
