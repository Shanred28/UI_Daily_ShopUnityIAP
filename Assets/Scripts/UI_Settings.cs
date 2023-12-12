using UnityEngine;
using UnityEngine.UI;

public class UI_Settings : MonoBehaviour
{
    [SerializeField] private AudioSource _audioMusicSource;
    [SerializeField] private AudioSource _audioVolumeClickButton;

    [SerializeField] private Scrollbar _scrollbar;

    public void EnableMusic()
    {
        if (_audioMusicSource.isPlaying == true)
        {
            _audioMusicSource.Pause();
        }
        else
            _audioMusicSource.UnPause();
    }

    public void SetVolumeClickButton()
    {
        _audioMusicSource.volume = _scrollbar.value;
        _audioVolumeClickButton.volume = _scrollbar.value;
    }

    public void OnEnableScrollBar()
    {
        if (_scrollbar.gameObject.activeSelf == false)
            _scrollbar.gameObject.SetActive(true);
        else
            _scrollbar.gameObject.SetActive(false);
    }
}
