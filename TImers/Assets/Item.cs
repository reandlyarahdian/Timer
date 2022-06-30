using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Item : MonoBehaviour
{
    [SerializeField] Timer timer;
    [SerializeField] TextMeshProUGUI Item5text;
    [SerializeField] TextMeshProUGUI Item10text;
    [SerializeField] Button Item5Button, Item10Button;
    public int items5 = 5;
    public int items10 = 1;

    private void Start()
    {
        Item5text.text = items5.ToString();
        Item10text.text = items10.ToString();
    }

    public void Item5Use()
    {
        timer.OnChange((items) => Used(items - 5));
        items5--;
        Item5text.text = items5.ToString();
        if(items5 == 0)
        {
            Item5Button.interactable = false;
        }
    }

    public void Item10Use()
    {
        timer.OnChange((items) => Used(items - 10));
        items10--;
        Item10text.text = items10.ToString();
        if (items10 == 0)
        {
            Item10Button.interactable = false;
        }
    }

    public void Used(int s)
    {
        timer.SetRemainDuration(s);
    }
}
