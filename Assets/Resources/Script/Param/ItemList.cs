using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ItemList : MonoBehaviour {

	public GameObject itemList;
	public string value;
	public Text valueText;
	//itemlists
	public List<Text> itemsText;
	public List<GameObject> items;
	
	public void OpenSelection(){
		itemList.SetActive(true);
	}
	public void CloseSelection(){
		itemList.SetActive(false);
		valueText.text = value;
	}
	public void GenerateItemList(){
		for(int i=0;i<items.Count;i++){
			if(i<UsedTable.items.Count) {
				itemsText[i].text = UsedTable.items[i];
				items[i].SetActive(true);
			}
			else {
				items[i].SetActive(false);
			}
		}
	}
}