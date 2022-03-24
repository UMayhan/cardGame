using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;



public class WarriorDeck : MonoBehaviour
{
    //
    // переменные чтобы создать колоду карт для определенного класа с определенного набора карт
    //
    public int deckSize = 10;
    public List<Card> deck = new List<Card>();
    public int x;

    

    //private string WarDeck = "Resources/WarDeck";
    

    public GameObject cardDeck1;
    public GameObject cardDeck2;
    public GameObject cardDeck3;
    public GameObject cardDeck4;





    // Start is called before the first frame update
    void Start()
    {
        //deck = deckSize;
        x = 0;
        
        for (int i = 0; i < 10; i++)
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
        if (deckSize < 8)
        {
            cardDeck1.SetActive(false);
        }
        else
        {
            cardDeck1.SetActive(true);
        }
        if (deckSize < 6)
        {
            cardDeck2.SetActive(false);
        } else
        {
            cardDeck2.SetActive(true);
        }
        if (deckSize < 3)
        {
            cardDeck3.SetActive(false);
        } else
        {
            cardDeck3.SetActive(true);
        }
        if (deckSize == 0)
        {
            cardDeck4.SetActive(false);
        } else
        {
            cardDeck4.SetActive(true);
        }
    }
}
