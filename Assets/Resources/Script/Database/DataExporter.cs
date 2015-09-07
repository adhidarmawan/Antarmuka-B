using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public static class Exporter{
	
	public static void ExportData(string fileName){
		if(File.Exists(fileName)){
			Debug.Log("File already exist");
		}else{
			StreamWriter tempFile = File.CreateText(fileName+".txt");
			Debug.Log(DataContainer.dataList);
			if(DataContainer.dataList!=null){
				for(int i =0; i<DataContainer.dataList.Count; i++){
					tempFile.WriteLine("TableName: "+DataContainer.dataList[i].name+"; PrimaryKey: "+DataContainer.dataList[i].primaryKey.ToString());
					Debug.Log(DataContainer.dataList[i].name);
					for(int j=0; j<DataContainer.dataList[i].datas.Count; j++){
						tempFile.WriteLine("Item "+j+": "+DataContainer.dataList[i].datas[j]);
						Debug.Log(DataContainer.dataList[i].datas[j]);
					}
				}
				tempFile.Close();
			}
		}
	}
	public static void ExportDatabase(){
		Debug.Log("start exporting");
		if(File.Exists(StaticParameter.database+".txt")){
			File.Delete(StaticParameter.database+".txt");
		}else{
			StreamWriter tempFile = File.CreateText(StaticParameter.database+".txt");
			Debug.Log(SQLTables.dTables);
			if(SQLTables.dTables!=null){
				for(int i =0; i<SQLTables.dTables.Count; i++){
					Debug.Log("Table: "+SQLTables.dTables[i].items[0]);
					tempFile.WriteLine("- Table: "+SQLTables.dTables[i].items[0]);
					for(int j=0; j<SQLTables.dTables[i].keys.Count;j++){
						tempFile.WriteLine("Column: "+SQLTables.dTables[i].items[j+1]+"; PrimaryKey: "+SQLTables.dTables[i].keys[j].ToString());
						Debug.Log("Column: "+SQLTables.dTables[i].items[j+1]+"; PrimaryKey: "+SQLTables.dTables[i].keys[j].ToString());
					}
				}
				tempFile.Close();
			}
		}
	}
	//	public static void ExportTestData(string fileName){
	//		if(File.Exists(fileName)){
	//			Debug.Log("File already exist");
	//		}else{
	//			StreamWriter tempFile = File.CreateText(fileName);
	//			for(int i =0; i<DataContainer.currData.Count; i++){
	//				tempFile.WriteLine("TableName: "+DataContainer.currData[i].name+"; PrimaryKey: "+DataContainer.currData[i].primaryKey.ToString());
	//				for(int j=0; j<DataContainer.currData[i].datas.Count; j++){
	//					tempFile.WriteLine("Item "+j+": "+DataContainer.currData[i].datas[j]);
	//				}
	//			}
	//		}
	//	}
}
