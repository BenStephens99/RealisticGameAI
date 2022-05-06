using System;
using UnityEngine;


public class NPCActions {
static System.Random rand = new System.Random();
    public static void decide(NPC me, string output) {

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

            case "Serve ": 
            speak(me, output);
            getServed(me.interactingWith);
            break;

            case "No Serve ":
            speak(me, output);
            dontGetServed(me.interactingWith);
            break;

            case "Serve Name ":
            speak (me, output);
            getServed(me.interactingWith);
            break;

            case "No Serve Name ":
            speak (me, output);
            dontGetServed (me.interactingWith);
            break;

            case "Serve Discount Name ":
            speak(me, output);
            getServed(me.interactingWith);
            break;

            default: 
            speak (me, output);
            break;
        }
    }

    public static void getServed(NPC npc) {
        if (npc.job is Merchant) {
            NPCActions.goToWork(npc);
        } else {
            NPCActions.goHome(npc);
        }
    }
    public static void dontGetServed(NPC npc) {
         if (npc.job is Merchant) {
            NPCActions.goToWork(npc);
        }   else {
                NPCActions.goHome(npc);
            }
    }
    public static void learnName(NPC npc){
        npc.memory.get(npc.interactingWith.idNumber).name = npc.interactingWith.fullName;
    }
    public static void speak(NPC npc, string text){
   
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

    public static void goToCoffeeShop(NPC npc) {
        npc.nextDestination = JobManager.coffeeShops[rand.Next(0, JobManager.coffeeShops.Length)].orderingPos[rand.Next(0,2)];
        npc.stateMachine.changeState(StateMachine.moving);
    } 

    public static void goToBar(NPC npc) {
        npc.nextDestination = JobManager.bars[rand.Next(0, JobManager.bars.Length)].orderingPos[rand.Next(0,2)];
        npc.stateMachine.changeState(StateMachine.moving);
    }

    public static void goHome(NPC npc) {
        npc.nextDestination = npc.house;
        if (npc.controller != null) {
            npc.controller.go();
        }
    }

    public static void goToMerchant(NPC npc) {
        npc.nextDestination = JobManager.itemShops[0].orderingPos[0];
        if (npc.controller != null) {
            npc.controller.go();
        }
    }

}
