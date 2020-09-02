using UnityEngine;

public class endTrigger : MonoBehaviour {

	public gameMng gameManager;
	void OnTriggerEnter ()
	{
		gameManager.CompleteLevel();
	}
}
