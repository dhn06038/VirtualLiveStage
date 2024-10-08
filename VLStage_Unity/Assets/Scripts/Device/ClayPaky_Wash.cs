﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IA
{
    [ExecuteAlways]
    public class ClayPaky_Wash : DMXFixture
    {
        public override int getUniverse { get { return universe; } }
        public override int getDmxAddress { get { return dmxAddress; } }
        //public override int getNumberOfChannels { get {return channelFunctions.Count;} }
        public override Dictionary<string, int> getChannelFunctions { get { return channelFunctions; } }


        [SerializeField]
        Transform panMotor;
        [SerializeField]
        Transform lightHead;

        new Light[] light;

        [Header("rotateProps")]
        public float panMovement = 360f;
        public float tiltMovement = 180f;
        float panTarget;
        float tiltTarget;
        float maxRotSpeed = 100f;
        private Dictionary<string, int> channelFunctions = new Dictionary<string, int> { { ChannelName.RED, 0 }, { ChannelName.GREEN, 1 }, { ChannelName.BLUE, 2 }, { ChannelName.WHITE, 3 }, { ChannelName.DIMMER, 7 }, { ChannelName.PAN, 9 }, { ChannelName.TILT, 11 }};

        float pan;
        float tilt;
        float rotSpeed;
        bool update = true;
        [SerializeField]
        float refreshRate = 5f;
        float maxIntensity = 20f;
        float strobeTimer = 0;
        void SetPan()
        {
            pan = panMotor.localEulerAngles.y;
            panTarget = (artNetData.dmxDataMap[universe - 1][dmxAddress - 1 + (int)channelFunctions[ChannelName.PAN]]) * panMovement / 256f;
        }
        void SetTilt()
        {
            tiltTarget = (artNetData.dmxDataMap[universe - 1][dmxAddress - 1 + (int)channelFunctions[ChannelName.TILT]]) * tiltMovement / 256f;
            tilt = lightHead.localEulerAngles.x;
        }

        void Update()
        {
            GetWireData();
            UpdateRotation();
        }
        void UpdateRotation()
        {

            var dpan = (panTarget - pan);
            var dtilt = (tiltTarget - tilt);

            if (0 != dpan)
            {
                panMotor.transform.localEulerAngles = new Vector3(0, panTarget, 0);
            }
            if (0 != dtilt)
            {
                lightHead.transform.localEulerAngles = new Vector3(90f-tiltTarget, 0, 0);
            }
        }
        IEnumerator UpdateThread()
        {
            #if UNITY_EDITOR
            while (update)
            {
                GetWireData();
                UpdateRotation();
                yield return new WaitForSeconds(1 / refreshRate);
            }
            #endif
        }
        
        void SetColor()
        {
            var color = light[0].color;

            color.r = artNetData.dmxDataMap[universe - 1][dmxAddress - 1 + (int)channelFunctions[ChannelName.RED]] / 256f;
            color.g = artNetData.dmxDataMap[universe - 1][dmxAddress - 1 + (int)channelFunctions[ChannelName.GREEN]] / 256f;
            color.b = artNetData.dmxDataMap[universe - 1][dmxAddress - 1 + (int)channelFunctions[ChannelName.BLUE]] / 256f;
            color += Color.white * artNetData.dmxDataMap[universe - 1][dmxAddress - 1 + (int)channelFunctions[ChannelName.WHITE]] / 256f;

            float dimmer = artNetData.dmxDataMap[universe - 1][dmxAddress - 1 + (int)channelFunctions[ChannelName.DIMMER]] / 256f;
            color = color * (dimmer);

            light[0].color = color;
            light[1].color = color;

        }

        public override void OnEnable()
        {
            base.OnEnable();
            light = GetComponentsInChildren<Light>();
            artNetData.dmxUpdate.AddListener(UpdateDMX);
            StartCoroutine(UpdateThread());
        }
        void UpdateDMX()
        {
            GetWireData();
            UpdateRotation();
        }
        void GetWireData()
        {
            if (artNetData.dmxDataMap != null)
            {
                SetColor();
                SetPan();
                SetTilt();
            }
        }
        void OnDisable()
        {
            update = false;
        }
    }
}
