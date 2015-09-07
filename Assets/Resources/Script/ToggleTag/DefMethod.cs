using UnityEngine;
using System.Collections;

public class DefMethod : MonoBehaviour {

	public AddButton uniqueButton;
	public SaveQuery uniqueSave;

	// Use this for initialization
	void Start () {
		//Data.InputRelationshipData1();
		//Data.InputRelationshipData2();
		//Data.InputData5();
		//ExportToDatabase1();
		ExportToDatabase2();
		ExportToDatabase();
		//uniqueButton.DefQuery();
		//uniqueSave.QuerySave();
		Debug.Log("finish saving");
	}

	void ExportToDatabase(){
		NetMySQL tempNetMySQL = uniqueSave.netMySQL;
		Debug.Log("phase1");
		if(DataContainer.normalTable!=null){
			Debug.Log("phase2");
			Debug.Log(DataContainer.normalTable.Count);
			for(int i =0; i<DataContainer.normalTable.Count; i++){
				Debug.Log("phase3");
				for(int j=0; j<DataContainer.normalTable[i].column.Count;j++){
					tempNetMySQL.InsertRelationshipTable1(
						DataContainer.normalTable[i].name,
						DataContainer.normalTable[i].column[j].name,
						DataContainer.normalTable[i].column[j].primaryKey.ToString());
				}
			}
		}
	}

	void ExportToDatabase1(){
		NetMySQL tempNetMySQL = uniqueSave.netMySQL;
		//Debug.Log(tempNetMySQL);
		Debug.Log("phase1");
		if(DataContainer.relationshipTables!=null){
			Debug.Log("phase2");
			Debug.Log(DataContainer.relationshipTables.Count);
			for(int i =0; i<DataContainer.relationshipTables.Count; i++){
				Debug.Log("phase3");
				//Debug.Log(DataContainer.relationshipTables);
				for(int j=0; j<DataContainer.relationshipTables[i].column.Count;j++){
					Debug.Log("phase4");
					tempNetMySQL.InsertRelationshipTable1(
						DataContainer.relationshipTables[i].name,
						DataContainer.relationshipTables[i].column[j].name,
						DataContainer.relationshipTables[i].column[j].primaryKey.ToString());
					for(int l=0; l<DataContainer.relationshipTables[i].relation.Count;l++){
						Debug.Log("phase5");
						Debug.Log("L="+l+"; J="+j);
						if(l!=j){
							Debug.Log("phase6");
							Debug.Log("key="+DataContainer.relationshipTables[i].column[l].primaryKey.ToString());
							if(DataContainer.relationshipTables[i].column[l].primaryKey){
								Debug.Log("J= "+(j+2).ToString()+"; limit= "+DataContainer.relationshipTables[i].relation.Count.ToString());
								if(j+2<DataContainer.relationshipTables[i].relation.Count){
									for(int m=j+2; m<DataContainer.relationshipTables[i].relation.Count;m++){
										Debug.Log("phase7");
										if(DataContainer.relationshipTables[i].column[j].primaryKey)
											tempNetMySQL.InsertRelationshipTable2(
												DataContainer.relationshipTables[i].relation[j],
												DataContainer.relationshipTables[i].relation[l],
												DataContainer.relationshipTables[i].name,
												DataContainer.relationshipTables[i].column[j].name);
												//DataContainer.relationshipTables[i].column[m].name);
										Debug.Log("phase8");
									}
								}else{
									if(DataContainer.relationshipTables[i].column[j].primaryKey)
										tempNetMySQL.InsertRelationshipTable2(
										DataContainer.relationshipTables[i].relation[j],
										DataContainer.relationshipTables[i].relation[l],
										DataContainer.relationshipTables[i].name,
										DataContainer.relationshipTables[i].column[j].name);
									Debug.Log("phase9");

								}
							}
						}
					}
				}
			}
		}
	}
	void ExportToDatabase2(){
		NetMySQL tempNetMySQL = uniqueSave.netMySQL;
		//Debug.Log(tempNetMySQL);
		Debug.Log("phase1");
		if(DataContainer.relationshipTable2!=null){
			Debug.Log("phase2");
			for(int i =0; i<DataContainer.relationshipTable2.Count; i++){
				for(int j =0; j<DataContainer.relationshipTable2[i].column.Count; j++){
					tempNetMySQL.InsertRelationshipTable2(
						DataContainer.relationshipTable2[i].name,
						DataContainer.relationshipTable2[i].column[j].datas[0],
						DataContainer.relationshipTable2[i].column[j].datas[1],
						DataContainer.relationshipTable2[i].column[j].datas[2]);
				}
			}
		}
	}
}
