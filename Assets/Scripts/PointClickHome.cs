using UnityEngine;
public class PointerClickHome : PointerClick
{
    [SerializeField] private UiPanelMeneger _panelMeneger;

    protected override void ClickButton()
    {
        _panelMeneger.MenuHome();
    }
}
