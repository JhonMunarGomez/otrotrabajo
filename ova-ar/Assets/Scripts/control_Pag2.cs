using UnityEngine;
using System.Collections;
using Vuforia;

public class control_Pag2 : MonoBehaviour, ITrackableEventHandler {
	public GameObject Objeto;
	public GameObject marcador;
	private TrackableBehaviour control;
		// Use this for initialization
	void Start () {
		control = marcador.GetComponent<TrackableBehaviour> ();
		if(control){
			control.RegisterTrackableEventHandler (this);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTrackableStateChanged(TrackableBehaviour.Status estadoAnterior, TrackableBehaviour.Status estadoSiguiente){
		if (estadoSiguiente == TrackableBehaviour.Status.DETECTED ||
		   estadoSiguiente == TrackableBehaviour.Status.TRACKED ||
		   estadoSiguiente == TrackableBehaviour.Status.EXTENDED_TRACKED) {
			GameObject newObjeto = Instantiate (Objeto);
			newObjeto.transform.SetParent (marcador.transform);
			newObjeto.transform.localPosition = new Vector3 (0, 0, 0);
		} else {
			Destroy (GameObject.Find("Contenido_Pag_2(Clone)"));
		}
	}
}
