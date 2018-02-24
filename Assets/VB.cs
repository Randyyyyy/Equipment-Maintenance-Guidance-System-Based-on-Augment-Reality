using UnityEngine;
using System.Collections;
using Vuforia;

public class VB : MonoBehaviour, IVirtualButtonEventHandler
{

    private GameObject _text;
    private GameObject _Cube;

    void Start()
    {
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            // Register with the virtual buttons TrackableBehaviour
            vbs[i].RegisterEventHandler(this);
        }
        _text = transform.FindChild("3Dtext").gameObject;
        _Cube = transform.FindChild("Cube").gameObject;
        _text.SetActive(false);

    }

    // Update is called once per frame

    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        _Cube.SetActive(false);
        _text.SetActive(true);

    }

    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        _text.SetActive(false);
        _Cube.SetActive(true);
    }
}
