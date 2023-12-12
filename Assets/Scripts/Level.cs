using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    [SerializeField] private Image _lockImage;
    [SerializeField] private Button _clickButton;

    private void Start()
    {
        
    }

    public void OnClickLevel()
    {
        Player.Instance.AddComplitedLevel();
    }

    public void UnLockLevel()
    {
        _lockImage.gameObject.SetActive(false);
        _clickButton.interactable = true;
    }

    public void DisableLevel()
    {
        _clickButton.interactable = false;
    }
}
