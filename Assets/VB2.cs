using UnityEngine;
using System.Collections;
using Vuforia;

public class VB2 : MonoBehaviour, IVirtualButtonEventHandler {


    private GameObject _text_1;
    private GameObject _text_2;
    private GameObject _text_3;
    private GameObject _text_4;
    private GameObject _text_5;
 

    void Start()
    {
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            // Register with the virtual buttons TrackableBehaviour
            vbs[i].RegisterEventHandler(this);
        }
        _text_1 = transform.FindChild("Text1").gameObject;
        _text_2 = transform.FindChild("Text2").gameObject;
        _text_3 = transform.FindChild("Text3").gameObject;
        _text_4 = transform.FindChild("Text4").gameObject;
        _text_5 = transform.FindChild("Text5").gameObject;
        _text_2.SetActive(false);
        _text_3.SetActive(false);
        _text_4.SetActive(false);
        _text_5.SetActive(false);

    }

    // Update is called once per frame

    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
       
            _text_1.SetActive(false);
            _text_2.SetActive(true);
            _text_3.SetActive(true);
            _text_4.SetActive(true);
            _text_5.SetActive(true);
        

    }

    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        
        _text_2.SetActive(false);
        _text_3.SetActive(false);
        _text_4.SetActive(false);
        _text_5.SetActive(false);
        _text_1.SetActive(true);
    }
}
