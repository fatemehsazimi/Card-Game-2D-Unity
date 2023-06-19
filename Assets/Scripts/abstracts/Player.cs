using System;

[System.Serializable]
public class Player 
{
   
   public int health, mana;
   public int ID;
   public bool myTurn;
   public string playerName;
   

    public Player(int health, int mana, int ID)
    {
        this.health = health;
        this.mana = mana;
        this.ID = ID;
        
    }

   
}
