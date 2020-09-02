using UnityEngine;
using UnityEngine.SceneManagement;

public class levelComplet : MonoBehaviour {

	public void LoadNextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
}
