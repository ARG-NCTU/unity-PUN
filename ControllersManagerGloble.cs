﻿using RosSharp.RosBridgeClient;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.XR;
using Photon.Pun;

public class ControllersManagerGloble : MonoBehaviour
{
    private InputDevice rightController;
    private InputDevice leftController;
    private List<InputDevice> devices = new List<InputDevice>();

    private float gripRightValue, gripLeftValue;
    private float triggerRightValue, triggerLeftValue;
    private bool RightprimaryButtonValue, RightsecondaryButtonValue, LeftprimaryButtonValue, LeftsecondaryButtonValue;
    private Vector2 Rightprimary2DAxisValue, Leftprimary2DAxisValue;
    // Start is called before the first frame update
    void Start()
    {
        InputDevices.GetDevicesAtXRNode(XRNode.LeftHand, devices);
        if (devices.Count > 0)
        {
            leftController = devices[0];
            Debug.Log(string.Format("Device name '{0}' with role '{1}'", leftController.name, leftController.characteristics.ToString()));
        }

        InputDevices.GetDevicesAtXRNode(XRNode.RightHand, devices);
        if (devices.Count > 0)
        {
            rightController = devices[0];
            Debug.Log(string.Format("Device name '{0}' with role '{1}'", rightController.name, rightController.characteristics.ToString()));
        }
    }

    //-------RIGHT CONTROLLER------------//
    public float getRightGrip()
    {
        //rightController.TryGetFeatureValue(CommonUsages.grip, out float gripRightValue);
        return gripRightValue;
    }

    public float getRightTrigger()
    {
        //rightController.TryGetFeatureValue(CommonUsages.trigger, out float triggerRightValue);
        return triggerRightValue;
    }

    public bool getRightPrimaryButton()
    {
        //rightController.TryGetFeatureValue(CommonUsages.primaryButton, out bool RightprimaryButtonValue);
        return RightprimaryButtonValue;
    }

    public bool getRightSecondaryButton()
    {
        //rightController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool RightsecondaryButtonValue);
        return RightsecondaryButtonValue;
    }

    public void sendRightHaptic(float amplitude, float duration)
    {
        //rightController.SendHapticImpulse(0, amplitude, duration);
    }

    public Vector2 getRightPrimary2DAxis()
    {
        //rightController.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 Rightprimary2DAxisValue);
        return Rightprimary2DAxisValue;
    }

    [PunRPC]

    public void getNetworkRightGrip(float gripRightValue)
    {
        this.gripRightValue = gripRightValue;
    }

    [PunRPC]
    public void getNetworkRightTrigger(float triggerRightValue)
    {
        this.triggerRightValue = triggerRightValue;
    }

    [PunRPC]
    public void getNetworkRightPri(bool RightprimaryButtonValue)
    {
        this.RightprimaryButtonValue = RightprimaryButtonValue;
    }

    [PunRPC]
    public void getNetworkRightSec(bool RightsecondaryButtonValue)
    {
        this.RightsecondaryButtonValue = RightsecondaryButtonValue;
    }

    [PunRPC]
    public void getNetworkRightPrimary2DAxis(Vector2 Rightprimary2DAxisValue)
    {
        this.Rightprimary2DAxisValue = Rightprimary2DAxisValue;
    }

    //-------------------------------------------------------//

    //-------LEFT CONTROLLER------------//
    public float getLeftGrip()
    {
        //leftController.TryGetFeatureValue(CommonUsages.grip, out float gripLeftValue);
        return gripLeftValue;
    }

    public float getLeftTrigger()
    {
        //leftController.TryGetFeatureValue(CommonUsages.trigger, out float triggerLeftValue);
        return triggerLeftValue;
    }

    public bool getLeftPrimaryButton()
    {
        //leftController.TryGetFeatureValue(CommonUsages.primaryButton, out bool LeftprimaryButtonValue);
        return LeftprimaryButtonValue;
    }

    public bool getLeftSecondaryButton()
    {
        //leftController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool LeftsecondaryButtonValue);
        return LeftsecondaryButtonValue;
    }

    public void sendLeftHaptic(float amplitude, float duration)
    {
        //leftController.SendHapticImpulse(0, amplitude, duration);
    }

    public Vector2 getLeftPrimary2DAxis()
    {
        //leftController.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 Leftprimary2DAxisValue);
        return Leftprimary2DAxisValue;
    }

    [PunRPC]
    public void getNetworkLeftGrip(float gripLeftValue)
    {
        this.gripLeftValue = gripLeftValue;
    }

    [PunRPC]
    public void getNetworkLeftTrigger(float triggerLeftValue)
    {
        this.triggerLeftValue = triggerLeftValue;
    }

    [PunRPC]
    public void getNetworkLeftPri(bool LeftprimaryButtonValue)
    {
        this.LeftprimaryButtonValue = LeftprimaryButtonValue;
    }

    [PunRPC]
    public void getNetworkLeftSec(bool LeftsecondaryButtonValue)
    {
        this.LeftsecondaryButtonValue = LeftsecondaryButtonValue;
    }

    [PunRPC]
    public void getNetworkLeftPrimary2DAxis(Vector2 Leftprimary2DAxisValue)
    {
        this.Leftprimary2DAxisValue = Leftprimary2DAxisValue;

        //-------------------------------------------------------//
    }
}