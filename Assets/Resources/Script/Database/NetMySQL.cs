using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

public class NetMySQL : MonoBehaviour {
	// Global variables
	public IDbConnection dbConnection;
	public string database;
	public string userID;
	public string pass;
	public bool isConnected;
	public TableSQL tableSQL;

	// Initialisation
	public void StartConnect() {
		database = StaticParameter.database;
		Debug.Log(StaticParameter.database);
		OpenSqlConnection();
	}
	public void Start() {
		database = StaticParameter.database;
		Debug.Log(StaticParameter.database);
		OpenSqlConnection();
	}
	// On quit
	public void OnApplicationQuit() {
		CloseSqlConnection();
	}
	
	// Connect to database
	public void OpenSqlConnection() {
		string connectionString = "Server=localhost;" +
			"Database="+database+";" +
				"User ID= root;" +
				"Password="+pass+";" +
				"Pooling=false";
		dbConnection = new MySqlConnection(connectionString);
		dbConnection.Open();
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
		//reader.Read();
		reader.Close();
		reader = null;
		dbCommand.Dispose();
		dbCommand = null;
	}
	public void InsertionConstraintQuery(string value, string types, string desc){
		string query = "INSERT INTO `processconstraint` (`value`, `type`, `description`) VALUES('" +value+"', '"+types+"', '"+desc+"')";
		DoQuery(query);
	}

	public void DeletionConstraintQuery(string value){
		string query = "DELETE FROM `processconstraint` WHERE `value`='"+value+"'";
		DoQuery(query);
		//Debug.Log("Del Query: "+query);
	}

	public void FixedUpdate(){
		//CheckConnection();
	}
	public IEnumerator CheckDatabaseName(){
		string connectionString = "Server=localhost;" +
			"Database="+database+";" +
				"User ID="+userID+";" +
				"Password="+pass+";" +
				"Pooling=false";
		dbConnection = new MySqlConnection(connectionString);
		dbConnection.Open();
		Debug.Log("Connected to database.");
		yield return null;
	}

	public void InsertRelationshipTable1(string className, string attribute, string key){
		string tempQuery = "INSERT INTO `attribute` (`Nama Kelas`, `Atribut`, `Key`) VALUES('" +className+"', '"+attribute+"', '"+key+"')";
		DoQuery(tempQuery);
	}
	public void InsertRelationshipTable2(string className, string relation, string passer, string attribute){
		//string tempQuery = "INSERT INTO `relation` (`Nama Kelas`, `Relasi`, `Melalui`, `Atribut`, `Atribut Relasi`) VALUES('" +className+"', '"+relation+"', '"+passer+"', '"+attribute+"', '"+relationAttribute+"')";
		string tempQuery = "INSERT INTO `relation` (`Nama Kelas`, `Relasi`, `Melalui`, `Atribut`) VALUES('" +className+"', '"+relation+"', '"+passer+"', '"+attribute+"')";
		DoQuery(tempQuery);
	}
	public void DeleteRelationshipTable1(string attribute){
		string tempQuery = "DELETE FROM `attribute` WHERE `Atribut`='"+attribute+"'";
		DoQuery(tempQuery);
	}
	public void DeleteRelationshipTable2(string attribute){
		string tempQuery = "DELETE FROM `relation` WHERE `Atribut`='"+attribute+"'";
		DoQuery(tempQuery);
	}
	public void TryReadDB(string sqlQuery){
		IDbCommand dbCommand = dbConnection.CreateCommand();
		dbCommand.CommandText = sqlQuery;
		IDataReader reader = dbCommand.ExecuteReader();
		reader.Read();
		if(DataContainer.currData == null) DataContainer.currData = new List<TableSQL>();
		for(int i=0; i<reader.FieldCount;i++){
			TableSQL tempTable = new TableSQL();
			tempTable.name = reader.GetName(i);
			tempTable.datas = new List<string>();
			while(reader.Read()){
				tempTable.datas.Add(reader[i].ToString());
				//Debug.Log(reader[i].ToString());
			}
			DataContainer.currData.Add(tempTable);
			//Debug.Log(DataContainer.currData[i].name);
		}
		reader.Close();
		reader = null;
		dbCommand.Dispose();
		dbCommand = null;
	}

	public void CreateDatabase(string databaseName){
		DoQuery("CREATE DATABASE "+databaseName);
		Debug.Log("create database");
	}

	public void CreateTable(string tableName,List<string> attributeNames, List<string> attributeTypes, List<int> attributeLengths){
		string tempQuery = null;
		tempQuery = "CREATE TABLE `"+tableName+"` ( ";
		for(int i=0; i<attributeNames.Count;i++){
			tempQuery = tempQuery+"`"+attributeNames[i]+"` "+attributeTypes[i];
			if(attributeLengths[i]>0) tempQuery = tempQuery+"("+attributeLengths[i]+")";
			if(i+1<attributeNames.Count) tempQuery = tempQuery+", ";
		}
		tempQuery = tempQuery+")";
		Debug.Log("CreateTable tableSQL");
		DoQuery(tempQuery);
	}

