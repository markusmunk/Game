using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class size : MonoBehaviour
{
    public RectTransform rt;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        rt.sizeDelta = new Vector2(10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
