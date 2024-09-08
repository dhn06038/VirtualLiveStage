using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;


namespace IA
{
    [ExecuteAlways]
    public class Pyro : DMXFixture
    {
        public override int getUniverse { get { return universe; } }
        public override int getDmxAddress { get { return dmxAddress; } }
        //public override int getNumberOfChannels { get {return channelFunctions.Count;} }
        public override Dictionary<string, int> getChannelFunctions { get { return channelFunctions; } }


        private Dictionary<string, int> channelFunctions = new Dictionary<string, int> { { ChannelName.ON, 0 }};

        [SerializeField]
        GameObject visualEffect;

        void GetWireData()
        {
            if (artNetData.dmxDataMap != null)
            {
                bool isOn = false;

                isOn = ((artNetData.dmxDataMap[universe - 1][dmxAddress - 1 + (int)channelFunctions[ChannelName.ON]] / 256f) != 0f);

                if (isOn)
                {
                    visualEffect.SetActive(true);
                }
                else
                {
                    visualEffect.SetActive(false);
                }
            }
        }
        void Update()
        {
            GetWireData();
        }
        public override void OnEnable()
        {
            base.OnEnable();
            FindDataMap();
            artNetData.dmxUpdate.AddListener(UpdateDMX);
        }
        void UpdateDMX()
        {
            GetWireData();
        }



    }
}
