using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ScrollPoolParameter : MonoBehaviour {

	public Text label;
	public List<Button> primaryKeysButton;
	public List<Text> primaryKeysLabel;
	public AddButton sourceParam;
	public GameObject choosers;

	public GameObject layer;

	public void Start(){
		Init();
	}

	public void Init(){
		List<string> tempPrimaryKeysLabel = new List<string>();
		for(int i=0; i<DataContainer.relationshipTable2.Count; i++){
			for(int j=0; j<DataContainer.relationshipTable2[i].column.Count;j++){
				if(DataContainer.relationshipTable2[i].column[j].primaryKey){
					tempPrimaryKeysLabel.Add(DataContainer.relationshipTable2[i].column[j].datas[2]);
				}
			}
		}
		for(int i=0; i<primaryKeysLabel.Count; i++){
			if(i<tempPrimaryKeysLabel.Count){
				primaryKeysLabel[i].text = tempPrimaryKeysLabel[i];
				primaryKeysButton[i].gameObject.SetActive(true);
			}else{
				primaryKeysButton[i].gameObject.SetActive(false);
			}
		}
	}
	public void ShowChooser(){
		choosers.SetActive(true);
	}
	public void Choose(int i){
		sourceParam.parameterPool = primaryKeysLabel[i].text;
		label.text = primaryKeysLabel[i].text;
		choosers.SetActive(false);
	}
	public void ActivateSelection(){
		sourceParam.DefQuery();
		layer.SetActive(true);
	}
}
