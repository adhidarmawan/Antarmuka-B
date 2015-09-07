using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AlgorithmToggle : MonoBehaviour {

	public Toggle thisToggle;
	public string label;
	public GameObject thisObject;
	public Algorithm theAlgorithm;

	public void ChangeAlgorithm(){
		if(thisToggle.isOn){
			thisObject.SetActive(true);
			theAlgorithm.usedAlgorithm = label;
		}else{
			thisObject.SetActive(false);
		}
	}
}
