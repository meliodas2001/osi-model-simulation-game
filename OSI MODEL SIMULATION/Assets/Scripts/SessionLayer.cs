using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionLayer : Layers
{
    public GameObject player;
    public GameManager gm;
    float cnt = 0;
    private void Awake()
    {
        layerIndex = 2;
    }
    private void Update()
    {
        /*cnt += Time.deltaTime;
        if(cnt>3)
        {
            gm.displayPopMsg("");
        }*/
    }
    public override void forwardProtocal()
    {
        gm.displayPopMsg("");
        gm.displayPopMsg("valid ,access given");
        dialogueManager.setDialogues(dialogue);
        dialogueManager.startDialogueSystem();
    }

    public override void reverseProtocal()
    {
        gm.displayPopMsg("");
        gm.displayPopMsg("valid ,access given");

    }
}
