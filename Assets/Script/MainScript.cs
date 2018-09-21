using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour {

    public Text JudgeText;
    public AudioSource audioSource;
    public GameObject note;

    Dictionary<int, int> readyNotes;
    Dictionary<int, int> runningNotes;

    // Use this for initialization
    void Start () {
        JudgeText.text = "";
        readyNotes = new Dictionary<int, int>();
        var file = new System.IO.StreamReader("Assets/Music/amaterasu/humen.csv");
        ReadCsv(file);
        foreach (var note in readyNotes.Values) print(note);
	}
	
	// Update is called once per frame
	void Update () {
        var rm = new List<int>();
        //print(audioSource.time);
		foreach(var key in readyNotes.Keys)
        {
            if (key <= audioSource.time)
            {
                CreateNote(readyNotes[key]);
                rm.Add(key);
            }
        }
        foreach (var i in rm) readyNotes.Remove(i);
	}

    void ReadCsv(System.IO.StreamReader sr)
    {
        var split = sr.ReadLine().Split(',');
        readyNotes.Add(int.Parse(split[0]), int.Parse(split[1]));
        if (!sr.EndOfStream) ReadCsv(sr);
    }

    void CreateNote(int position)
    {
        switch (position)
        {
            case 0:
                Instantiate(note, new Vector3(135,677,0), Quaternion.identity);

                break;
            case 1:
                Instantiate(note, new Vector3(332, 677, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(note, new Vector3(529, 677, 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(note, new Vector3(728, 677, 0), Quaternion.identity);
                break;
            case 4:
                Instantiate(note, new Vector3(933, 677, 0), Quaternion.identity);
                break;
            case 5:
                Instantiate(note, new Vector3(1125, 677, 0), Quaternion.identity);
                break;
        }
    }

    void KeyDown(KeyCode key)
    {
        if(key == KeyCode.Z)
        {
            
        }
        if (key == KeyCode.X)
        {

        }
        if (key == KeyCode.C)
        {

        }
        if (key == KeyCode.V)
        {

        }
        if (key == KeyCode.B)
        {

        }
        if (key == KeyCode.N)
        {

        }

    }
}
