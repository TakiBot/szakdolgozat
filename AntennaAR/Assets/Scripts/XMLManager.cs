using System.Collections;
using System.Collections.Generic; //Lets us use Lists
using System.Xml;                 //Basic XML attributes
using System.Xml.Serialization;   //Access XML serializer
using System.IO;                  //File management
using System;
using UnityEngine;


public class XMLManager : MonoBehaviour {

    public static XMLManager instance;

    private void Awake()
    {
        instance = this;
    }

    //List of antennas
    public AntennaDatabase antennaDB;
}

//XML record names
[System.Serializable]
public class ItemEntry {

    public string aName;        //Antenna name
    public string manName;      //Manufacturere name
    public int freqStart;       //Start frequency
    public int freqStop;        //Stop frequency
    public AntennaType aType;   //Antenna type
}

//List creation
[System.Serializable]
public class AntennaDatabase {

    public List<ItemEntry> list = new List<ItemEntry>();
}

//Antenna type list
public enum AntennaType {

    Yagi,
    Horn
}
