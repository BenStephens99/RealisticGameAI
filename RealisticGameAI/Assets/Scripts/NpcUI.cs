using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NpcUI : MonoBehaviour
{
    NPCController npcPrefab;
    private Transform player;
    private Transform camera;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI likeText;

    void Awake () {
        npcPrefab = GetComponentInParent<NPCController>();
        player = FindObjectOfType<Player>().transform;
        camera = FindObjectOfType<Camera>().transform;
    }

    void Start() {
        nameText.text = npcPrefab.npc.fullName;
    }
    void LateUpdate() {
        transform.LookAt(transform.position + camera.forward);
        likeText.text = npcPrefab.npc.UIText;
    }
}
