using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScheduleTable : MonoBehaviour {

	public List<ScheduleTableItems> objectTables;
	public List<TableSQL> currData;

	public void ShowTable(){
		for(int i=0; i<objectTables.Count; i++){
			if(i<currData.Count){
				objectTables[i].thisData = currData[i];
				objectTables[i].gameObject.SetActive(true);
				objectTables[i].ShowData();
			}else {
				objectTables[i].gameObject.SetActive(false);
			}
		}
	}
}
