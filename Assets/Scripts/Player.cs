using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public event Action<int> OnChangeAmountTickets;
    public event Action<int> OnChangeLevelComplite;

    public static Player Instance;

    [SerializeField] private int _tickets;
    public int Tickets => _tickets;

    private int _levelComplited;
    public int LevelComplited => _levelComplited;

    [SerializeField] private int _dayPrizeAvailable;
    public int DayPrizeAvailable => _dayPrizeAvailable;

    private void Awake()
    {
        Instance = this;
    }

    public void AddTickets(int tickets)
    {
        _tickets += tickets;
        OnChangeAmountTickets?.Invoke(_tickets);
    }

    public void AddComplitedLevel()
    {      
        _levelComplited ++;
        OnChangeLevelComplite?.Invoke(_levelComplited);
    }

    public bool Buy(int tickets)
    {
        if (_tickets - tickets >= 0)
        {
            RemoveTickets(tickets);
            return true;
        }
        else 
            return false;
    }

    private void RemoveTickets(int tickets)
    {
        _tickets -= tickets;
        OnChangeAmountTickets?.Invoke(_tickets);
    }

    public void SetDay()
    {
        _dayPrizeAvailable = 0;
    }
}
