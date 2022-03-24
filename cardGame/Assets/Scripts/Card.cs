using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//[System.Serializable]


// 
// добавляем возможность создавать тип файла карта у которого можно менять его характеристики
// 
[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    // 
    // переменные для каждой из характеристики
    // 

    //public int id;
    public Card[] cardList;
    public string cardTitle;
    public string cardType;
    public string cardDescription;
    public int power;
    public int cost;
    public Sprite spriteImage;
    public Sprite spriteFrontImage;
    public Sprite spriteBackImage;
    

    //public Image cardImage;

    //
    // присвоение значение посредством создавания базы данных колоды, решили отказаться от данного решения в сторону ScriptableObject
    //


    /*public Card(int Id, string CardType, string CardTitle, string CardDescription, int Power, int Cost, Sprite SpriteImage)
    {

        id = Id;
        cardTitle = CardTitle;
        cardType = CardType;
        cardDescription = CardDescription;
        power = Power;
        cost = Cost;
        spriteImage = SpriteImage;



    }*/



}
