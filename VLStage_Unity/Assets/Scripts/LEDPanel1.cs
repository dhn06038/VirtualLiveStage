using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LEDPanel1 : MonoBehaviour
{
    public RenderTexture renderTexture;
    public int totalPanelsX = 3; // ���� �г� ����
    public int totalPanelsY = 3; // ���� �г� ����
    public int panelIndexX;      // ���� �г��� ���� �ε���
    public int panelIndexY;      // ���� �г��� ���� �ε���
    private Material material;   // �гο� ������ ���׸���

    void Start()
    {
        // �гο� ������ ���׸��� ��������
        material = GetComponent<Renderer>().material;

        // ���׸��� ���� �ؽ�ó ����

        
        //material.mainTexture = renderTexture;

        // UV ����
        float uvWidth = 1.0f / totalPanelsX;
        float uvHeight = 1.0f / totalPanelsY;

        material.SetTexture("_BaseMap", renderTexture);
        material.SetVector("_BaseColorMap_ST", new Vector4(uvWidth, uvHeight, panelIndexX * uvWidth, panelIndexY * uvHeight));

        Vector2 uvOffset = new Vector2(panelIndexX * uvWidth, panelIndexY * uvHeight);
        Vector2 uvScale = new Vector2(uvWidth, uvHeight);

        // �ؽ�ó�� �Ϻκи� ����
        //material.SetTextureOffset("_MainTex", uvOffset);
        //material.SetTextureScale("_MainTex", uvScale);
    }
}

