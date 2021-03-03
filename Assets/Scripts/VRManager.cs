using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRManager : MonoBehaviour
{
    public bool showVR = false;

    private void Update()
    {
        UnityEngine.XR.XRSettings.showDeviceView = true;
    }

}
