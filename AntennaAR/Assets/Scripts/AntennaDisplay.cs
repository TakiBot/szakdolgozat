using System.Collections;
using System.Collections.Generic; //Lets us use Lists
using System.Xml;                 //Basic XML attributes
using System.Xml.Serialization;   //Access XML serializer
using System.IO;                  //File management
using System;
using UnityEngine;

public class AntennaDisplay : MonoBehaviour {

    public TMPro.TextMeshProUGUI antennaInfo;
    public TMPro.TextMeshProUGUI manufacturerInfo;
    public TMPro.TextMeshProUGUI startFreq;
    public TMPro.TextMeshProUGUI stopFreq;
    public TMPro.TextMeshProUGUI typeInfo;

    public string mhz = " MHz";

    void Start () {
        Display();
	}
	
	public void Display() {

        foreach (ItemEntry item in XMLManager.instance.antennaDB.list)
        {
            antennaInfo.text = item.aName;
            manufacturerInfo.text = item.manName;
            startFreq.text = item.freqStart.ToString() + mhz;
            stopFreq.text = item.freqStop.ToString() + mhz;
            typeInfo.text = item.aType.ToString();

        }
    }
}
