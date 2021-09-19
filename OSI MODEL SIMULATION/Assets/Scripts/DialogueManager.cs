using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Dsu;
    public TextMeshProUGUI pName;
    public TextMeshProUGUI dialogue;
    public Dialogue[] dialogues;
    int cnt = 0;
    void Start()
    {
        Dsu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setDialogues(Dialogue[] dialogues)
    {
        this.dialogues = dialogues;
    }
     public void startDialogueSystem()
    {
        Time.timeScale = 0f;
        if (dialogues == null)
        {
            exitDialogueSystem();
            return;
        }
        Dsu.SetActive(true);
        cnt = 0;
        loadDialogue();
    }

    public void loadDialogue()
    {
        if(cnt>=dialogues.Length)
        {
            exitDialogueSystem();
            return;
        }
        pName.text = dialogues[cnt].getName();
        dialogue.text = dialogues[cnt].getDialogue();
        //exitDialogueSystem();

    }

    public void updateDialogue()
    {
        if(cnt>=dialogues.Length -1)
        {
            exitDialogueSystem();
            return;
        }
        cnt++;
        loadDialogue();
        //exitDialogueSystem();
    }

    public void exitDialogueSystem()
    {
        Time.timeScale = 1f;
        Dsu.SetActive(false);
    }
}
