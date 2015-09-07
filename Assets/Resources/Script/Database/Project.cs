using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Project : MonoBehaviour {
	
	public List<Text> projectNames;
	public List<DBChooser> projectList;
	public Text newProjectNames;
	public Text newDatabaseUsed;
	
	// Use this for initialization
	void Start () {
		if(StaticParameter.namesNewProject==null){
			StaticParameter.namesNewProject = new List<string>();
			StaticParameter.namesDatabaseUsed = new List<string>();
		}
		if(StaticParameter.namesNewProject!=null){
			for(int i=0; i<StaticParameter.namesNewProject.Count; i++){
				projectNames[i].text = StaticParameter.namesNewProject[i];
				projectList[i].projectName = StaticParameter.namesNewProject[i];
				projectList[i].databaseName = StaticParameter.namesDatabaseUsed[i];
				projectList[i].gameObject.SetActive(true);
			}
		}
	}
	
	public void AddNewProject(){
		if(StaticParameter.namesNewProject.Count<5){
			StaticParameter.namesNewProject.Add(newProjectNames.text);
			StaticParameter.namesDatabaseUsed.Add(newDatabaseUsed.text);
			Start();
		}
	}
	public void SetToNewProject(){
		StaticParameter.isNewProject = true;
	}
	public void SetToOldProject(){
		StaticParameter.isNewProject = false;
	}
}
