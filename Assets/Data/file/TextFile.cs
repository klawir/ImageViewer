using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFile : File, IFile
{
    private Text textInFile;
    private Image textFile;

    private RectTransform textFileRect;
    private RectTransform textFileRectInside;
    private Image textInst;
    private Transform fileList;

    public TextFile(Image pref)
    {
        textFile = pref;
        files = Resources.LoadAll("streaming assets", typeof(TextAsset));
        fileList = GameObject.FindGameObjectWithTag("FileList").transform;
        textInFile = textFile.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>();
        textFileRect = textFile.gameObject.GetComponent<RectTransform>();
        textFileRectInside = textFile.gameObject.transform.GetChild(0).gameObject.GetComponent<RectTransform>();
    }

    public void Load()
    {
        foreach (TextAsset t in files)
        {
            textInFile.text = t.text;

            width = textFileRect.rect.width;
            height = textFileRect.rect.height;
            textFileRectInside.sizeDelta = new Vector2(width, height);

            textInst = Instantiate(textFile, fileList.transform.position, Quaternion.identity) as Image;
            textInst.transform.SetParent(fileList, false);
        }
    }
}