using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomButtonClickEventArgs : EventArgs {

}

public class DD_ZoomButton : MonoBehaviour {

    private DD_DataDiagram m_DataDiagram;

    struct RTParam {

        public Transform parent;
        public Rect rect;
        public int dpi;
        public Vector3 scale;
    }

    RTParam[] RTparams = new RTParam[2];
    int paramSN = 0;

    public delegate void ZoomButtonClickHandle(object sender, ZoomButtonClickEventArgs args);
    public ZoomButtonClickHandle ZoomButtonClickEvent;

    private void Awake() {

        m_DataDiagram = GetComponentInParent<DD_DataDiagram>();
        if(null == m_DataDiagram) {
            Debug.LogWarning(this + "Awake Error : null == m_DataDiagram");
            return;
        }
    }

    // Use this for initialization
    void Start () {

        if (null == m_DataDiagram)
            return;

        RectTransform rt;

        RTparams[0].parent = m_DataDiagram.transform.parent;
        rt = m_DataDiagram.GetComponent<RectTransform>();

        RTparams[0].rect = DD_CalcRectTransformHelper.CalcLocalRect(rt.anchorMin, rt.anchorMax,
            RTparams[0].parent.GetComponent<RectTransform>().rect.size, rt.pivot, 
            rt.anchoredPosition, rt.rect);


        RTparams[0].dpi = 243;
        RTparams[1].dpi = 243;
        RTparams[1].parent = GetComponentInParent<Canvas>().transform;
        RTparams[1].rect = new Rect(Screen.width / 5, Screen.height / 5, Screen.width * 2 / 5, Screen.height * 2 / 5);
        RTparams[0].scale = Vector3.one;
        RTparams[1].scale = Vector3.one * 2;
        paramSN = 0;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnZoomButton() {

        if (null == m_DataDiagram)
            return;

        paramSN = (paramSN + 1) % 2;
        m_DataDiagram.SetScreenDpi(RTparams[paramSN].dpi);
        m_DataDiagram.transform.SetParent(RTparams[paramSN].parent);
        m_DataDiagram.rect = RTparams[paramSN].rect;
        m_DataDiagram.transform.localScale = RTparams[paramSN].scale;
        if (paramSN == 1)
        {
            m_DataDiagram.SetPositionAndSize(new Vector2(0, m_DataDiagram.GetComponentInChildren<DD_CoordinateAxis>().GetLinePos(0) - 6), new Vector2(5, 2));
            m_DataDiagram.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        }
        else
        {
            m_DataDiagram.SetPositionAndSize(new Vector2(0, 0), new Vector2(2, 20000));
        }
        if (null != ZoomButtonClickEvent)
            ZoomButtonClickEvent(this, new ZoomButtonClickEventArgs());
    }

}
