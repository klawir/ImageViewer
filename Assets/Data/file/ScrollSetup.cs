using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollSetup : MonoBehaviour
{
    private Scrollbar scrollBar;
    public GameObject solarSystem;
    public float solarSystemValue;
    private Vector3 solarSystemBegining;
    public Sprite milkyWay;
    private Sprite defaultBackground;
    public Image background;
    public Canvas canvas;

    void Start ()
    {
        scrollBar = GetComponent<Scrollbar>();
        solarSystemBegining = solarSystem.transform.position;
        defaultBackground = background.sprite;
    }

	void Update ()
    {
        if (scrollBar.value < .01f)
        {
            if (solarSystem.transform.position.y <= canvas.pixelRect.y / 2)
            {
                Vector3 value = solarSystem.transform.position;
                value.y += solarSystemValue;
                solarSystem.transform.position = value;
            }
            background.sprite = milkyWay;
        }
        else
        {
            solarSystem.transform.position = solarSystemBegining;
            background.sprite = defaultBackground;
        }
    }
}
