using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Drawing;
using UnityEngine;

namespace IA
{
    [ExecuteAlways]
    public class Laser : DMXFixture
    {
        public override int getUniverse { get { return universe; } }
        public override int getDmxAddress { get { return dmxAddress; } }
        //public override int getNumberOfChannels { get {return channelFunctions.Count;} }
        public override Dictionary<string, int> getChannelFunctions { get { return channelFunctions; } }

        [SerializeField]
        Transform[] lasers;
        [SerializeField]
        Transform[] laserPan;


        [Header("rotateProps")]
        public float tiltMovement = 180f;
        public float divMovement = 90f;
        float tiltTarget;
        float divTarget;
        float maxRotSpeed = 100f;
        private Dictionary<string, int> channelFunctions = new Dictionary<string, int> { { ChannelName.RED, 0 }, { ChannelName.GREEN, 1 }, { ChannelName.BLUE, 2 }, { ChannelName.ALPHA, 3 }, { ChannelName.TILT, 4 }, { ChannelName.DIV, 5 } };

        float tilt;
        float divpoint;
        float rotSpeed;
        bool update = true;
        [SerializeField]
        float refreshRate = 5f;
        float maxIntensity = 20f;
        float strobeTimer = 0;

        void SetTilt()
        {
            tiltTarget = (artNetData.dmxDataMap[universe - 1][dmxAddress - 1 + (int)channelFunctions[ChannelName.TILT]]) * tiltMovement / 256f;
            tilt = lasers[0].transform.localEulerAngles.x;
        }

        void SetDiv()
        {
            divTarget = (artNetData.dmxDataMap[universe - 1][dmxAddress - 1 + (int)channelFunctions[ChannelName.DIV]]) * divMovement / 256f;
            divpoint = laserPan[0].transform.localEulerAngles.y;
        }

        void Update()
        {
            GetWireData();
            UpdateRotation();
        }
        void UpdateRotation()
        {
            var dtilt = (tiltTarget - tilt);
            var ddiv = (divTarget -  divpoint);

            if ((0 != dtilt))
            {
                foreach (Transform t in lasers)
                {
                    t.localEulerAngles = new Vector3(-tiltTarget / 2, -90, 0);
                }
            }
            if ((0 != ddiv))
            {
                int i = 0;
                foreach (Transform t in laserPan)
                {
                    i++;
                    t.localEulerAngles = new Vector3(0, divTarget, 0);
                }
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
            UnityEngine.Color color;
            color.r = artNetData.dmxDataMap[universe - 1][dmxAddress - 1 + (int)channelFunctions[ChannelName.RED]] / 256f;
            color.g = artNetData.dmxDataMap[universe - 1][dmxAddress - 1 + (int)channelFunctions[ChannelName.GREEN]] / 256f;
            color.b = artNetData.dmxDataMap[universe - 1][dmxAddress - 1 + (int)channelFunctions[ChannelName.BLUE]] / 256f;
            color.a = artNetData.dmxDataMap[universe - 1][dmxAddress - 1 + (int)channelFunctions[ChannelName.ALPHA]] / 256f;

            foreach (Transform t in lasers)
            {
                t.GetComponent<LineRenderer>().SetColors(color, color);
            }
        }


        public override void OnEnable()
        {
            base.OnEnable();
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
                SetTilt();
                SetDiv();
            }
        }
        void OnDisable()
        {
            update = false;
        }
    }
}
