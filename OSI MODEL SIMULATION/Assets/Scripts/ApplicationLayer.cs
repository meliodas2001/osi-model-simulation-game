using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationLayer : Layers
{
    public GameObject player;
    public GameManager gm;
    
   
    private void Awake()
    {
        layerIndex = 0;
    }
    private void Start()
    {
       
    }
    public override void forwardProtocal()
    {
        gm.setDisplayName(gm.getUserName());
        dialogueManager.setDialogues(dialogue);
        dialogueManager.startDialogueSystem();
    }

    public override void reverseProtocal()
    {
        gm.setDisplayName("");
        gm.displayPopMsg("");
        gm.displayPopMsg("message successfully received");
    }
}
