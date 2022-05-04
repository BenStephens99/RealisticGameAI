using System.Collections;
using System.Collections.Generic;

public struct Info {
    public int relationship;
    public string name;
}

public class Memory {

public Memory() {}
public class npcNode {

    public int idNum;
    public Info info;
    public npcNode left;
    public npcNode right;
    public npcNode(int id) {
        idNum = id;
        info.relationship = 50;
        info.name = "Unkown";
    }
}

npcNode root = null;

    public bool isEmpty() {
        if (root == null) {
            return true;
        } else {
            return false;
         }
    }

    public Info get(int num) {
        npcNode npc = search(num);

        if (npc == null) {
            return add(num).info;
        } else {
            return npc.info;
        }

    } 

    public npcNode add(int id) {
        npcNode newNPC = new npcNode(id);

        if (root == null) {
        root = newNPC;
        }
        else {
            npcNode temp = root;
            while (temp != null) {
                if (newNPC.idNum == temp.idNum) {
                    return newNPC;
                }
                else if ((newNPC.idNum < temp.idNum) && (temp.left == null)) {
                    temp.left = newNPC;
                    break;
                }
                else if (newNPC.idNum < temp.idNum) {
                    temp = temp.left;
                }
                else if ((newNPC.idNum > temp.idNum) && (temp.right == null)) {
                    temp.right = newNPC;
                    break;
                }
                else {
                    temp = temp.right;
                }
            }
        } 
        return newNPC;
    }

    
    public npcNode search(int id)
    {
        if (root == null) {
            return root;
        }
        else {
            npcNode temp = root;
            while (temp != null) {
                if (id == temp.idNum) {
                    return temp;
                }
                else if (id < temp.idNum) {
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