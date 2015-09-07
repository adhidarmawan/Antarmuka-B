using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CreateDatabase : MonoBehaviour {

	public Text dbName;
	public Text dbDef;
	public NetMySQL netMySQL;

	public void CreateDb(){
		netMySQL.CreateDatabase(dbName.text);
		netMySQL.database = dbName.text;
		netMySQL.OpenSqlConnection();
		CreateTbl();
		netMySQL.CloseSqlConnection();
	}
	public void CreateTbl(){
		CreateTable tempTable = new CreateTable();
		tempTable = tempTable.GetAttributeTable();
		netMySQL.CreateTable(tempTable.tableName,tempTable.attributeNames,tempTable.attributeTypes,tempTable.attributeLengths);
		tempTable = tempTable.GetProcessConstraintTable();
		netMySQL.CreateTable(tempTable.tableName,tempTable.attributeNames,tempTable.attributeTypes,tempTable.attributeLengths);
		netMySQL.SetPrimaryKey(tempTable.tableName,tempTable.attributeNames[tempTable.attributeNames.Count-1]);//"description");
		tempTable = tempTable.GetRelationTable();
		netMySQL.CreateTable(tempTable.tableName,tempTable.attributeNames,tempTable.attributeTypes,tempTable.attributeLengths);
	}
	public void GetFromDB(){
		//if (dbDef.text == "")
		//netMySQL.ReadDBColumn(dbDef.text);
		//Data.AllocateData();
	}
}

