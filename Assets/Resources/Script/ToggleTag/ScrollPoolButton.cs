using UnityEngine;
using System.Collections;

public class ScrollPoolButton : MonoBehaviour {

	public int value;
	public ScrollPoolParameter scrollPoolParameter;

	public void Choose(){
		scrollPoolParameter.Choose(value);
	}
}
