using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Button_Action : MonoBehaviour
{

    void Start()
    {
        GameObject btnObj = GameObject.Find("AR1");
        //"Button"为你的Button的名称 
        Button btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate()
        {
            this.GoNextScene(btnObj);
        });
    }

    public void GoNextScene(GameObject NScene)
    {
        Application.LoadLevel("scene-AR1");
        //切换到场景
    }
}