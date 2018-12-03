using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Files : MonoBehaviour
{
    public Image textFile;
    public GameObject empty;
    public GameObject file;

    private File photo;
    private File text;
    
    void Start ()
    {
        photo = new Photos(file);
        photo.Load();
        text = new TextFile(textFile);
        text.Load();

        GameObject emptyInst;

        emptyInst = Instantiate(empty, transform.position, Quaternion.identity) as GameObject;
        emptyInst.transform.SetParent(GameObject.FindGameObjectWithTag("FileList").transform, false);
        
    }
}