using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LEDPanel1 : MonoBehaviour
{
    public RenderTexture renderTexture;
    public int totalPanelsX = 3; // 가로 패널 개수
    public int totalPanelsY = 3; // 세로 패널 개수
    public int panelIndexX;      // 현재 패널의 가로 인덱스
    public int panelIndexY;      // 현재 패널의 세로 인덱스
    private Material material;   // 패널에 적용할 메테리얼

    void Start()
    {
        // 패널에 적용할 메테리얼 가져오기
        material = GetComponent<Renderer>().material;

        // 메테리얼에 렌더 텍스처 적용

        
        //material.mainTexture = renderTexture;

        // UV 조정
        float uvWidth = 1.0f / totalPanelsX;
        float uvHeight = 1.0f / totalPanelsY;

        material.SetTexture("_BaseMap", renderTexture);
        material.SetVector("_BaseColorMap_ST", new Vector4(uvWidth, uvHeight, panelIndexX * uvWidth, panelIndexY * uvHeight));

        Vector2 uvOffset = new Vector2(panelIndexX * uvWidth, panelIndexY * uvHeight);
        Vector2 uvScale = new Vector2(uvWidth, uvHeight);

        // 텍스처의 일부분만 적용
        //material.SetTextureOffset("_MainTex", uvOffset);
        //material.SetTextureScale("_MainTex", uvScale);
    }
}

