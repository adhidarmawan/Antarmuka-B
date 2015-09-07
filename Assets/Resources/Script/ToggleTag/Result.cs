using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Result : MonoBehaviour {

	public Toggle thisToggle;
	public Text textQuery;
	public ResultList resultList;
	public int number;

	public void ToggleResult(){
		if(thisToggle.isOn){
			textQuery.text = resultList.addButtonRedundant.listQueries[number].query;
		}else{
			textQuery.text = "";
		}
	}

}
