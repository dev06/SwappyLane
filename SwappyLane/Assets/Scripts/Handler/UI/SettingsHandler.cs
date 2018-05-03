using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SettingsHandler : MonoBehaviour {

	private Animation animation;


	public Sprite vibration_on;
	public Sprite vibration_off;
	private Image vibration_image;

	public bool Active;

	void OnEnable()
	{
		EventManager.OnButtonClick += OnButtonClick;
	}
	void OnDisable()
	{
		EventManager.OnButtonClick -= OnButtonClick;
	}

	void Start()
	{
		vibration_image = transform.GetChild(0).GetComponent<Image>();
		vibration_image.sprite = Controller.HAPTIC ? vibration_on : vibration_off;

	}

	void OnButtonClick(ButtonID b)
	{

		if (b == ButtonID.ToggleVibration)
		{
			Controller.HAPTIC = !Controller.HAPTIC;
			vibration_image.sprite = Controller.HAPTIC ? vibration_on : vibration_off;
		}

		if (b != ButtonID.Setting) { return; }

		Play(Active ? -1 : 1);
	}

	public void Play(int i)
	{
		if (animation == null)
		{
			animation = GetComponent<Animation>();
		}

		animation[animation.clip.name].speed = i;
		animation [animation.clip.name].time = i > 0 ? 0 : animation[animation.clip.name].length;
		animation.Play();

		Active = i > 0;



	}

}
