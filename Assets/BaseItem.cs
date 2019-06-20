using UnityEngine;

public class BaseItem : MonoBehaviour
{
    public string item_name = "Insert Name";
    public string item_description = "Insert Description";
    public float item_weight = 0;
    public float item_value = 0;
    public bool item_critical = false;//critical items should not 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void AddToInventory(GameObject character)
    {
        if (character.GetComponent<Inventory>())
        {
            Inventory character_inventory = character.GetComponent<Inventory>();

            if ((character_inventory.inventory_capacity_cur + item_weight) <= character_inventory.inventory_capacity_max)
            {

            }
            else
            {
                Debug.Log(character.name + " does not have enough space in inventory.");
            }
        }
        else
        {
            Debug.Log(character.name + " does not have an inventory.");
        }
    }
}
