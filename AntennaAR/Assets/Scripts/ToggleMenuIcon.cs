using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleMenuIcon : MonoBehaviour {

    public GameObject toggleOn, toggleOff;

	public void OnChangeValue() {

        bool toggleSwitch = gameObject.GetComponent<Toggle>().isOn;

        if (toggleSwitch)
        {
            toggleOn.SetActive(true);
            toggleOff.SetActive(false);
        }
        else
        {
            toggleOn.SetActive(false);
            toggleOff.SetActive(true);
        }
        
    }
}
