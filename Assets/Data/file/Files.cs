using UnityEngine;
using UnityEngine.UI;

public class Files : MonoBehaviour
{

    public GameObject file;
    public Image textFile;
    public GameObject empty;

    private Object[] images;
    private Object[] text;

    private GameObject imageInst;
    private Transform fileList;

    private float width;
    private float height;
    private Text textInFile;
    private RectTransform textFileRect;
    private RectTransform textFileRectInside;
    private Image textInst;
    
    void LoadImages()
    {
        foreach (Texture2D t in images)
        {
            imageInst = Instantiate(file, transform.position, Quaternion.identity) as GameObject;
            Sprite NewSprite = new Sprite();
            NewSprite = Sprite.Create(t, new Rect(0, 0, t.width, t.height), new Vector2(0, 0));
            imageInst.GetComponent<Image>().sprite = NewSprite;
            imageInst.transform.SetParent(fileList, false);
        }
    }
    void LoadText()
    {
        foreach (TextAsset t in text)
        {
            textInFile.text = t.text;

            width = textFileRect.rect.width;
            height = textFileRect.rect.height;
            textFileRectInside.sizeDelta = new Vector2(width, height);

            textInst = Instantiate(textFile, transform.position, Quaternion.identity) as Image;
            textInst.transform.SetParent(fileList, false);
        }
    }
    void Start ()
    {
        images = Resources.LoadAll("streaming assets", typeof(Texture2D));
        text= Resources.LoadAll("streaming assets", typeof(TextAsset));
        
        GameObject emptyInst;
       
        textInFile = textFile.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>();
        textFileRect = textFile.gameObject.GetComponent<RectTransform>();
        textFileRectInside = textFile.gameObject.transform.GetChild(0).gameObject.GetComponent<RectTransform>();
        fileList = GameObject.FindGameObjectWithTag("FileList").transform;

        LoadImages();
        LoadText();

        emptyInst = Instantiate(empty, transform.position, Quaternion.identity) as GameObject;
        emptyInst.transform.SetParent(fileList, false);
        
    }
	
	void Update ()
    {
		
	}
}