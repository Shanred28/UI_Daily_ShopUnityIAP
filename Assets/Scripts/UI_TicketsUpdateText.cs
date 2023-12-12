using TMPro;
using UnityEngine;

public class UI_TicketsUpdateText : MonoBehaviour
{
    [SerializeField] private TMP_Text _ticketsText;

    private void Start()
    {
        Player.Instance.OnChangeAmountTickets += OnChangeAmountTickets; 
        _ticketsText.text = Player.Instance.Tickets.ToString();
    }

    private void OnDestroy()
    {
        Player.Instance.OnChangeAmountTickets -= OnChangeAmountTickets;
    }

    private void OnChangeAmountTickets(int value)
    {
        _ticketsText.text = value.ToString();
    }
}
