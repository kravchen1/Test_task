using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public GameObject card_prefab;
    public Button click_random_swap;

    public List<GameObject> cards_in_hand;
    
    void Start()
    {
        button_initialize();

        create_deck();
    }
    
    private void button_initialize()
    {
        click_random_swap.onClick.AddListener(() =>
        {
            for (int i = 0; i < cards_in_hand.Count; i++)
            {
                int rand = UnityEngine.Random.Range(0, 3);
                switch (rand)
                {
                    case 0:
                        cards_in_hand[i].GetComponent<Resources>().Set_Attack_value(cards_in_hand[i].GetComponent<Resources>().Get_Attack_value() - UnityEngine.Random.Range(1, 2));
                        break;
                    case 1:
                        cards_in_hand[i].GetComponent<Resources>().Set_HP_value(cards_in_hand[i].GetComponent<Resources>().Get_HP_value() - UnityEngine.Random.Range(1, 2));
                        break;
                    case 2:
                        cards_in_hand[i].GetComponent<Resources>().Set_MP_value(cards_in_hand[i].GetComponent<Resources>().Get_MP_value() - UnityEngine.Random.Range(1, 2));
                        break;
                }
            }
        });
    }

    private void create_deck()
    {
        int random_count = UnityEngine.Random.Range(4, 7);
        for (int i = 0; i < random_count; i++)
        {
            cards_in_hand.Add(Instantiate(card_prefab, new Vector3(i - random_count / 2, -3, -i * 0.1f), Quaternion.identity) as GameObject);
            if (i < random_count / 2)
            {
                cards_in_hand[i].transform.Rotate(new Vector3(0, 0, (random_count - i) * 4));
            }
            else if (i > random_count / 2)
            {
                cards_in_hand[i].transform.Rotate(new Vector3(0, 0, -i * 4));
            }
        }
    }

}
