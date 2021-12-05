using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreUp : MonoBehaviour
{
    public Item item;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("items"))
        {
            FieldItems fieldItems = collision.GetComponent<FieldItems>();
            fieldItems.DestroyItem();
            
            if (fieldItems.item.itemName == "Donguri")
            {
                Score.score += 1;
            }
            else
            {
                Score.score += 3;
            }
        }
    }
}
