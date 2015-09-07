using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class AddButton : MonoBehaviour {

	public SaveQuery queryDependent;

	public enum AddType{Unique, Number, Value, Relation, PoolSolution};
	public List<InputQuery> listQueries = new List<InputQuery>();

	[SerializeField] AddType thisType;
	public Text resultText;
	public ResultList resultList;
	//public ToggleGroup toggleGroup;
	public Toggle hardToggle;
	public Text descText;
	public List<Text> itemA;
	public List<Text> itemB;
	public List<Text> itemC;
	/// <summary>
	/// pool parameter
	public string parameterPool;

	public void DefQuery(){
		Debug.Log("addingDefFunc");
		List<string> tempColumns = new List<string>();
//		string columns = "";
		for(int i=0; i<SQLTables.dTables.Count;i++){
			for(int j=0; j<SQLTables.dTables[i].keys.Count;j++){
				if(SQLTables.dTables[i].keys[j]){
					if(!tempColumns.Contains(SQLTables.dTables[i].items[j+1])){
						tempColumns.Add(SQLTables.dTables[i].items[j+1]);
//						if(columns!="") columns = columns+", "+SQLTables.dTables[i].items[j+1];
//						else columns = SQLTables.dTables[i].items[j+1];
					}
				}
			}
		}
		//variant 1
		for(int i=0; i<tempColumns.Count; i++){
			string result = "SELECT IF (EXISTS (SELECT * FROM (SELECT COUNT( * ) AS JUMLAH FROM "+StaticParameter.database+" GROUP BY "+ tempColumns[i] +", "+parameterPool+" ) AS A WHERE ( JUMLAH > 1)),1 ,0) AS RESULT";
			InputQuery input = new InputQuery();
			input.Init(result,"hard", tempColumns[i]+ " unik");
			listQueries.Add(input);
			queryDependent.QuerySave();
		}
		//variant type 2
//		string result = "SELECT IF (EXISTS (SELECT * FROM (SELECT COUNT( * ) AS JUMLAH FROM (";
//		result = result + "SELECT "+DataContainer.relationshipTable2[0].column[0].datas[2] +" FROM "+DataContainer.relationshipTable2[0].column[0].datas[0]+" ";
//		for(int i=0; i<DataContainer.relationshipTable2.Count; i++){
//			if(i>0)	result = result +"UNION "+ DataContainer.relationshipTable2[i].column[0].datas[2] +" FROM "+DataContainer.relationshipTable2[i].column[0].datas[0]+" ";
//			for(int j=1; j<DataContainer.relationshipTable2[i].column.Count;j++){
//				result = result + "UNION "+DataContainer.relationshipTable2[i].column[j].datas[0]+" FROM "+DataContainer.relationshipTable2[i].column[0].datas[0]+" ";
//			}
//		}
//		result = result +") GROUP BY `Nama Dosen`, Hari, Jam1, Jam2 ) AS A WHERE ( JUMLAH > 1)),1 ,0) AS RESULT";
//		InputQuery input = new InputQuery();
//		input.Init(result,"hard","unik");
//		listQueries.Add(input);
//		queryDependent.QuerySave();
		//resultText.text = listQueries[0].desc;
		//variant 3
		List<int> falseItemI = new List<int>();
		List<int> falseItemJ = new List<int>();
		List<int> tempExceptionI = new List<int>();
		List<int> tempExceptionJ = new List<int>();
		for(int i=0; i<DataContainer.relationshipTable2.Count; i++){
			string tempCN = DataContainer.relationshipTable2[i].name;
			for(int j=0; j<DataContainer.relationshipTable2[i].column.Count;j++){
				if(!DataContainer.relationshipTable2[i].column[j].primaryKey){
					falseItemI.Add(i);
					falseItemJ.Add(j);
					string tempR = DataContainer.relationshipTable2[i].column[j].datas[0];
					for(int k=i; k<DataContainer.relationshipTable2.Count; k++){
						for(int l=j; l<DataContainer.relationshipTable2[k].column.Count;l++){
							if(DataContainer.relationshipTable2[k].name == tempR){
								if(DataContainer.relationshipTable2[k].column[l].datas[0] == tempCN){
									if(DataContainer.relationshipTable2[k].column[l].datas[1] == ""){
										tempExceptionI.Add(k);
										tempExceptionJ.Add(l);
										Debug.Log("yay relation exception "+l);
									}
								}
							}
						}
					}
				}
			}
		}
		for(int i=0; i<tempExceptionI.Count; i++){
			string result = "SELECT IF (EXISTS (SELECT * FROM (SELECT COUNT( * ) AS JUMLAH FROM (SELECT ";
			if(i<1)	{
				if(DataContainer.relationshipTable2[falseItemI[0]].column[falseItemJ[0]].datas[1] == "")
					result = result + DataContainer.relationshipTable2[falseItemI[0]].column[falseItemJ[0]].datas[2] +" FROM "/*+DataContainer.relationshipTable2[falseItemI[0]].name+*/+StaticParameter.database+" ";
				else 
					result = result + DataContainer.relationshipTable2[falseItemI[0]].column[falseItemJ[0]].datas[2] +" FROM "/*+DataContainer.relationshipTable2[falseItemI[0]].column[falseItemJ[0]].datas[1]+*/+StaticParameter.database+" ";
			}
			for(int j=1; j<falseItemI.Count;j++){
				if(DataContainer.relationshipTable2[falseItemI[j]].column[falseItemJ[j]].datas[1] == "")
					result = result + "UNION SELECT "+DataContainer.relationshipTable2[falseItemI[j]].column[falseItemJ[j]].datas[2]+" FROM "/*+DataContainer.relationshipTable2[falseItemI[j]].name+*/+StaticParameter.database+" ";
				else
					result = result + "UNION SELECT "+DataContainer.relationshipTable2[falseItemI[j]].column[falseItemJ[j]].datas[2]+" FROM "/*+DataContainer.relationshipTable2[falseItemI[j]].column[falseItemJ[j]].datas[1]+*/+StaticParameter.database+" ";
			}
			//result = result + "UNION SELECT "+DataContainer.relationshipTable2[tempExceptionI[i]].column[tempExceptionJ[i]].datas[2]+" FROM "+DataContainer.relationshipTable2[tempExceptionI[i]].name+" ";
			result = result +") AS union GROUP BY "+DataContainer.relationshipTable2[tempExceptionI[i]].column[tempExceptionJ[i]].datas[2]+", "+parameterPool+") AS A WHERE ( JUMLAH > 1)),1 ,0) AS RESULT";
			InputQuery input = new InputQuery();
			input.Init(result,"hard", DataContainer.relationshipTable2[tempExceptionI[i]].column[tempExceptionJ[i]].datas[2]+" unik ");
			listQueries.Add(input);
			queryDependent.QuerySave();
		}
		for(int i=0; i<resultList.resultLists.Count;i++){
			//resultText.text = resultText.text+"\n"+listQueries[i].desc;
			if(i<listQueries.Count){
				resultList.labels[i].text = listQueries[i].desc;
				resultList.resultLists[i].gameObject.SetActive(true);
			}else{
				resultList.resultLists[i].gameObject.SetActive(false);
			}
		}
		Debug.Log("finish adding");
	}

	public void DetectGroup(){
		List<int> falseItemI = new List<int>();
		List<int> falseItemJ = new List<int>();
		List<int> tempExceptionI = new List<int>();
		List<int> tempExceptionJ = new List<int>();
		for(int i=0; i<DataContainer.relationshipTable2.Count; i++){
			string tempCN = DataContainer.relationshipTable2[i].name;
			for(int j=0; j<DataContainer.relationshipTable2[i].column.Count;j++){
				if(!DataContainer.relationshipTable2[i].column[j].primaryKey){
					falseItemI.Add(i);
					falseItemJ.Add(j);
					string tempR = DataContainer.relationshipTable2[i].column[j].datas[0];
					for(int k=i; k<DataContainer.relationshipTable2.Count; k++){
						for(int l=j; l<DataContainer.relationshipTable2[k].column.Count;l++){
							if(DataContainer.relationshipTable2[k].name == tempR){
								if(DataContainer.relationshipTable2[k].column[l].datas[0] == tempCN){
									if(DataContainer.relationshipTable2[k].column[l].datas[1] == ""){
										tempExceptionI.Add(k);
										tempExceptionJ.Add(l);
										Debug.Log("yay relation exception "+l);
									}
								}
							}
						}
					}
				}
			}
		}
		string tempDetect = "";
		for(int i=0; i<tempExceptionI.Count; i++){
			if(tempDetect!=DataContainer.relationshipTable2[falseItemI[i]].column[falseItemJ[i]].datas[0]){
				tempDetect = DataContainer.relationshipTable2[falseItemI[i]].column[falseItemJ[i]].datas[0];
				Debug.Log("detect: "+tempDetect);
				string result = "SELECT IF (EXISTS (SELECT * FROM (SELECT COUNT( * ) AS JUMLAH FROM (SELECT ";
				if(i<1)	{
					if(DataContainer.relationshipTable2[falseItemI[0]].column[falseItemJ[0]].datas[1] == "")
						result = result + DataContainer.relationshipTable2[falseItemI[0]].column[falseItemJ[0]].datas[2] +" FROM "/*+DataContainer.relationshipTable2[falseItemI[0]].name+*/+StaticParameter.database+" ";
					else 
						result = result + DataContainer.relationshipTable2[falseItemI[0]].column[falseItemJ[0]].datas[2] +" FROM "/*+DataContainer.relationshipTable2[falseItemI[0]].column[falseItemJ[0]].datas[1]+*/+StaticParameter.database+" ";
				}
				for(int j=1; j<falseItemI.Count;j++){
					if(DataContainer.relationshipTable2[falseItemI[j]].column[falseItemJ[j]].datas[1] == "")
						result = result + "UNION SELECT "+DataContainer.relationshipTable2[falseItemI[j]].column[falseItemJ[j]].datas[2]+" FROM "/*+DataContainer.relationshipTable2[falseItemI[j]].name+*/+StaticParameter.database+" ";
					else
						result = result + "UNION SELECT "+DataContainer.relationshipTable2[falseItemI[j]].column[falseItemJ[j]].datas[2]+" FROM "/*+DataContainer.relationshipTable2[falseItemI[j]].column[falseItemJ[j]].datas[1]+*/+StaticParameter.database+" ";
				}
				//result = result + "UNION SELECT "+DataContainer.relationshipTable2[tempExceptionI[i]].column[tempExceptionJ[i]].datas[2]+" FROM "+DataContainer.relationshipTable2[tempExceptionI[i]].name+" ";
				result = result +") AS union GROUP BY "+DataContainer.relationshipTable2[tempExceptionI[i]].column[tempExceptionJ[i]].datas[2]+", "+parameterPool+") AS A WHERE ( JUMLAH > 1)),1 ,0) AS RESULT";
				InputQuery input = new InputQuery();
				input.Init(result,"hard", DataContainer.relationshipTable2[tempExceptionI[i]].column[tempExceptionJ[i]].datas[2]+" unik ");
				listQueries.Add(input);
				queryDependent.QuerySave();
			}
		}
		for(int i=0; i<resultList.resultLists.Count;i++){
			//resultText.text = resultText.text+"\n"+listQueries[i].desc;
			if(i<listQueries.Count){
				resultList.labels[i].text = listQueries[i].desc;
				resultList.resultLists[i].gameObject.SetActive(true);
			}else{
				resultList.resultLists[i].gameObject.SetActive(false);
			}
		}
		Debug.Log("finish adding");
	}

	public void Add(){
		string toggles;
		string result="";
		if(hardToggle.isOn)	toggles = "hard";
		else toggles = "soft";
		if(thisType==AddType.Unique){
			string item = itemA[0].text;
			for(int i=0;i<itemB.Count;i++){
				if(itemB[i].gameObject.activeInHierarchy) item = item+", "+itemB[i].text;
			}
			result = "SELECT IF (EXISTS (SELECT * FROM (SELECT COUNT( * ) AS JUMLAH FROM "+StaticParameter.database+" GROUP BY "+item+") AS A WHERE ( JUMLAH > 1)),1 ,0) AS RESULT";
		}else if(thisType==AddType.Number){
			result = "SELECT IF (EXISTS (SELECT * FROM "+StaticParameter.database+" GROUP BY "+itemA[0].text+" HAVING COUNT("+itemA[0].text+")>"+itemB[0].text+"), 1, 0) AS RESULT";
		}else if(thisType==AddType.Value){
			result = "SELECT IF (EXISTS (SELECT * FROM "+StaticParameter.database+" WHERE (("+itemA[0].text+" "+itemC[0].text+" "+itemB[0].text+") AND ("+itemA[1].text+" "+itemC[1].text+" "+itemB[1].text+"))) ), 1, 0) AS RESULT";
		}else if(thisType==AddType.Relation){
			string itemsA1 = itemA[0].text;
			string itemsA2 = "A."+itemsA1;
			for(int i=1;i<itemA.Count;i++){
				if(itemA[i].gameObject.activeInHierarchy){
					itemsA1 = itemsA1+", "+itemA[i].text;
					itemsA2 = itemsA2+", A."+itemA[i].text;
				}
			}
			string itemsB1 = itemB[0].text;
			string itemsB2 = "B."+itemB[0].text;
			for(int i=1;i<itemB.Count;i++){
				if(itemB[i].gameObject.activeInHierarchy){
					itemsB1 = itemsB1+", "+itemB[i].text;
					itemsB2 = itemsB2+", B."+itemB[i].text;
				}
			}
			result = "SELECT IF(EXISTS ( SELECT "+itemsA2+", A.Jumlah, B.Jumlah " +
					"FROM (SELECT "+itemsA1+", count(*) AS Jumlah FROM "+StaticParameter.database+" " +
					"GROUP BY "+itemsA1+") " +
					"A JOIN (SELECT "+itemsA1+", "+itemsB1+", count(*) AS Jumlah FROM "+StaticParameter.database+" " +
					"GROUP BY "+itemsA1+", "+itemsB1+") B ON A."+itemA[0].text+" = B."+itemA[0].text;
			for(int i=1; i<itemA.Count;i++){
				if(itemA[i].gameObject.activeInHierarchy) result = result+" AND A."+itemA[i].text+" = B."+itemA[i].text+"";
			}

			result = result+" WHERE A.Jumlah "+itemC[0].text+" B.Jumlah ), 1, 0) AS RESULT";
		}
		bool isInList = false;
		for(int i =0; i<listQueries.Count;i++){
			if(descText.text == listQueries[i].desc) isInList = true;
		}
		if(!isInList){
			InputQuery input = new InputQuery();
			input.Init(result,toggles,descText.text);
			listQueries.Add(input);
			for(int i=0; i<resultList.resultLists.Count;i++){
				//resultText.text = resultText.text+"\n"+listQueries[i].desc;
				if(i<listQueries.Count){
					resultList.labels[i].text = listQueries[i].desc;
					resultList.resultLists[i].gameObject.SetActive(true);
				}else{
					resultList.resultLists[i].gameObject.SetActive(false);
				}
			}
			queryDependent.QuerySave();
		}else{
			Debug.LogError("already in list");
		}
//		resultText.text = listQueries[0].query;
//		for(int i=1; i<listQueries.Count;i++){
//			resultText.text = resultText.text+"\n"+listQueries[i].query;
//		}
//		if(resultText.text==""){
//			resultText.text = result;
//		}else{
//			resultText.text = resultText.text+"\n"+result;
//		}
	}

	public void Delete(){
		string toggles;
		string result="";
		if(hardToggle.isOn)	toggles = "hard";
		else toggles = "soft";
		if(thisType==AddType.Unique){
			string item = itemA[0].text;
			for(int i=0;i<itemB.Count;i++){
				if(itemB[i].gameObject.activeInHierarchy) item = item+", "+itemB[i].text;
			}
			result = "SELECT IF (EXISTS (SELECT * FROM (SELECT COUNT( * ) AS JUMLAH FROM "+StaticParameter.database+" GROUP BY "+item+") AS A WHERE ( JUMLAH > 1)),1 ,0) AS RESULT";
		}else if(thisType==AddType.Number){
			result = "SELECT IF (EXISTS (SELECT * FROM "+StaticParameter.database+" GROUP BY "+itemA[0].text+" HAVING COUNT("+itemA[0].text+")>"+itemB[0].text+"), 1, 0) AS RESULT";
		}else if(thisType==AddType.Value){
			result = "SELECT IF (EXISTS (SELECT * FROM "+StaticParameter.database+" WHERE (("+itemA[0].text+" "+itemC[0].text+" "+itemB[0].text+") AND ("+itemA[1].text+" "+itemC[1].text+" "+itemB[1].text+"))) ), 1, 0) AS RESULT";
		}else if(thisType==AddType.Relation){
			string itemsA1 = itemA[0].text;
			string itemsA2 = "A."+itemsA1;
			for(int i=1;i<itemA.Count;i++){
				if(itemA[i].gameObject.activeInHierarchy){
					itemsA1 = itemsA1+", "+itemA[i].text;
					itemsA2 = itemsA2+", A."+itemA[i].text;
				}
			}
			string itemsB1 = itemB[0].text;
			string itemsB2 = "B."+itemB[0].text;
			for(int i=1;i<itemB.Count;i++){
				if(itemB[i].gameObject.activeInHierarchy){
					itemsB1 = itemsB1+", "+itemB[i].text;
					itemsB2 = itemsB2+", B."+itemB[i].text;
				}
			}
			result = "SELECT IF(EXISTS ( SELECT "+itemsA2+", A.Jumlah, B.Jumlah " +
				"FROM (SELECT "+itemsA1+", count(*) AS Jumlah FROM "+StaticParameter.database+" " +
					"GROUP BY "+itemsA1+") " +
					"A JOIN (SELECT "+itemsA1+", "+itemsB1+", count(*) AS Jumlah FROM "+StaticParameter.database+" " +
					"GROUP BY "+itemsA1+", "+itemsB1+") B ON A."+itemA[0].text+" = B."+itemA[0].text;
			for(int i=1; i<itemA.Count;i++){
				if(itemA[i].gameObject.activeInHierarchy) result = result+" AND A."+itemA[i].text+" = B."+itemA[i].text+"";
			}
			
			result = result+" WHERE A.Jumlah "+itemC[0].text+" B.Jumlah ), 1, 0) AS RESULT";
		}
		InputQuery input = new InputQuery();
		input.Init(result,toggles,descText.text);
		//Debug.Log(input.query);
		for(int i=listQueries.Count-1; i>-1; i--){
			if(listQueries[i].query == input.query){
				listQueries.RemoveAt(i);
				//Debug.Log("deleted");
			}
		}
		if(listQueries.Count>0){
			resultText.text = listQueries[0].query;
			for(int i=1; i<listQueries.Count;i++){
				resultText.text = resultText.text+"\n"+listQueries[i].query;
			}
		}else{
			resultText.text="";
		}
	}

	public void DeleteByList(){
		for(int i=resultList.resultLists.Count-1; i>-1;i--){
			if(resultList.resultLists[i].isOn){
				queryDependent.QueryDeleteByList(i);
				listQueries.RemoveAt(i);
			}
		}
		for(int i=0; i<resultList.resultLists.Count;i++){
			//resultText.text = resultText.text+"\n"+listQueries[i].desc;
			if(i<listQueries.Count){
				resultList.labels[i].text = listQueries[i].desc;
				resultList.resultLists[i].gameObject.SetActive(true);
			}else{
				resultList.resultLists[i].gameObject.SetActive(false);
			}
			resultList.resultLists[i].isOn = false;
		}
	}

}

public class InputQuery{

	public string query;
	public string type;
	public string desc;

	public void Init(string nQuery, string nType, string nDesc){
		query = nQuery;
		type = nType;
		desc = nDesc;
	}

}
