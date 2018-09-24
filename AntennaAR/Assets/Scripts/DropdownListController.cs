using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
//using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.UI;



public class DropdownListController : MonoBehaviour {

    //Antenna List
    List<string> AntName = new List<string>() { "Antennasample", "OtherAntenna" };

    public string FilePath;
    public string Result;

    //Dropdownbox And TexMeshPro(AntennaName,ManufacturerName) Call For EventHandler
    public Dropdown dropdown;
    public TMPro.TextMeshProUGUI SelectedName;
    public TMPro.TextMeshProUGUI ManufacturerName;
    public TMPro.TextMeshProUGUI FileDataPath;

    
      
          

    //Selected Antenna Indexing In The Dropdownbox
    void DropdownIndexChanged(int index)
    {
         SelectedName.text = AntName[index];
        //Selected Antenna File Path
        FilePath = (Application.streamingAssetsPath + @"/" + SelectedName.text + @".csv");
        Result = "";

        if (FilePath.Contains("://"))
        {
            UnityWebRequest www = UnityWebRequest.Get(FilePath);
            www.SendWebRequest();
            Result = www.downloadHandler.text;
        }
        else
        {
            //Is There a File?
            // IF Yes
            if (File.Exists(FilePath))
            {
                //Selected Antenna File Lines To List
                List<string> Linelist = File.ReadAllLines(FilePath).ToList();
                foreach (string Lines in Linelist)
                {
                    //The Lines Are Separeted by ','
                    string[] Entries = Lines.Split(',');

                    //string Manufacturer = Entries[0];
                    ManufacturerName.text = Entries[1];
                }
            }
            // IF Not
            else
            {
                Debug.Log("File Does Not Exist!");
            }
        }
        Debug.Log(FilePath);
        Debug.Log(Result);
    }
 
    //Antenna List Upload
    void Start()
    {
        DropdownIndexChanged(0);
        PopulateList();
        DataPath();
    }

    //Antenna List To The List Element
    void PopulateList()
    {
        dropdown.AddOptions(AntName);
    }

    void DataPath()
    {
      
        FileDataPath.text = Result;
    }


}
