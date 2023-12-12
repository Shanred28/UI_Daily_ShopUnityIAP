using System.Collections.Generic;
using UnityEngine;

public class UiPanelMeneger : MonoBehaviour
{
    [SerializeField] private UI_MenuView _menuView;
    [SerializeField] private GameObject _menuViewGO;
    [SerializeField] private GameObject _dailyBonusButton;
    [SerializeField] private GameObject _dailyBonusView;
    [SerializeField] private GameObject _settingView;
    [SerializeField] private GameObject _levelView;
    [SerializeField] private GameObject _playButton;
    [SerializeField] private GameObject _settingButtonGo;
    [SerializeField] private GameObject _menuSettingUI;
    [SerializeField] private GameObject _dailiBonusWeekFullView;
    [SerializeField] private GameObject _shopViewGo;
    [SerializeField] private GameObject _shopView;



    [SerializeField] private GameObject _menuLevelsViewGo;

    [SerializeField] private List<GameObject> _uiPanels = new List<GameObject>();

    private void Start()
    {
        _menuView.OnClikButtonMenuView += OnClikButtonMenuView;
    }

    private void OnDestroy()
    {
        _menuView.OnClikButtonMenuView -= OnClikButtonMenuView;
    }

    private void OnClikButtonMenuView(GameObject obj)
    {
        if (_playButton == obj)
        {
            _menuViewGO.SetActive(false);
            _menuLevelsViewGo.SetActive(true);
        }

        if (obj == _settingButtonGo)
        {
            _menuSettingUI.SetActive(true);
        }

        if (obj == _dailyBonusButton)
        {
            _dailyBonusView.SetActive(true);
        }

        if (obj == _shopView)
        {
            _menuViewGO.SetActive(false);
            _shopViewGo.SetActive(true);
        }
    }

    private void DisablePanel()
    { 
    
    }

    private void EnablePanel()
    {

    }

    public void MenuHome()
    {
        _menuViewGO.SetActive(true);

        _dailyBonusView.SetActive(false);
        _menuSettingUI.SetActive(false);
        _menuLevelsViewGo.SetActive(false);
        _dailiBonusWeekFullView.SetActive(false);
        _shopViewGo.SetActive(false);
    }
}
