using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NpcUI : MonoBehaviour
{
    NPC npc;
    private Transform player;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI likeText;

    void Awake () {
        npc = GetComponentInParent<NPC>();
        player = FindObjectOfType<Player>().transform;
        nameText.text = npc.fullName;
    }
    void LateUpdate() {
        transform.LookAt(transform.position + player.forward);
    }
}