	public void SetPrimaryKey(string tableName, string primaryKey){
		string tempQuery = null;
		tempQuery = "ALTER TABLE `"+tableName+"` ADD PRIMARY KEY (`"+primaryKey+"`)";
		Debug.Log("primary key");
		DoQuery(tempQuery);
	}

	public void ReadDBColumn(string dBase){
		List<string> tableNames = new List<string>();
		OpenSqlConnection();
		IDbCommand dbCommand = dbConnection.CreateCommand();
		dbCommand.CommandText = "SELECT TABLE_NAME FROM "+dBase+".INFORMATION_SCHEMA.TABLES";
		IDataReader reader = dbCommand.ExecuteReader();
		reader.Read();
		if(DataContainer.testTable == null) DataContainer.testTable = new List<RelationshipTable>();
		DataTable tempSQLTable = reader.GetSchemaTable();
		for(int i=0; i<reader.FieldCount;i++){
			tableNames.Add(reader.GetName(i));
			Debug.Log("name: "+reader.GetName(i));
			Debug.Log("byte: "+reader.GetByte(i));
			Debug.Log("char: "+reader.GetChar(i));
			Debug.Log("datatypename: "+reader.GetDataTypeName(i));
			Debug.Log("datetime: "+reader.GetDateTime(i));
			Debug.Log("fieldtype: "+reader.GetFieldType(i));
			Debug.Log("string: "+reader.GetString(i));
			Debug.Log("type: "+reader.GetType());
			Debug.Log("val: "+reader.GetValue(i));
			Debug.Log("schemanamespace: "+tempSQLTable.Namespace);
			Debug.Log("schematablename: "+tempSQLTable.TableName);
			Debug.Log("schemacolumname: "+tempSQLTable.Columns[i].ColumnName);
			Debug.Log("schemaconstraintname: "+tempSQLTable.Constraints[i].ConstraintName);
			Debug.Log("schemacontainer: "+tempSQLTable.Container.ToString());
			Debug.Log("schemadataset: "+tempSQLTable.DataSet.DataSetName);
			Debug.Log("schemarows: "+tempSQLTable.Rows[0].ItemArray[0].ToString());
		}
		reader.Close();
		reader = null;
		dbCommand.Dispose();
		dbCommand = null;
		for(int i=0; i< tableNames.Count; i++){
			RelationshipTable tempTable = new RelationshipTable();
			tempTable.column = new List<TableSQL>();
			tempTable.name = tableNames[i];
			dbCommand = dbConnection.CreateCommand();
			dbCommand.CommandText = "SELECT * FROM "+tableNames[i];
			reader = dbCommand.ExecuteReader();
			reader.Read();
			tempSQLTable = reader.GetSchemaTable();
			for(int j=0; j<reader.FieldCount;j++){
				TableSQL tempColumn = new TableSQL();
				tempColumn.name = reader.GetName(j);
				tempTable.column.Add(tempColumn);
				Debug.Log(DataContainer.currData[i].name);
				Debug.Log("name: "+reader.GetName(i));
				Debug.Log("byte: "+reader.GetByte(i));
				Debug.Log("char: "+reader.GetChar(i));
				Debug.Log("datatypename: "+reader.GetDataTypeName(i));
				Debug.Log("datetime: "+reader.GetDateTime(i));
				Debug.Log("fieldtype: "+reader.GetFieldType(i));
				Debug.Log("string: "+reader.GetString(i));
				Debug.Log("type: "+reader.GetType());
				Debug.Log("val: "+reader.GetValue(i));
				Debug.Log("schemanamespace: "+tempSQLTable.Namespace);
				Debug.Log("schematablename: "+tempSQLTable.TableName);
				Debug.Log("schemacolumname: "+tempSQLTable.Columns[i].ColumnName);
				Debug.Log("schemaconstraintname: "+tempSQLTable.Constraints[i].ConstraintName);
				Debug.Log("schemacontainer: "+tempSQLTable.Container.ToString());
				Debug.Log("schemadataset: "+tempSQLTable.DataSet.DataSetName);
				Debug.Log("schemarows: "+tempSQLTable.Rows[0].ItemArray[0].ToString());
			}
			reader.Close();
			reader = null;
			dbCommand.Dispose();
			dbCommand = null;
			DataContainer.testTable.Add(tempTable);
			CloseSqlConnection();
		}
		Data.AllocateData();
	}

	public void UpdateStatus(){
		
	}
	
	public void CheckConnection(){
		//Debug.Log(dbConnection.State);
	}
	public void GetItemsName(){
		
	}

}
