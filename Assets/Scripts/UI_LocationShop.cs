using UnityEngine;
using UnityEngine.UI;

public class UI_LocationShop : MonoBehaviour
{
    [SerializeField] private int _levelNumbUnlick;
    public int LevelNumbUnlick => _levelNumbUnlick;

    [SerializeField] private int _priceTickets;

    [SerializeField] private Image _lockedImage;
    [SerializeField] private Button _buyButton;

    public void EnableBuy()
    {
        _lockedImage.gameObject.SetActive(false);
        _buyButton.interactable = true;
    }

    public void OnClick()
    {

        if (Player.Instance.Buy(_priceTickets) == true)
        {
            Debug.Log("Buy location");
            var image = _buyButton.gameObject.GetComponent<Image>();
            image.raycastTarget = false;
            _buyButton.interactable = false;
        }
    }       
}
