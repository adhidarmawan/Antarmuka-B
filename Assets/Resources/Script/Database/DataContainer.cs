using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class DataContainer {

	public static string dataListName;
	public static List<TableSQL> dataList;
	public static string status;
	// current data
	public static List<TableSQL> currData;
	public static List<RelationshipTable> relationshipTables;
	public static List<RelationshipTable> relationshipTable2;
	public static List<RelationshipTable> normalTable;
	public static List<RelationshipTable> testTable;

	public static void CleanData(){
		if(dataList!=null) dataList.Clear();
		dataList = new List<TableSQL>();
		if(currData!=null) currData.Clear();
		currData = new List<TableSQL>();
	}
	public static void CleanNormalTable(){
		if(normalTable!=null) normalTable.Clear();
		normalTable = new List<RelationshipTable>();
	}
	public static void CleanRelationshipTable(){
		if(relationshipTables!=null) relationshipTables.Clear();
		relationshipTables = new List<RelationshipTable>();
	}
	public static void CleanRelationshipTable2(){
		if(relationshipTable2!=null) relationshipTable2.Clear();
		relationshipTable2 = new List<RelationshipTable>();
	}
	public static TableSQL GetTableData(string tableName){
		for(int i=0; i<dataList.Count; i++){
			if(dataList[i].name == tableName) return dataList[i];
		}
		return null;
	}
}

public class TableSQL{
	public string name = "";
	public bool primaryKey=false;
	public List<string> datas = null;
}

public class RelationshipTable{
	public string name = "";
	public List<TableSQL> column = null;
	public List<string> relation = null;
}
