using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class writingsound : MonoBehaviour
{
    [SerializeField] AudioClip sound1;
    [SerializeField] collisioncheck _collisioncheck;
    [SerializeField] modechange _modechange;
    [SerializeField] dimentionchange _dimentionchange;
    AudioSource audioSource;
    private float _time = 0;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // 左
        if (_modechange.drawmode == 1 && _dimentionchange.drawdimention == 0 && OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0.7f)
        {
            //音(sound1)を鳴らす
            if (_time < 0.01f)
            {
                audioSource.PlayOneShot(sound1);
            }
            _time += Time.deltaTime;
            if (_time > 0.08f)
            {
                _time = 0;
            }
        }
        else if(_modechange.drawmode == 1 && _dimentionchange.drawdimention == 1 && _collisioncheck.collisionjudgement != 0)
        {
            if (_time < 0.01f)
            {
                audioSource.PlayOneShot(sound1);
            }
            _time += Time.deltaTime;
            if (_time > 0.08f)
            {
                _time = 0;
            }
        }
    }
}