using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {
    [SerializeField] string _nextLevel;
    Monster[] _monster;
    private void OnEnable()
    {
        _monster = FindObjectsOfType<Monster>();
    }

    // Update is called once per frame
    void Update ()
    {
		if(MonstersAreAllDead())
        {
            GoToNextLevel();
        }
	}
    bool MonstersAreAllDead()
    {
        foreach(var monster in _monster)
        {
            if(monster.gameObject.activeSelf)
            {
                return false;
            }
        }
        return true;
    }
    void GoToNextLevel()
    {
        //Debug.Log("aaaaaaaaaaaaa");
        SceneManager.LoadScene(_nextLevel);
    }
}
