using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class LoadMainUI : MonoBehaviour {

	public enum LoadType{UI,DB, NewDB};
	public LoadType sceneType;
	public string db;
	public Text newDB;
	public NetMySQL netMySQL;


	void Start(){
		if(netMySQL == null){
			GameObject tempSQL = GameObject.Find("SQL");
			netMySQL = tempSQL.GetComponent<NetMySQL>();
		}
		if(StaticParameter.database!=""){
			Exporter.ExportDatabase();
		}
	}

	public void OpenMenu(){
		//DontDestroyOnLoad(netMySQL.gameObject);
		if(sceneType==LoadType.UI){
			StartByDB();
		}else if(sceneType==LoadType.DB){
			CleanBackDB();
		}
//		if(sceneType==LoadType.DB){
//			StartCoroutine(StartByNewDB());
//		}
	}
	
	void CleanBackDB(){
		DataContainer.CleanData();
		UsedTable.Clear();
		Schedule.Clean();
		StaticParameter.database = "";
		Destroy(netMySQL.gameObject);
		Application.LoadLevel("DBMain");
	}
	void StartByDB(){
		db = StaticParameter.database;
		//StaticParameter.database = "";
		UsedTable.Init();
		if(db=="Matakuliah") Load.LoadMatakuliah();
		else if(db=="Seminar I") Load.LoadSeminarI();
		else if(db=="Seminar II") Load.LoadSeminarII();
		else if(db=="Sidang") Load.LoadSidang();
		else Data.LoadNew();
		Application.LoadLevel("UI");
	}
	IEnumerator StartByNewDB(){
		StaticParameter.database = newDB.text;
		Exporter.ExportDatabase();
		Application.LoadLevel("UI");
		yield return null;
	}
}
