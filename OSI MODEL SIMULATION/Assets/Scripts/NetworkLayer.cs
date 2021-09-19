using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkLayer : Layers
{
    public GameObject player;
    public GameManager gm;
    private void Awake()
    {
        layerIndex = 4;
    }
    public override void forwardProtocal()
    {
        string displayName = gm.getDisplayName();
        displayName = "IPS" + displayName + "IPR";
        gm.setDisplayName(displayName);
        dialogueManager.setDialogues(dialogue);
        dialogueManager.startDialogueSystem();
    }

    public override void reverseProtocal()
    {
        string displayName = gm.getDisplayName();
        string temp = "";
        for(int i = 3;i<displayName.Length-3;i++)
        {
            temp = temp + displayName[i];
        }
        gm.setDisplayName(temp);

    }
}
