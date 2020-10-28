using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
	//This is from brackeys tutorial video
	private bool gameHasEnded = false;

	public void CompleteLevel()
	{
		Debug.Log("Level Won!");
	}

	public float restartDeylay = 1f;

	public void EndGame()
	{
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			Debug.Log("Game Over");
			Invoke("Restart", restartDeylay);
		}
	}

	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
