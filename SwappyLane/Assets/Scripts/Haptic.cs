using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TapticPlugin;
public class Haptic : MonoBehaviour {


	public static void Vibrate(HapticIntensity intensity)
	{
		if (Controller.HAPTIC == false) { return; }
#if !UNITY_EDITOR
#if UNITY_IPHONE
		switch (intensity)
		{
			case HapticIntensity.Light:
			{
				TapticManager.Impact(ImpactFeedback.Light);
				break;
			}
			case HapticIntensity.Medium:
			{
				TapticManager.Impact(ImpactFeedback.Midium);
				break;
			}
			case HapticIntensity.Heavy:
			{
				TapticManager.Impact(ImpactFeedback.Heavy);
				break;
			}
		}
#else

		switch (intensity)
		{
			case HapticIntensity.Light:
			{
				Vibration.Vibrate(5);
				break;
			}
			case HapticIntensity.Medium:
			{
				Vibration.Vibrate(7);
				break;
			}
			case HapticIntensity.Heavy:
			{
				Vibration.Vibrate(9);
				break;
			}
		}
#endif

#endif
	}


}
public enum HapticIntensity
{
	Light,
	Medium,
	Heavy,
}
