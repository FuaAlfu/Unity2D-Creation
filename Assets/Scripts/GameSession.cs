using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 2021.2.1
/// created by www.github.com/FuaAlfu
/// </summary>
public class GameSession : MonoBehaviour
{
    [SerializeField]
    GameObject p, p1;

    [SerializeField] 
    private Text countTxt;

    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        p.SetActive(false);
        p1.SetActive(false);

        //for ui
        countTxt.text = count.ToString();
    }

    public void BounceCounter(int countIncrease)
    {
        count += countIncrease;
        countTxt.text = count.ToString();
        if (count == 5)
        {
            p.SetActive(true);
        }
        else if (count == 10)
            p1.SetActive(true);
    }
}
