using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SettingsHandler : MonoBehaviour {

	private Animation animation;


	public Sprite[] vibration_sprites;
	public Sprite[] sfx_sprites; 
	private Image vibration_image;
	private Image sfx_image; 

	public bool Active;

	void OnEnable()
	{
		EventManager.OnButtonClick += OnButtonClick;
		EventManager.OnStateChange+=OnStateChange; 
	}
	void OnDisable()
	{
		EventManager.OnButtonClick -= OnButtonClick;
		EventManager.OnStateChange-=OnStateChange; 
	}

	void Start()
	{
		vibration_image = transform.GetChild(0).GetComponent<Image>();
		vibration_image.sprite = Controller.HAPTIC ? vibration_sprites[0] : vibration_sprites[1];

		sfx_image = transform.GetChild(1).GetComponent<Image>(); 
		sfx_image.sprite = Controller.SFX ? sfx_sprites[0] : sfx_sprites[1]; 
	}

	void OnStateChange(State s)
	{
		if(s != State.MENU)
		{
			Play(-1); 
			return; 
		}
	}




	void OnButtonClick(ButtonID b)
	{
		if (b == ButtonID.ToggleVibration)
		{
			Controller.HAPTIC = !Controller.HAPTIC;
			vibration_image.sprite = Controller.HAPTIC ? vibration_sprites[0] : vibration_sprites[1];
		}
		else if(b == ButtonID.ToggleSFX)
		{
			Controller.SFX = !Controller.SFX; 
			sfx_image.sprite = Controller.SFX ? sfx_sprites[0] : sfx_sprites[1]; 
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
