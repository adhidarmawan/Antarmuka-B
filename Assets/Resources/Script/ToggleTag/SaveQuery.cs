using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SaveQuery : MonoBehaviour {

	public NetMySQL netMySQL;
	public AddButton addFunc;

	void Start(){
		if(netMySQL == null){
			GameObject tempSQL = GameObject.Find("SQL");
			netMySQL = tempSQL.GetComponent<NetMySQL>();
		}
	}

	public void QuerySave(){
		//input to the database here
//		for(int i=0; i<addFunc.listQueries.Count;i++){
//
//		}
		netMySQL.InsertionConstraintQuery(addFunc.listQueries[addFunc.listQueries.Count-1].query, addFunc.listQueries[addFunc.listQueries.Count-1].type, addFunc.listQueries[addFunc.listQueries.Count-1].desc);
		//addFunc.resultText.text = "";
		//addFunc.listQueries.Clear();
		//addFunc.listQueries = null;
		//addFunc.listQueries = new List<InputQuery>();
	}
	public void QueryDelete(){
		netMySQL.DeletionConstraintQuery(addFunc.listQueries[addFunc.listQueries.Count-1].query);
		addFunc.Delete();
	}
	public void QueryDeleteByList(int number){
		netMySQL.DeletionConstraintQuery(addFunc.listQueries[number].query);
		//Debug.Log("delete: "+addFunc.listQueries[number].query);
	}

}
