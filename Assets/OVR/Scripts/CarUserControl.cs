using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;



namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {

        private CarController m_Car; // the car controller we want to use


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();

        }

        private void FixedUpdate()
        {
            float v = 0f;
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            
            if (OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0.1f)
            {
                v = OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger);
            }
            else if(OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger) > 0.1f)
            {
                v = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger) * -1f;
            }
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}
