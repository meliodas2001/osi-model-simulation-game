using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransportLayer : Layers
{
    public GameObject player;
    public GameManager gm;
    private void Awake()
    {
        layerIndex = 3;
    }
    public override void forwardProtocal()
    {
        if(GameManager.isCorrupted)
        {
            gm.displayPopMsg("");
            gm.displayPopMsg("corrupted,repairing protocal applied");
            dialogueManager.setDialogues(dialogue);
            dialogueManager.startDialogueSystem();
        }
        else
        {
            gm.displayPopMsg("");
            gm.displayPopMsg("message is  not courrupted");
            dialogueManager.setDialogues(dialogue);
            dialogueManager.startDialogueSystem();
        }
    }

    public override void reverseProtocal()
    {
        if (GameManager.isCorrupted)
        {
            gm.displayPopMsg("segment is corrupted,repairing protocal applied");
            gm.changeColor(GameManager.originalColor);
            GameManager.isCorrupted = false;
        }
        else
        {
            gm.displayPopMsg("segment is not courrupted");

        }
    }
}
