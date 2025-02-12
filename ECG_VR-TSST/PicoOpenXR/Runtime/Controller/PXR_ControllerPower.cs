/*******************************************************************************
Copyright ? 2015-2022 PICO Technology Co., Ltd.All rights reserved.  

NOTICE：All information contained herein is, and remains the property of 
PICO Technology Co., Ltd. The intellectual and technical concepts 
contained herein are proprietary to PICO Technology Co., Ltd. and may be 
covered by patents, patents in process, and are protected by trade secret or 
copyright law. Dissemination of this information or reproduction of this 
material is strictly forbidden unless prior written permission is obtained from
PICO Technology Co., Ltd. 
*******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using Unity.XR.PXR;
using UnityEngine;
using UnityEngine.XR;

public class PXR_ControllerPower : MonoBehaviour
{
    [SerializeField]
    private Texture power1;
    [SerializeField]
    private Texture power2;
    [SerializeField]
    private Texture power3;
    [SerializeField]
    private Texture power4;
    [SerializeField]
    private Texture power5;

    private Material powerMaterial;
    private float interval = 2f;
    public bool controllerL=false;

    // Start is called before the first frame update
    void Awake()
    {
        if (GetComponent<MeshRenderer>() != null)
        {
            powerMaterial = GetComponent<MeshRenderer>().material;
            
        }
        else
        {
            powerMaterial = GetComponent<SkinnedMeshRenderer>().material;
        }
        
        
        // Vector3 a=Vector3.zero;
        // InputDevices.GetDeviceAtXRNode(XRNode.CenterEye).TryGetFeatureValue(EyeTrackingUsages.gazePosition, out a);
    }

   
    void OnEnable()
    {
        RefreshPower();
    }

    private void RefreshPower()
    {
        var curBattery = 0f;
        if (controllerL)
        {
            InputDevices.GetDeviceAtXRNode(XRNode.LeftHand).TryGetFeatureValue(CommonUsages.batteryLevel, out curBattery);
        }
        else
        {
            InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetFeatureValue(CommonUsages.batteryLevel, out curBattery);
        }
        switch ((int)curBattery)
        {
            case 1:
                {
                    powerMaterial.SetTexture("_MainTex", power1);
                    powerMaterial.SetTexture("_EmissionMap", power1);
                }

                break;
            case 2:
                {
                    powerMaterial.SetTexture("_MainTex", power2);
                    powerMaterial.SetTexture("_EmissionMap", power2);
                }

                break;
            case 3:
                {
                    powerMaterial.SetTexture("_MainTex", power3);
                    powerMaterial.SetTexture("_EmissionMap", power3);
                }

                break;
            case 4:
                {
                    powerMaterial.SetTexture("_MainTex", power4);
                    powerMaterial.SetTexture("_EmissionMap", power4);
                }

                break;
            case 5:
                {
                    powerMaterial.SetTexture("_MainTex", power5);
                    powerMaterial.SetTexture("_EmissionMap", power5);
                }

                break;
            default:
                {
                    powerMaterial.SetTexture("_MainTex", power1);
                    powerMaterial.SetTexture("_EmissionMap", power1);
                }

                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        interval -= Time.deltaTime;
        if (interval > 0) 
            return;
        interval = 2f;

        RefreshPower();
    }
}
