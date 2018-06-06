using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour {


	public void DisableBoolAnimator (Animator Resume) {

		Resume.SetBool ("Is Disabled", true);

	}

	public void EnableBoolAnimator (Animator Resume) {

		Resume.SetBool ("Is Disabled", false);

	}

	public void NavigateTo (int scene){

		Application.LoadLevel (scene);

	}

	public void ExitGame (){

		Application.Quit ();

	}


}
