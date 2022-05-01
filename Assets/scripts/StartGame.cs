using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartGame : MonoBehaviour
{
    public string levelToLoad = "SampleScene" ;
    public Button connectBtn;
    public InputField indxPlayer;
    public RectTransform img; 
    public RectTransform cnvs;
    // Start is called before the first frame update


    private RectTransform cnvsTrans;

    void Start()
    {
		connectBtn.onClick.AddListener(ConnectClick);
        //cnvsTrans = cnvs.getComponent<RectTransform>(); 
        //imgTrans = img.getComponent<RectTransform>();
        
    }

    void Update(){

        img = cnvs;
    }

    void ConnectClick()
    {
        Debug.Log("start");
        Debug.Log(indxPlayer.text);
        SceneManager.LoadScene(levelToLoad);
        
    }
}
