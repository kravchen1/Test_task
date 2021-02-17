using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public GameObject card_prefab;
    public Button click_random_swap;

    public List<GameObject> cards_in_hand;

    private int change_card = 0;
    private int count_cards_in_deck;
    void Start()
    {
        button_initialize();

        count_cards_in_deck = UnityEngine.Random.Range(4, 7);
        create_deck(count_cards_in_deck);
    }
    
    private void button_initialize()
    {
        click_random_swap.onClick.AddListener(() =>
        {
            Resources _change_card = cards_in_hand[change_card].GetComponent<Resources>();
            int rand = UnityEngine.Random.Range(0, 3);
            switch (rand)
            {
                case 0:
                    _change_card.Set_Attack_value(_change_card.Get_Attack_value() - UnityEngine.Random.Range(1, 3));
                    break;
                case 1:
                    _change_card.Set_HP_value(_change_card.Get_HP_value() - UnityEngine.Random.Range(1, 3));
                    break;
                case 2:
                    _change_card.Set_MP_value(_change_card.Get_MP_value() - UnityEngine.Random.Range(1, 3));
                    break;
            }
            change_card++;
            if (change_card >= cards_in_hand.Count)
                change_card = 0;
        });
    }

    private void create_deck(int count_cards_in_deck)
    {
        
        for (int i = 0; i < count_cards_in_deck; i++)
        {
            cards_in_hand.Add(Instantiate(card_prefab, new Vector3(i - count_cards_in_deck / 2, -3, -i * 0.2f), Quaternion.identity) as GameObject);
            if (i < count_cards_in_deck / 2)
            {
                cards_in_hand[i].transform.Rotate(new Vector3(0, 0, (count_cards_in_deck - i) * 4));
            }
            else if (i > count_cards_in_deck / 2)
            {
                cards_in_hand[i].transform.Rotate(new Vector3(0, 0, -i * 4));
            }
        }
    }

}
