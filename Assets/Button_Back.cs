using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Button_Back : MonoBehaviour {

void Start () 
{ 
GameObject btnObj = GameObject.Find("Back");
//"Button"为你的Button的名称 
Button btn = btnObj.GetComponent<Button>(); 
btn.onClick.AddListener(delegate () 
{ 
this.GoNextScene(btnObj); 
}); 
} 

public void GoNextScene(GameObject NScene) 
{ 
Application.LoadLevel("scene-main");
//切换到场景Scene_2 
} 
} 
