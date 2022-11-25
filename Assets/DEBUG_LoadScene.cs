using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DEBUG_LoadScene : MonoBehaviour
{
	[SerializeField] private string LevelToLoad;
	void Update()
    {
        if(Input.GetKeyDown(KeyCode.Backspace))
		{
			SceneManager.LoadScene(LevelToLoad);
		}
    }
}
