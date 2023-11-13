using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HPBar : MonoBehaviour
{
	private Slider _slider;

	private void Start()
	{
		_slider = GetComponentInChildren<Slider>();
		GetComponentInParent<IHealth>().OnHPPctChanged += HandleHPPctChanged;
	}

	private void HandleHPPctChanged(float pct)
	{
		_slider.value = pct;
	}

    private void Update()
    {
		_slider.transform.LookAt(Camera.main.transform);
	}
}