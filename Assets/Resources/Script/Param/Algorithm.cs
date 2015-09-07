using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Algorithm : MonoBehaviour {

	//default
	public InputField maxFitness;
	public InputField iteration;
	public ToggleGroup toggleAlgorithm;
	public string usedAlgorithm;
	//SQL param
	public NetMySQL netMySQL;
	//geneticAlgorithm
	public InputField crossOver;
	public InputField mutationRate;
	//beeSearch
	public InputField randomBee;
	public InputField neighbourBee;

	public void StartAlgorithm(){
		if(usedAlgorithm == "GeneticAlgorithm"){
			GenAlgorithm();
		}else if(usedAlgorithm == "BeeSearch"){
			BeeAlgorithm();
		}else if(usedAlgorithm == "ScatterSearch"){
			ScatterAlgorithm();
		}
		ResetParam();
	}
	public void ResetParam(){
		maxFitness.text = "";
		iteration.text = "";
		crossOver.text = "";
		mutationRate.text = "";
		randomBee.text = "";
		neighbourBee.text = "";
		//Debug.Log(maxFitness.text);
	}
	
	public void GenAlgorithm(){
	//
		int i =0;
		while(i==0){
			string tempResult = "";
			netMySQL.DoQuery("INSTERT "+tempResult);
		}
	}
	
	public void BeeAlgorithm(){
	
	}
	
	public void ScatterAlgorithm(){
	
	}
}
