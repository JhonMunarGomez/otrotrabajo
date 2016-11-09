/*===============================================================================
Copyright (c) 2015-2016 PTC Inc. All Rights Reserved.
 
Copyright (c) 2015 Qualcomm Connected Experiences, Inc. All Rights Reserved.
 
Vuforia is a trademark of PTC Inc., registered in the United States and other 
countries.
===============================================================================*/
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AboutScreen : MonoBehaviour
{
	AudioSource presionaBoton;
	int id_Escena;
    #region MONOBEHAVIOUR_METHODS
	public void Start()
	{
		presionaBoton = GetComponent<AudioSource> ();
	}

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_ANDROID
            // On Android, the Back button is mapped to the Esc key
            Application.Quit();
#endif
        }
    }
    #endregion // MONOBEHAVIOUR_METHODS


	#region PUBLIC_METHODS
	public void BotonPlay(){
		presionaBoton.Play ();
		id_Escena = 1;
		StartCoroutine (cargarScena(id_Escena));
	}

	public void BotonTema(){
		presionaBoton.Play ();
	}

	public void BotonConfig(){
		presionaBoton.Play ();
	}

	IEnumerator cargarScena(int escena){
		yield return new WaitForSeconds (2f);
		switch(id_Escena){
		case 1:
			SceneManager.LoadScene ("Loading");
			break;
		}
	}
	#endregion // PUBLIC_METHODS
}