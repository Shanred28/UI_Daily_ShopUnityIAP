using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DailyPrize : MonoBehaviour
{
    [SerializeField] private int _amountTicket;
    [SerializeField] private TMP_Text _amountTicketText;

    [SerializeField] private Image _lockImage;

    [SerializeField] private PointerClick _pointerClick;
    [SerializeField] private UI_DailyBonus _dailyBonus;

    private void Start()
    {
        _amountTicketText.text = _amountTicket.ToString();
        _pointerClick.OnClickHandler += OnClickPrize;
        _amountTicketText.text = "X" + _amountTicket.ToString();
    }

    private void OnDestroy()
    {
        _pointerClick.OnClickHandler -= OnClickPrize;
    }

    private void OnClickPrize()
    {;
        Player.Instance.AddTickets(_amountTicket);
        _pointerClick.enabled = false;
        _dailyBonus.AddPrizePickup();
    }

    public void UnLockPrize()
    {
        _lockImage.gameObject.SetActive(false);
    }

    public void OnLockPrize()
    {
        _lockImage.gameObject.SetActive(true);
    }    
}
