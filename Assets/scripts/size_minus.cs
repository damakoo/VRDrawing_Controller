using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class size_minus : MonoBehaviour
{
    [SerializeField] sizechange _sizechange;
    [SerializeField] Text _text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (!_sizechange.pressed_minus)
        {
            _sizechange.pressed_minus = true;
            if (_sizechange.fontsize > 0.001f)
            {
                _sizechange.fontsize -= 0.001f;
            }
            _text.text = (Mathf.Round(_sizechange.fontsize * 1000) / 10).ToString("f1");
            Invoke("resetpress_minus", 0.5f);

        }
    }

    void resetpress_minus()
    {
        _sizechange.pressed_minus = false;
    }
}
