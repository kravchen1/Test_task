using UnityEngine;
using UnityEngine.UI;

public class Resources : MonoBehaviour
{
    private int Attack_value = 1,HP_value = 1,MP_value = 1;
    public GameObject Attack_text, HP_text, MP_text;

    private void Start()
    {
        Set_Attack_value(UnityEngine.Random.Range(1,10));
        Set_HP_value(UnityEngine.Random.Range(1, 10));
        Set_MP_value(UnityEngine.Random.Range(1, 10));

    }
    public int Get_Attack_value()
    {
        return Attack_value;
    }
    public void Set_Attack_value(int value)
    {
        Attack_value = value;
        Attack_text.GetComponent<Text>().text = Attack_value.ToString();
    }
    public int Get_HP_value()
    {
        return HP_value;
    }
    public void Set_HP_value(int value)
    {
        HP_value = value;
        HP_text.GetComponent<Text>().text = Attack_value.ToString();
    }
    public int Get_MP_value()
    {
        return MP_value;
    }
    public void Set_MP_value(int value)
    {
        MP_value = value;
        MP_text.GetComponent<Text>().text = Attack_value.ToString();
    }

}
