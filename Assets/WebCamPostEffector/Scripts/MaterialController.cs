using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialController : MonoBehaviour
{
    [SerializeField]
    Material _material;

    [SerializeField]
    Slider _thickness;

    [SerializeField]
    Slider _sharpness;

    [SerializeField]
    Slider _threshold;

    [SerializeField]
    Toggle _whiteBackground;

    WebCamTexture webCamTexture;

    void Start()
    {
        webCamTexture = new WebCamTexture();
        webCamTexture.Play();

        _material.SetTexture("Texture2D_b7737f5a72b64f6a9adc6160ceca0b19", webCamTexture); 
    }


    // Update is called once per frame
    void Update()
    {
        _material.SetFloat("Vector1_b9ce73d955284578bf65e218954dcd2b", _thickness.value);
        _material.SetFloat("Vector1_36b9bc4acee3498484091dc029dd9396", _sharpness.value);
        _material.SetFloat("Vector1_2305ed167e36414abe797df1d73558f9", _threshold.value);
        if(_whiteBackground.isOn)
        {
            _material.SetFloat("Vector1_d37f790ae121412db8a1d38c5a675fb3", 1.0f);
        } else
        {
            _material.SetFloat("Vector1_d37f790ae121412db8a1d38c5a675fb3", 0.0f);
        }

    }
}
