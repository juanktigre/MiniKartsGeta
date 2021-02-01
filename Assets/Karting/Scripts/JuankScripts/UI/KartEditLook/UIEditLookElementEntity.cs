using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEditLookElementEntity : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int elementID;
    [SerializeField] Button  btnElemnt;

   public  System.Action<int> onLookElementPressed;
    
    public void Init(int elementID)
    {
        this.elementID = elementID;
        btnElemnt.onClick.AddListener( OnLookElementPressed);
    }

    // Update is called once per frame
    private void OnLookElementPressed()
    {
        onLookElementPressed?.Invoke(elementID);
    }
}
