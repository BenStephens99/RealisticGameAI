using System;
using UnityEngine;


public class NPCActions {

    public static void decide(NPC me, string output) {
        Debug.Log(output);
        switch (output) {
            case "Neutral ":
            speak(me, "Neutral");
            return; 
            case "Negative ":
            speak(me, "Ugh its you");
            break;

            case "Negative Name ":
            speak(me, "Ugh its you " + me.interactingWith.fullName);
            break;
    
            case "Positive ":
            speak(me, "Hi! I never caught your name?");
            stop(me);
            if (me.interactingWith.controller != null) {
                stop(me.interactingWith);
                }
            learnName(me);
            break;
            
            case "Positive Name ":
            speak(me, "Hi, " + me.interactingWith.fullName);
            break;
            
            case "PositivePlus Name ":
            speak(me, "Hey hows it going " + me.interactingWith.fullName);
            stop(me);
            if (me.interactingWith.controller != null) {
                stop(me.interactingWith);
                }
            break;
        }
    }

    public static void learnName(NPC npc){
        npc.memory.get(npc.interactingWith.idNumber).name = npc.interactingWith.fullName;
    }
    public static void speak(NPC npc, string text){
        Debug.Log(text);
        npc.UIText = text;
    }
    public static void goToWork(NPC npc) {
        npc.nextDestination = npc.workPos;
        npc.stateMachine.changeState(StateMachine.moving);
    }

    public static void work (NPC npc) {
        npc.stateMachine.changeState(StateMachine.working);
    }

    public static void interact (NPC npc, NPC npc2) {
        npc.stateMachine.changeState(StateMachine.interacting);
    }

    public static void stop(NPC npc) {
        npc.controller.stop();
    }

    public static void go (NPC npc) {
        npc.controller.go();
    }



}
