using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public List<Player> players = new List<Player>();
     

    internal void AssignTurn(int currentPlayerTurn)
    {
        foreach(Player player in players){
            player.myTurn = player.ID == currentPlayerTurn;
            if (player.myTurn) player.mana=5;
        }
        UIManager.instance.UpdateManaValues(players[0].mana, players[1].mana);
        
    }

    public void DamagePlayer(int ID, int damage)
    {
        Player player = FindPlayerByID(ID);
        // Debug.Log("damage: "+ health);
        player.health -= damage;
        UIManager.instance.UpdateHealthValues(players[0].health,players[1].health);


        if(player.health <= 0)
        {
            PlayerLost(ID);
        }
        // GameObject playerUI = GameObject.FindGameObjectWithTag("playArea");                
        // Destroy(playerUI. transform. GetChild(0). gameObject); 

        // GameObject playerUI2 = GameObject.FindGameObjectWithTag("playArea2");                
        // Destroy(playerUI2. transform. GetChild(0). gameObject);
    }

    private void PlayerLost(int ID)
    {
        UIManager.instance.GameFinished(ID==0?FindPlayerByID(1):FindPlayerByID(0));
    }

    // // public Player[] playersArray;
    private void Awake() {
        instance = this;  
    }

    private void Start() {
        UIManager.instance.UpdateValues(players[0], players[1]);
    }

    public Player FindPlayerByID(int ID){
        Player foundPlayer = null;
       /* foreach(Player player in players){
            if(player.ID == currentPlayerTurn)
            {
                player.myTurn = true;
            }  
            else
            {
                player.myTurn = false;
            }
            if (player.ID == ID)
            foundPlayer = player;
        }
          */
        foundPlayer= players[ID];
        // Player player = players.Find(x => x.ID == currentPlayerTurn);
        // player.myTurn=true;
        return foundPlayer;
    }

    internal void SpendMana(int ownerID, int manaCost)
    {
        FindPlayerByID(ownerID).mana -= manaCost;
        UIManager.instance.UpdateManaValues(players[0].mana,players[1].mana);
    }
}
