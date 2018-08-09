using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
//using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class DropdownListController : MonoBehaviour {

    //Választható antennák listája
    List<string> AntenNaname = new List<string>() { "Please Select...", "Antennasample", "OtherAntenna" };

    //Kiválaztott antenna fájl elérési útja
    string FilePath = @"C:\Users\takio\OneDrive\Documents\szakdolgozat\AntennaAR\AntennaData\Antennasample\01.csv";

    //Dropdownbox és a TexMeshPro(AntennaName,ManufacturerName) meghívása az EventHandler-hez
    public Dropdown dropdown;
    public TMPro.TextMeshProUGUI SelectedName;
    public TMPro.TextMeshProUGUI ManufacturerName;

    //Kiválasztott antenna indexelése
    public void DropdownIndexChanged(int index)
    {
        SelectedName.text = AntenNaname[index];
    }

    //Antenna gyártójának a kiiratása
    void ManufacturerFile()
    {
        //Létezik-e a file?
        // HA igen
        if (File.Exists(FilePath))
        {
            //A kiválasztott antenna file sorainak listába helyezése
            List<string> Linelist = File.ReadAllLines(FilePath).ToList();
                foreach (string Lines in Linelist)
                {
                //A sorokat ,-vel tagolva külön szedjük
                string[] Entries = Lines.Split(',');

                //string Manufacturer = Entries[0];
                ManufacturerName.text = Entries[1];
                }
        }
        // Ha nem
        else
        {
            Debug.Log("File Does Not Exist!");
        }

    }
    
    //Feltölti a listából az antenna neveket
    void Start()
    {
        PopulateList();
        ManufacturerFile();
    }

    //Dropdownbox-hoz adja választható lista elemként
    void PopulateList()
    {
        dropdown.AddOptions(AntenNaname);
    }

}
