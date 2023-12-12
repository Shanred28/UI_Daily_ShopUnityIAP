using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PointerClick : MonoBehaviour, IPointerClickHandler
{
    public event UnityAction OnClickHandler;
    public void OnPointerClick(PointerEventData eventData)
    {
        OnClickHandler?.Invoke();
        ClickButton();
    }

    protected virtual void ClickButton()
    { 
    
    }
}
