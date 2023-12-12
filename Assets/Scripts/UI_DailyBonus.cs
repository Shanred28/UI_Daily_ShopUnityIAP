using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_DailyBonus : MonoBehaviour
{
    private const int DAY_WEEK = 7;
    private const int TICKETS_WEEK_PRIZE = 5;

    [SerializeField] private Slider _barDailyPrize;
    [SerializeField] private TMP_Text _amountGetPrizeText;

    [SerializeField] private Image _prizeWeek;
    [SerializeField] private Sprite _prizeWeeklyNotActive;
    [SerializeField] private Sprite _prizeWeeklyActive;

    [SerializeField] private RectTransform _dailiBonusWeekFullView;

    [SerializeField] private DialyPrizeCollector _dialyPrizeCollector;

    private PointerClick _pointerClick;

    private int _amountGetPrize = 1;

    private void Start()
    {
        _pointerClick =_prizeWeek.rectTransform.GetComponent<PointerClick>();
        _pointerClick.OnClickHandler += OnClickPrizeWeek;
        _amountGetPrizeText.text = _amountGetPrize + "/7";
    }

    private void OnDestroy()
    {
        _pointerClick.OnClickHandler -= OnClickPrizeWeek;
    }

    private void OnClickPrizeWeek()
    {
        _prizeWeek.raycastTarget = false;
        _dailiBonusWeekFullView.gameObject.SetActive(true);
        transform.gameObject.SetActive(false);
        Player.Instance.AddTickets(TICKETS_WEEK_PRIZE);
        Player.Instance.SetDay();
        _prizeWeek.sprite = _prizeWeeklyNotActive;
        _barDailyPrize.value = 0;
        _amountGetPrize = 0;
        _amountGetPrizeText.text = "0/7";
        // AddPrizePickup();
        _dialyPrizeCollector.PrizeNoActive();
    }

    public void AddPrizePickup()
    {
        _prizeWeek.raycastTarget = true;
        _amountGetPrize++;
        _barDailyPrize.value = _amountGetPrize;
        _amountGetPrizeText.text = _amountGetPrize + "/7";

        if (_amountGetPrize == DAY_WEEK)
        {
            _prizeWeek.sprite = _prizeWeeklyActive;
            _pointerClick.enabled = true;
        }    
    }
}
