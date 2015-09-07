using UnityEngine;
using System.Collections;

public class Loadings : MonoBehaviour {

	public GameObject thisScreen;
	public GameObject startButton;
	public enum loadingType{endless,shorts};
	public loadingType type;
	public Animator anim;

	public ScheduleTableToggleList scheduleList;

	//int randCount;

	void Start(){
		//randCount = (int) Random.Range(100,150);
		if(StaticParameter.isNewProject) type = loadingType.shorts;
		else type = loadingType.endless;
	}

	public void Load(){
		if(type==loadingType.endless){
			anim.SetInteger("numberAnimation",0);
		}else if(type==loadingType.shorts){
			scheduleList.ShowToggles();
			thisScreen.SetActive(false);
			startButton.SetActive(true);
		}
	}
	public void CountAnim(){
		if(anim.GetInteger("numberAnimation")<150){
			anim.SetInteger("numberAnimation",anim.GetInteger("numberAnimation")+1);
			Debug.Log(anim.GetInteger("numberAnimation"));
		}
	}
}
