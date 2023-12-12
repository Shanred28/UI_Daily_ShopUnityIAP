using System.Collections.Generic;
using UnityEngine;

public class UI_LocationsShopCollector : MonoBehaviour
{
    [SerializeField] private List<UI_LocationShop> _locationShops = new List<UI_LocationShop>();
    private int _levelComplited;
    private void Start()
    {
        _levelComplited = Player.Instance.LevelComplited;
        for (int i = 0; i < _locationShops.Count; i++)
        {
            if (_locationShops[i].LevelNumbUnlick < _levelComplited)
            {
                _locationShops[i].EnableBuy();
            }
        }
    }

    private void OnEnable()
    {
        for (int i = 0; i < _locationShops.Count; i++)
        {
            if (Player.Instance.LevelComplited >= _locationShops[i].LevelNumbUnlick)
            {
                _locationShops[i].EnableBuy();
            }
        }
    }
}
