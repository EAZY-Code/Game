using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightController : MonoBehaviour {
	
	public GameObject[] lightsOneRed;
	public GameObject[] lightsOneGreen;
	public GameObject[] lightsTwoRed;
	public GameObject[] lightsTwoGreen;
	public GameObject[] lightsOneYellow;
	public GameObject[] lightsTwoYellow;
	public GameObject[] lightsPOneRed;
	public GameObject[] lightsPOneGreen;
	public GameObject[] lightsPTwoRed;
	public GameObject[] lightsPTwoGreen;

	IEnumerator Start() {
		while (true) {
			foreach (GameObject redLight in lightsOneRed) {
				redLight.SetActive (true);
			}
			foreach (GameObject redLight in lightsTwoRed) {
				redLight.SetActive (false);
			}
			foreach (GameObject greenLight in lightsTwoGreen) {
				greenLight.SetActive (true);
			}
			foreach (GameObject greenLight in lightsOneGreen) {
				greenLight.SetActive (false);
			}

			foreach (GameObject redLight in lightsPOneRed) {
				redLight.SetActive (false);
			}
			foreach (GameObject redLight in lightsPTwoRed) {
				redLight.SetActive (true);
			}
			foreach (GameObject greenLight in lightsPTwoGreen) {
				greenLight.SetActive (false);
			}
			foreach (GameObject greenLight in lightsPOneGreen) {
				greenLight.SetActive (true);
			}

			yield return new WaitForSeconds (5f);

			foreach (GameObject redLight in lightsPOneRed) {
				redLight.SetActive (true);
			}
			foreach (GameObject redLight in lightsPTwoRed) {
				redLight.SetActive (false);
			}
			foreach (GameObject greenLight in lightsPTwoGreen) {
				greenLight.SetActive (true);
			}
			foreach (GameObject greenLight in lightsPOneGreen) {
				greenLight.SetActive (false);
			}

			foreach (GameObject yellowLight in lightsTwoYellow) {
				yellowLight.SetActive (true);
			}

			foreach (GameObject greenLight in lightsTwoGreen) {
				greenLight.SetActive (false);
			}

			yield return new WaitForSeconds (1f);

			foreach (GameObject yellowLight in lightsTwoYellow) {
				yellowLight.SetActive (false);
			}

			foreach (GameObject yellowLight in lightsOneYellow) {
				yellowLight.SetActive (true);
			}
			yield return new WaitForSeconds (1f);

			foreach (GameObject yellowLight in lightsOneYellow) {
				yellowLight.SetActive (false);
			}
			foreach (GameObject redLight in lightsOneRed) {
				redLight.SetActive (false);
			}

			foreach (GameObject redLight in lightsTwoRed) {
				redLight.SetActive (true);
			}
			foreach (GameObject greenLight in lightsOneGreen) {
				greenLight.SetActive (true);
			}
			yield return new WaitForSeconds (5f);

			foreach (GameObject yellowLight in lightsOneYellow) {
				yellowLight.SetActive (true);
			}

			foreach (GameObject greenLight in lightsOneGreen) {
				greenLight.SetActive (false);
			}
				
			yield return new WaitForSeconds (1f);

			foreach (GameObject yellowLight in lightsOneYellow) {
				yellowLight.SetActive (false);
			}
		}
	}
}
