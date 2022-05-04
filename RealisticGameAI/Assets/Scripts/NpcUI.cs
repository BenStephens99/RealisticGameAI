using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NpcUI : MonoBehaviour
{
    NPCController npcPrefab;
    private Transform player;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI likeText;

    void Awake () {
        npcPrefab = GetComponentInParent<NPCController>();
        player = FindObjectOfType<Player>().transform;
    }

    void Start() {
        nameText.text = npcPrefab.npc.fullName;
    }
    void LateUpdate() {
        transform.LookAt(transform.position + player.forward);
        if (npcPrefab.npc.interacting == true) {
            likeText.text = npcPrefab.npc.UIText;
        } else {
            likeText.text = "";
        }
        
    }
}
