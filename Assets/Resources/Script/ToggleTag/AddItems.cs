using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AddItems : MonoBehaviour {

	public List<GameObject> item;

	public void AddItem(){
		for(int i=0; i<item.Count;i++){
			item[i].SetActive(true);
		}
		this.gameObject.SetActive(false);
	}

}
