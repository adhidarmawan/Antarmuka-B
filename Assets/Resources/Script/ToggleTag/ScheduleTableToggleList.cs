using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ScheduleTableToggleList : MonoBehaviour {

	public List<ScheduleTableToggler> tableTogglers;
	int currTable=0;

	public void ShowToggles(){
		currTable++;
		for(int i=0; i<currTable;i++){
			tableTogglers[i].gameObject.SetActive(true);
			tableTogglers[i].tableName.text = Schedule.name[i];
		}
	}

	public void ShowTableList(){
		for(int i=0; i<tableTogglers.Count; i++){
			if(i<DataContainer.dataList.Count){
				tableTogglers[i].tableName.text = DataContainer.dataList[i].name;
				tableTogglers[i].gameObject.SetActive(true);
			}else{
				tableTogglers[i].gameObject.SetActive(false);
			}
		}
	}

}
