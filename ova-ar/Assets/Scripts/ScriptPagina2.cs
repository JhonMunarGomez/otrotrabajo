using UnityEngine;
using System.Collections;

public class ScriptPagina2 : MonoBehaviour {
	bool [] estado = {false, false, false, false, false, false};
	private Ray pulso;
	private RaycastHit colision;
	public GameObject bien;
	public GameObject mal;
	public GameObject interfaz;
	private GameObject newInterfaz;
	private GameObject [] calificacion = {null, null, null, null, null, null};
	private static bool estadoJuego;
	public static int puntaje;
	public AudioClip good;
	public AudioClip fail;
	public AudioClip boton;
	private static AudioSource sonido;
	// Use this for initialization
	void Start () {
		sonido = GetComponent<AudioSource> ();
		estadoJuego = true;
		puntaje = 0;
	}
	
	// Update is called once per frame
	public void Update () {
		if (estadoJuego) {
			if (Input.GetMouseButtonDown (0)) {
				pulso = Camera.main.ScreenPointToRay (Input.mousePosition);
				if (Physics.Raycast (pulso, out colision)) {
					if (colision.collider.name == "1") {
						if (!estado [0]) {
							sonido.clip = good;
							sonido.Play ();
							calificacion [0] = Instantiate (bien);
							calificacion [0].transform.SetParent (GameObject.Find ("1").transform);
							calificacion [0].transform.position = new Vector3 (GameObject.Find ("1").transform.position.x, 10f, GameObject.Find ("1").transform.position.z);
							estado [0] = true;
						}
					}
					if (colision.collider.name == "2") {
						if (!estado [1]) {
							sonido.clip = good;
							sonido.Play ();
							calificacion [1] = Instantiate (bien);
							calificacion [1].transform.SetParent (GameObject.Find ("2").transform);
							calificacion [1].transform.position = new Vector3 (GameObject.Find ("2").transform.position.x, 10f, GameObject.Find ("2").transform.position.z);
							estado [1] = true;
							Debug.Log (estado [1]);
						}
					}
					if (colision.collider.name == "3") {
						if (!estado [2]) {
							sonido.clip = fail;
							sonido.Play ();
							calificacion [2] = Instantiate (mal);
							calificacion [2].transform.SetParent (GameObject.Find ("3").transform);
							calificacion [2].transform.position = new Vector3 (GameObject.Find ("3").transform.position.x, 10f, GameObject.Find ("3").transform.position.z);
							estado [2] = true;
							StartCoroutine (carga_Interfaz ());
						}
					}
					if (colision.collider.name == "4") {
						if (!estado [3]) {
							sonido.clip = fail;
							sonido.Play ();
							calificacion [3] = Instantiate (mal);
							calificacion [3].transform.SetParent (GameObject.Find ("4").transform);
							calificacion [3].transform.position = new Vector3 (GameObject.Find ("4").transform.position.x, 10f, GameObject.Find ("4").transform.position.z);
							estado [3] = true;
							StartCoroutine (carga_Interfaz ());
						}
					}
					if (colision.collider.name == "5") {
						if (!estado [4]) {
							sonido.clip = good;
							sonido.Play ();
							calificacion [4] = Instantiate (bien);
							calificacion [4].transform.SetParent (GameObject.Find ("5").transform);
							calificacion [4].transform.position = new Vector3 (GameObject.Find ("5").transform.position.x, 10f, GameObject.Find ("5").transform.position.z);
							estado [4] = true;
						}
					}
					if (colision.collider.name == "6") {
						if (!estado [5]) {
							sonido.clip = good;
							sonido.Play ();
							calificacion [5] = Instantiate (bien);
							calificacion [5].transform.SetParent (GameObject.Find ("6").transform);
							calificacion [5].transform.position = new Vector3 (GameObject.Find ("6").transform.position.x, 10f, GameObject.Find ("6").transform.position.z);
							estado [5] = true;
						}
					}
				}
			}
		}
	}

	public IEnumerator carga_Interfaz(){
		yield return new WaitForSeconds (1f);
		newInterfaz = Instantiate (interfaz);
		estadoJuego = false;
		borrar ();
		puntaje = 0;
	}

	public void presionar_Boton(){	
		sonido.clip = boton;
		sonido.Play ();
		Destroy (GameObject.Find ("Pagina_2UI(Clone)"));
		estadoJuego = true;
	}

	public void borrar () {
		if(estado[0]){
			Destroy (calificacion[0]);
			estado [0] = false;
		}
		if(estado[1]){
			Destroy (calificacion[1]);
			estado [1] = false;
		}
		if(estado[2]){
			Destroy (calificacion[2]);
			estado [2] = false;
		}
		if(estado[3]){
			Destroy (calificacion[3]);
			estado [3] = false;
		}
		if(estado[4]){
			Destroy (calificacion[4]);
			estado [4] = false;
		}
		if(estado[5]){
			Destroy (calificacion[5]);
			estado [5] = false;
		}
	}
}
