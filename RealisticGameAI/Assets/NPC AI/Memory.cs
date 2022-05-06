using System.Collections;
using System.Collections.Generic;
using System;

public struct Info {
    public int relationship;
    public string name;

    public void increase() {
        relationship += 5;
    }
}

public class Memory {

static Random rand = new Random();

public Memory() {}
public class npcNode {
    public int idNum;
    public string name;
    public int relationship;
    public npcNode left;
    public npcNode right;
    public npcNode(int id) {
        idNum = id;
        name = "Unknown";
        relationship = rand.Next(0, 100);
    }
}

npcNode root = null;

    public void increaseOpinion(int num) {
        //get(num).increase;
    }
    public bool isEmpty() {
        if (root == null) {
            return true;
        } else {
            return false;
         }
    }

    public npcNode get(int num) {
        npcNode npc = search(num);

        if (npc == null) {
            return add(num);
        } else {
            return npc;
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