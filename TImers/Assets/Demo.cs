using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using TMPro;

public class Demo : MonoBehaviour
{
    [SerializeField] Timer timer;
    [SerializeField] TextMeshProUGUI lv;

    public bool A1, A2, B1, B2;

    private void Start()
    {
        timer.SetDuration(5).OnEnd(() => Level2A());
        timer.Begin();
        lv.text = "Level 1 A";
        A1 = true;
        A2 = B1 = B2 = !A1;
    }

    public void Level2A()
    {
        timer.ResetTimer();
        timer.SetDuration(10).OnEnd(() => Level1B());
        timer.Begin();
        lv.text = "Level 2 A";
        A2 = true;
        A1 = B1 = B2 = !A2;
    }

    public void Level1B()
    {
        timer.ResetTimer();
        timer.SetDuration(15).OnEnd(() => Level2B());
        timer.Begin();
        lv.text = "Level 1 B";
        B1 = true;
        A2 = A1 = B2 = !B1;
    }

    public void Level2B()
    {
        timer.ResetTimer();
        timer.SetDuration(20).OnEnd(() => timer.ResetTimer());
        timer.Begin();
        lv.text = "Level 2 B";
        B2 = true;
        A2 = B1 = A1 = !B2;
    }

}
