using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CheckTables : MonoBehaviour {

	public List<Toggle> CheckBoxes;
	public List<Text> allCheckbox;
	public List<ItemList> tempItemList;
	public Text tableQueryText;
	public NetMySQL netMySQL;

	// Use this for initialization
	void Start () {
		InitCheckBox();
	}
	void InitCheckBox(){
		for(int i=0;i<allCheckbox.Count;i++){
			if(i<UsedTable.items.Count) allCheckbox[i].text = UsedTable.items[i];
			else CheckBoxes[i].gameObject.SetActive(false);
		}
		InitAllItems();
	}
	void InitAllItems(){
//		Debug.Log("try get all itemlist");
		for(int i=0; i<tempItemList.Count; i++){
			tempItemList[i].GenerateItemList();
//			Debug.Log("count itemlist "+i);
		}
	}
	public void CreateQuery(){
		string tempQuery = "SELECT ";
		string tables = "";
		string joinQuery = "";
		int cb = 0;
		for(int i=0; i<SQLTables.dTables.Count; i++){
			for(int j=1; j<SQLTables.dTables[i].items.Count; j++){
				if(CheckBoxes[cb].isOn){
					if(tables=="")
						tables = SQLTables.dTables[i].items[0] +"."+SQLTables.dTables[i].items[j];
					else tables = tables +", " + SQLTables.dTables[i].items[0] +"."+SQLTables.dTables[i].items[j];
//					Debug.Log(tables);
				}
				cb++;
			}
			if(joinQuery=="")
				joinQuery = " FROM "+SQLTables.dTables[i].items[0];
			else joinQuery = joinQuery+" INNER JOIN "+SQLTables.dTables[i].items[0];
//			Debug.Log(joinQuery);
		}
		tempQuery = tempQuery + tables + joinQuery;
		tableQueryText.text = tempQuery;
		//netMySQL.InsertionConstraintQuery(tableQueryText.text, );
	}

	public void DeleteEntry(){
		for(int i=CheckBoxes.Count-1;i>-1;i--){
			if(CheckBoxes[i].gameObject.activeInHierarchy){
				if(!CheckBoxes[i].isOn){
					Debug.Log(i+": "+allCheckbox[i].text);
					netMySQL.DeleteRelationshipTable1(allCheckbox[i].text);
					netMySQL.DeleteRelationshipTable2(allCheckbox[i].text);
				}
			}
		}
	}
}
