using System.Collections;
using System.Collections.Generic;

public struct Info {
    public int idNum;
    public int relationship;
    public string name;
}

public class Memory {

public Memory() {}
public class npcNode {

public Info info;

public npcNode left;
public npcNode right;
public npcNode(int id) {
    id = info.idNum;
}

}

npcNode root = null;

    bool isEmpty() {
        if (root == null) {
            return true;
        } else {
            return false;
         }
    }

    void add(NPC npc) {
    npcNode newNPC = new npcNode(npc.idNumber);

        if (root == null) {
        root = newNPC;
        }
        else {
            npcNode temp = root;
            while (temp != null) {
                if (newNPC.info.idNum == temp.info.idNum) {
                    return;
                }
                else if ((newNPC.info.idNum < temp.info.idNum) && (temp.left == null)) {
                    temp.left = newNPC;
                    break;
                }
                else if (newNPC.info.idNum < temp.info.idNum) {
                    temp = temp.left;
                }
                else if ((newNPC.info.idNum > temp.info.idNum) && (temp.right == null)) {
                    temp.right = newNPC;
                    break;
                }
                else {
                    temp = temp.right;
                }
            }
        }
    }

    
    npcNode search(int id)
    {
        if (root == null) {
            return root;
        }
        else {
            npcNode temp = root;
            while (temp != null) {
                if (id == temp.info.idNum) {
                    return temp;
                }
                else if (id < temp.info.idNum) {
                    temp = temp.left;
                }
                else {
                    temp = temp.right;
                }
            }
            return null;
        }
    }

}