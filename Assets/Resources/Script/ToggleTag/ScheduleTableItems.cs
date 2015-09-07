using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ScheduleTableItems : MonoBehaviour {

	public TableSQL thisData;
	public Text nameTable;
	public List<Text> items;

	public void ShowData(){
		nameTable.text = thisData.name;
		for(int i=0; i<items.Count; i++){
			if(i<thisData.datas.Count) {
				items[i].text = thisData.datas[i];
				items[i].gameObject.SetActive(true);
			}
			else items[i].gameObject.SetActive(false);
		}
	}

}
