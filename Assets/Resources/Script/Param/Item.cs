using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Item : MonoBehaviour {

	public ItemList itemList;
	public Text value;
	//public string value;

	public void Selected(){
		itemList.value = value.text;
		itemList.CloseSelection();
	}
}
