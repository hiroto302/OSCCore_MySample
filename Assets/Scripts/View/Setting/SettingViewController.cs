using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Setting View Controller (Presenter)
/// </summary>
public class SettingViewController : MonoBehaviour
{
    [SerializeField] SettingView _topView;
    [SerializeField] GameObject _settingView;

    void Start()
    {
      _topView.OnNextTransitionTriggered += HandleNextTransitionTriggered;
      _topView.OnSettingButtonTapped += HandleSettingButtonTapped;
    }

    private void HandleSettingButtonTapped()
    {
      _settingView.SetActive(true);
    }

    private void HandleNextTransitionTriggered()
    {
        // 次画面への遷移処理をここに記述
    }
}
