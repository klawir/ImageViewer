using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Photos : File, IFile
{
    private GameObject imageInst;
    private GameObject file;
    private Transform fileList;

    public Photos(GameObject pref)
    {
        files = Resources.LoadAll("streaming assets", typeof(Texture2D));
        fileList = GameObject.FindGameObjectWithTag("FileList").transform;
        file = pref;
    }
    public void Load()
    {
        foreach (Texture2D t in files)
        {
            imageInst = Instantiate(file, fileList.transform.position, Quaternion.identity) as GameObject;
            Sprite NewSprite = new Sprite();
            NewSprite = Sprite.Create(t, new Rect(0, 0, t.width, t.height), new Vector2(0, 0));
            imageInst.GetComponent<Image>().sprite = NewSprite;
            imageInst.transform.SetParent(fileList, false);
        }
    }
}