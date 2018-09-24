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
using UnityEditor;
using UnityEngine.Networking;

public class FolderStructureCopy : MonoBehaviour
{
    /*//File Path Var
    public string FilePath = (Application.streamingAssetsPath);
    public string Result = "";

    [RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public IEnumerator CsvPath()
    {
        if (FilePath.Contains("://"))
        {
            UnityWebRequest www = UnityWebRequest.Get(FilePath);
            yield return www.SendWebRequest();
            Result = www.downloadHandler.text;
        }
        else
        {
            Result = System.IO.File.ReadAllText(FilePath);
        }
    }
}
    */
}
