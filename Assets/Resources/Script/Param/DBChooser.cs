using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DBChooser : MonoBehaviour {

	public Button thisButton;
	public Text dbLabel;
	public string projectName;
	public string databaseName;
	
	public void ChooseDB(){
		StaticParameter.database = projectName;
		StaticParameter.databaseUsed = databaseName;
	}
}
