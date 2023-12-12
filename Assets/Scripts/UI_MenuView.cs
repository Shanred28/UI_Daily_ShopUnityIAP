using System;
using UnityEngine;

public class UI_MenuView : MonoBehaviour
{
    public event Action<GameObject> OnClikButtonMenuView;

    [SerializeField] private PointerClick _playButton;
    [SerializeField] private PointerClick _settingButton;
    [SerializeField] private PointerClick _dailyButton;
    [SerializeField] private PointerClick _shopButton;

    [SerializeField] private AudioSource _audioSourceClickButton;

    private void Start()
    {
        _playButton.OnClickHandler += OnClickPlay;
        _settingButton.OnClickHandler += OnClickSetting;
        _dailyButton.OnClickHandler += OnClickDaily;
        _shopButton.OnClickHandler += OnClickShop;
    }

    private void OnDestroy()
    {
        _playButton.OnClickHandler -= OnClickPlay;
        _settingButton.OnClickHandler -= OnClickSetting;
        _dailyButton.OnClickHandler -= OnClickDaily;
        _shopButton.OnClickHandler -= OnClickShop;
    }

    private void OnClickPlay()
    {
        _audioSourceClickButton.Play();
        OnClikButtonMenuView?.Invoke(_playButton.gameObject); 
    }

    private void OnClickSetting()
    {
        _audioSourceClickButton.Play();
        OnClikButtonMenuView?.Invoke(_settingButton.gameObject);
    }

    private void OnClickDaily()
    {
        _audioSourceClickButton.Play();
        OnClikButtonMenuView?.Invoke(_dailyButton.gameObject);
    }

    private void OnClickShop()
    {
        _audioSourceClickButton.Play();
        OnClikButtonMenuView?.Invoke(_shopButton.gameObject);
    }
}
