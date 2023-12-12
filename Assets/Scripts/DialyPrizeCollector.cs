using System.Collections.Generic;
using UnityEngine;

public class DialyPrizeCollector : MonoBehaviour
{
    private List<DailyPrize> _dailyPrizes = new List<DailyPrize>();

    private int _indexAccessPrize = 1;

    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            _dailyPrizes.Add(transform.GetChild(i).GetComponent<DailyPrize>());
        }

        _indexAccessPrize = _indexAccessPrize + Player.Instance.DayPrizeAvailable;
        PrizeActive();
    }

    private void PrizeActive()
    {
        if (_indexAccessPrize == 0) return;

        for (int i = 0; i < _indexAccessPrize -2 ; i++)
        {
            _dailyPrizes[i].UnLockPrize();
        }
    
    }

    public void PrizeNoActive()
    {
        for (int i = 0; i < _dailyPrizes.Count; i++)
        {
            _dailyPrizes[i].OnLockPrize();
        }
    }
}
