using UnityEngine;
using UnityEngine.UI;

public class ItemDataView : MonoBehaviour {

    Text quantityText;

    // Update is called once per frame
    public void UpdateQuantity(int temp) {
        Text quantityText = gameObject.transform.GetChild(0).GetComponent<Text>() as Text;
        quantityText.text = "" + temp;
    }
}
