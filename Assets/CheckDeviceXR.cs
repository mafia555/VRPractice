using System.Collections.Generic;
using UnityEngine;
public class CheckDeviceXR : MonoBehaviour
{

    void Start()
    {
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        var inputDevices = new List<UnityEngine.XR.InputDevice>();
        var desiredCharacteristics = UnityEngine.XR.InputDeviceCharacteristics.HeldInHand 
            | UnityEngine.XR.InputDeviceCharacteristics.Right 
            | UnityEngine.XR.InputDeviceCharacteristics.Controller;
        UnityEngine.XR.InputDevices.GetDevicesWithCharacteristics(desiredCharacteristics, inputDevices);

        foreach (var device in inputDevices)
        {
            if (device.name != "Head Tracking - OpenXR")
            {
                Debug.Log(string.Format("Device found with name '{0}' and role '{1}'", device.name, device.characteristics.ToString()));
            }
        }
    }
}

