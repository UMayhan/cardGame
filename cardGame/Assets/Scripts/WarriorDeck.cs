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
    

    public GameObject cardWarDeck1;
    public GameObject cardWarDeck2;
    public GameObject cardWarDeck3;
    public GameObject cardWarDeck4;





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
            cardWarDeck1.SetActive(false);
        }
        else
        {
            cardWarDeck1.SetActive(true);
        }
        if (deckSize < 6)
        {
            cardWarDeck2.SetActive(false);
        } else
        {
            cardWarDeck2.SetActive(true);
        }
        if (deckSize < 3)
        {
            cardWarDeck3.SetActive(false);
        } else
        {
            cardWarDeck3.SetActive(true);
        }
        if (deckSize == 0)
        {
            cardWarDeck4.SetActive(false);
        } else
        {
            cardWarDeck4.SetActive(true);
        }
    }
}
