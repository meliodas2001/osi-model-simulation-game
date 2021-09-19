using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalLayer : Layers
{
    public GameObject player;
    public GameManager gm;
    private Vector3 playerTransform;
    public GameObject particalObject;
    public Transform tpPosition;

    private void Awake()
    {
        layerIndex = 6;
        playerTransform = player.transform.position;
    }
    public override void forwardProtocal()
    {

        particalObject.SetActive(true);
        player.SetActive(false);
        dialogueManager.setDialogues(dialogue);
        dialogueManager.startDialogueSystem();
    }

    public override void reverseProtocal()
    {
        player.SetActive(true);
        player.transform.position = tpPosition.position;
        particalObject.SetActive(false);
        gm.displayPopMsg("");
        gm.displayPopMsg("arrived at receiver's system");
    }
}
