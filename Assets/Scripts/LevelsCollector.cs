using System.Collections.Generic;
using UnityEngine;

public class LevelsCollector : MonoBehaviour
{
    [SerializeField] private Transform _transformLevels;
    private List<Level> _levels = new List<Level>();

    private int _levelUnlock;
    private void Start()
    {
        Player.Instance.OnChangeLevelComplite += OnChangeLevelComplite;
        _levelUnlock = Player.Instance.LevelComplited;
        for (int i = 0; i < _transformLevels.childCount; i++)
        {
            _levels.Add(_transformLevels.GetChild(i).GetComponent<Level>());
        }

        for (int i = 0; i < _levelUnlock + 1; i++)
        {
            _levels[i].UnLockLevel();
        }
    }

    private void OnDestroy()
    {
        Player.Instance.OnChangeLevelComplite -= OnChangeLevelComplite;
    }

    private void OnChangeLevelComplite(int obj)
    {
        _levelUnlock = obj;
        UnLockLevels();
    }

    private void UnLockLevels()
    {
        if (_levelUnlock == 23)
        {
            _levels[_levelUnlock -1].DisableLevel();
            return;
        }


        for (int i = _levelUnlock; i < _levelUnlock + 1; i++)
        {
            _levels[i].UnLockLevel();
        }
        for (int i = _levelUnlock - 1; i < _levelUnlock; i++)
        {
            _levels[i].DisableLevel();
        }
    }
}
