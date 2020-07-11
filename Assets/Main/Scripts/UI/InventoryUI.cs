using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject itemButton;
    public GameObject inventoryContent;
    public PlayerManager pm;
    
    void SetUp()
    {
        pm = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();
        int count = 0;
        foreach (InventorySlot square in inventoryContent.GetComponentsInChildren<InventorySlot>())
        {
            square.InitalizeSelf(count, pm);
            count++;
        }
    }

    public void UpdateAllSquares()
    {
        SetUp();
        GameObject.FindWithTag("Info").GetComponent<TextMeshProUGUI>().text = "";
        foreach (InventorySlot square in inventoryContent.GetComponentsInChildren<InventorySlot>())
        {
            square.UpdateSelf(pm);
        }
    }
}
