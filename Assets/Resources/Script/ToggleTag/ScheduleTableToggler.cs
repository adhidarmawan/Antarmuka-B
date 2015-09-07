using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ScheduleTableToggler : MonoBehaviour {

	public Toggle thisToggle;
	public Text tableName;
	public int tableNumber;
	public Text tableStatus;
	public Text tableDesc;
	public ScheduleTable scheduleTable;
	public CheckTables displayedTable;

	public void ToggleSchedule(){
//		if(tableNumber==1) Data.InputData1a();
//		else if(tableNumber==2) Data.InputData1a();
//		else if(tableNumber==3) Data.InputData1a();
//		else if(tableNumber==4) Data.InputData1a();
		scheduleTable.currData = new List<TableSQL>(DataContainer.dataList);
		//scheduleTable.currData = DataContainer.dataList;
		for(int i=displayedTable.CheckBoxes.Count-1; i>-1; i--){
			if(!displayedTable.CheckBoxes[i].isOn){
				scheduleTable.currData.RemoveAt(i);
			}
		}
		tableStatus.gameObject.SetActive(true);
		scheduleTable.ShowTable();
		for(int i=0; i<Schedule.name.Count; i++){
			if(tableName.text==Schedule.name[i]){
				tableDesc.text = Schedule.desc[i];
			}
		}
	}

}
