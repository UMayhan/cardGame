using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;



public class WarriorDeck : MonoBehaviour
{
    //
    // переменные чтобы создать колоду карт для определенного класа с определенного набора карт
    //
    public List<Card> deck = new List<Card>();
    public int x;

    

    //private string WarDeck = "Resources/WarDeck";
    //public int deckSize = 20;
    
   


    // Start is called before the first frame update
    void Start()
    {
        //deck = deckSize;
        x = 0;
        
        for (int i = 0; i < 20; i++)
        {
            
            x = Random.Range(1, 4);
            deck[i] = (Card)Resources.Load("WarDeck/WarriorCard_"+x.ToString());
            // "Done" для каждого места в колоде выбрать карту из существующих наборов обьектов


            //deck[i] = (Card)AssetDatabase.LoadAssetAtPath(WarDeck, typeof(Card));
            //deck[i] = Resources.Load<Card>(x.ToString());
            //deck[i] = CardDatabase.cardDatabase[x];

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
