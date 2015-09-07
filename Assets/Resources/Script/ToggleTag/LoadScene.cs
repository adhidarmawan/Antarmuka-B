using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	[SerializeField] string scene;

	public void OpenScene(){
		Application.LoadLevel(scene);
	}

}
