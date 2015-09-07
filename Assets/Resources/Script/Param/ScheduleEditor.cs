using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ScheduleEditor : MonoBehaviour {

	public Text scheduleName;
	public Text scheduleDesc;

	public void CreateSchedule(){
		if(Schedule.name==null)	Schedule.name = new List<string>();
		if(Schedule.desc==null)	Schedule.desc = new List<string>();
		Schedule.name.Add(scheduleName.text);
		Schedule.desc.Add(scheduleDesc.text);
		Exporter.ExportData(scheduleName.text);
	}

}
