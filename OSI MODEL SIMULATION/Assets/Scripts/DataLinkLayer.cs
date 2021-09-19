using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLinkLayer : Layers
{
    public GameObject player;
    public GameManager gm;
    private void Awake()
    {
        layerIndex = 5;
    }
    public override void forwardProtocal()
    {
        gm.displayPopMsg("");
        gm.displayPopMsg("waiting for acknowledgement from receiver");
        dialogueManager.setDialogues(dialogue);
        dialogueManager.startDialogueSystem();
    }

    public override void reverseProtocal()
    {
        gm.displayPopMsg("");
        gm.displayPopMsg("acknowledgement sent to sender");

    }
}
