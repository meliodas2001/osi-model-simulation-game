using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    //i th element tell weather i th row has been visited , 0 means not visited 1 means visited
    public static int[] visitedLayerMask = {0,0,0,0,0,0,0};
    private string username  = InputForNextScene.username;
    private string displayName;

    public TextMeshProUGUI playerNameField;
    public TextMeshProUGUI popMessage;
    public TextMeshProUGUI Timer;
    public ApplicationLayer applicationLayer;
    public PresentationLayer presentationLayer;
    public SessionLayer sessionLayer;
    public TransportLayer transportLayer;
    public NetworkLayer networkLayer;
    public DataLinkLayer dataLinkLayer;
    public PhysicalLayer physicalLayer;
    public GameObject player;
    public GameObject particalObject;
    public static bool isCorrupted = false;
    public static float time = 0;
    public static bool timerIsStarted = false;
    public DialogueManager dialogueManager;
    public Dialogue[] dialogue;

    //-------------------------color scheme of player------------------------------//
    public static Color originalColor = new Color(255,163,4);
    public static Color encryptColor = new Color(255,37,0);
    public static Color corruptColor = new Color(0,131,255);
    float cnt = 0;
    private float popMessageTime = 2f;
  
        
    // Start is called before the first frame update
    void Start()
    {
        this.setDisplayName("");
        changeColor(originalColor);
        player.SetActive(true);
        particalObject.SetActive(false);
        dialogueManager.setDialogues(dialogue);
        dialogueManager.startDialogueSystem();
    }

    // Update is called once per frame
    void Update()
    {
        //defines pop message duration ,remain on the screen for one second
        if(popMessage.text!="")
        {
            cnt += Time.deltaTime;
            if(cnt>popMessageTime)
            {
                popMessage.text = "";
                cnt = 0;
            }
            
        }
        if(isCorrupted)
        {
            changeColor(corruptColor);
        }
        if(timerIsStarted)
        TimerCalc();
    }
    public void TimerCalc()
    {
        time += Time.deltaTime;
        Timer.text = "Time: " + time.ToString();
    }
    public void startTimer()
    {
        timerIsStarted = true;
    }
    public void stopTimer()
    {
        timerIsStarted = false;
    }
    public void displayPopMsg(string message)
    {
        popMessage.text = message;
    }
    public void changeColor(Color color)
    {
        player.GetComponent<SpriteRenderer>().color = color;
    }
    public string getDisplayName()
    {
        return displayName;
    }

    public string getUserName()
    {
        return username;
    }

    public void setDisplayName(string displayName)
    {
        this.displayName = displayName;
        playerNameField.text = displayName;
    }

    public void runProtocol(string layerName)
    {
        switch(layerName)
        {
            case "application": applicationLayer.runProtocal();
                break;
            case "presentation": presentationLayer.runProtocal();
                break;
            case "session": sessionLayer.runProtocal();
                break;
            case "transport":
                transportLayer.runProtocal();
                break;
            case "datalink":
                dataLinkLayer.runProtocal();
                break;
            case "network":
                networkLayer.runProtocal();
                break;
            case "physical":
                physicalLayer.runProtocal();
                break;

        }
    }
}
