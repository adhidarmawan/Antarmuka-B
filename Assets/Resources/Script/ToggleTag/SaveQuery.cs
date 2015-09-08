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
		try {
			netMySQL.InsertionConstraintQuery(addFunc.listQueries[addFunc.listQueries.Count-1].query, addFunc.listQueries[addFunc.listQueries.Count-1].type, addFunc.listQueries[addFunc.listQueries.Count-1].desc);
		} catch (UnityException e) {
			Debug.Log(e.Message);
		} catch (System.Exception e) {
			Debug.Log(e.Message);
		}
		//addFunc.resultText.text = "";
		//addFunc.listQueries.Clear();
		//addFunc.listQueries = null;
		//addFunc.listQueries = new List<InputQuery>();
	}
	public void QueryDelete(){
		try {
			netMySQL.DeletionConstraintQuery(addFunc.listQueries[addFunc.listQueries.Count-1].query);
		} catch (UnityException e) {
			Debug.Log(e.Message);
		} catch (System.Exception e) {
			Debug.Log(e.Message);
		} finally {
			addFunc.Delete ();
		}
	}
	public void QueryDeleteByList(int number){
		try {
			netMySQL.DeletionConstraintQuery(addFunc.listQueries[number].query);
		} catch (UnityException e) {
			Debug.Log(e.Message);
		} catch (System.Exception e) {
			Debug.Log(e.Message);
		}
		//Debug.Log("delete: "+addFunc.listQueries[number].query);
	}

}
