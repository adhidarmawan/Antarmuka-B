using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ResetItems : MonoBehaviour {

	public List<GameObject> originalList;
	public List<GameObject> additionObject;

	public void ResetItem(){
		for(int i=0; i<originalList.Count; i++){
			originalList[i].SetActive(true);
		}
		for(int i=0; i<additionObject.Count; i++){
			additionObject[i].SetActive(false);
		} 
	}

}
