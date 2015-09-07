using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

public class SQLTester : MonoBehaviour {
	// Global variables
	public IDbConnection dbConnection;
	public string database;
	public string userID;
	public string pass;

	//gameObjects
	public Text result;

	// Initialisation
	public void Start() {
	}
	
	// On quit
	public void OnApplicationQuit() {
		CloseSqlConnection();
	}
	
	// Connect to database
	public void OpenSqlConnection() {
		string connectionString = "Server=localhost;" +
			"Database="+result.text+";" +
				"User ID=root;" +
				"Password="+pass+";" +
				"Pooling=false";
		dbConnection = new MySqlConnection(connectionString);
		try{
			//dbConnection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
			dbConnection.Open();
		}
		catch(Exception err){
			Debug.LogError(err);
		}
		//dbConnection.Open();
		Debug.Log("Connected to database.");
		//doQuery("SELECT * FROM last");
	}
	
	// Disconnect from database
	public void CloseSqlConnection() {
		dbConnection.Close();
		dbConnection = null;
		Debug.Log("Disconnected from database.");
	}
	
	// MySQL Query
	public void DoQuery(string sqlQuery) {
		IDbCommand dbCommand = dbConnection.CreateCommand();
		dbCommand.CommandText = sqlQuery;
		IDataReader reader = dbCommand.ExecuteReader();
		//Debug.Log(reader.ToString());
		reader.Read();
		while(reader.Read()){
			//reader.
		}
		reader.Close();
		reader = null;
		dbCommand.Dispose();
		dbCommand = null;
	}

	public void TryCreateTable(){

	}
	public void TryCreateDB(){

	}
	public void TryManualQueryDB(){
		DoQuery(result.text);
	}
	public void TryReadDB(){
		IDbCommand dbCommand = dbConnection.CreateCommand();
		dbCommand.CommandText = result.text;
		IDataReader reader = dbCommand.ExecuteReader();
		reader.Read();
		List<string> tempData = new List<string>();
//		Debug.Log(reader.FieldCount);
		for(int i=0; i<reader.FieldCount;i++){
			Debug.Log(reader.GetName(i));
		}
//		while(reader.Read()){
//			//Debug.Log("DEPTH: "+reader.FieldCount);
//			tempData.Add(reader["Kode"].ToString());
//			Debug.Log("DATA TYPE NAME: "+reader.GetName(3).ToString());
//			Debug.Log("pengajar(?): "+reader["Pengajar"].ToString());
//			Debug.Log("reader[2]?: "+reader[3].ToString());
//		}
//		for(int i=0; i<tempData.Count;i++){
//			Debug.Log("data no: "+i.ToString()+"-"+tempData[i]);
//
//		}
		reader.Close();
		reader = null;
		dbCommand.Dispose();
		dbCommand = null;
	}
}
