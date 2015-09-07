using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ToggleTab : MonoBehaviour {

	public Color activeColor;
	public Color passiveColor;
	public Button thisButton;
	public Image thisImage;
	public GameObject thisPanel;
	public List<Button> otherPanelButton;
	public List<Image> otherPanelColor;
	public List<GameObject> otherPanel;

	public void TogglePanel(){
		for(int i=0; i<otherPanel.Count; i++){
			otherPanel[i].gameObject.SetActive(false);
			otherPanelColor[i].color = passiveColor;
		}
		thisPanel.SetActive(true);
		thisImage.color = activeColor;
	}

}
