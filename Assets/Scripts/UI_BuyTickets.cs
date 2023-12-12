using UnityEngine;

public class UI_BuyTickets : MonoBehaviour
{
    [SerializeField] private int _amountTickets;

    public void BuyAddTikets()
    {
        Player.Instance.AddTickets(_amountTickets);
    }
}
