using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberInput : MonoBehaviour {

	public Text label;
	public int value;

	public void Down(){
		if(value>0){
			value--;
			label.text = value.ToString();
		}
	}

	public void Up(){
		value++;
		label.text = value.ToString();
	}

}
