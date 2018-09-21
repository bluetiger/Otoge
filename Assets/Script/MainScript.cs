using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour {

    class TimeAndNote
    {
        public GameObject gameObject;
        public float time;
        public TimeAndNote(GameObject gameObject,float time)
        {
            this.gameObject = gameObject;
            this.time = time;
        }
    }

    public Text JudgeText;
    public AudioSource audioSource;
    public GameObject note;

    Dictionary<float, int> readyNotes;
    List<TimeAndNote> runningNotes_0;
    List<TimeAndNote> runningNotes_1;
    List<TimeAndNote> runningNotes_2;
    List<TimeAndNote> runningNotes_3;
    List<TimeAndNote> runningNotes_4;
    List<TimeAndNote> runningNotes_5;

    // Use this for initialization
    void Start () {
        JudgeText.text = "";
        readyNotes = new Dictionary<float, int>();
        runningNotes_0 = new List<TimeAndNote>();
        runningNotes_1 = new List<TimeAndNote>();
        runningNotes_2 = new List<TimeAndNote>();
        runningNotes_3 = new List<TimeAndNote>();
        runningNotes_4 = new List<TimeAndNote>();
        runningNotes_5 = new List<TimeAndNote>();
        var file = new System.IO.StreamReader("Assets/Music/amaterasu/humen.csv");
        ReadCsv(file);
        foreach (var note in readyNotes.Values) print(note);
	}
	
	// Update is called once per frame
	void Update () {
        var rm = new List<float>();
        //print(audioSource.time);
		foreach(var key in readyNotes.Keys)
        {
            if (key - 2 <= audioSource.time)
            {
                var note = CreateNote(readyNotes[key]);
                if (readyNotes[key] == 0) { runningNotes_0.Add(new TimeAndNote(note,key)); }
                if (readyNotes[key] == 1) { runningNotes_1.Add(new TimeAndNote(note, key)); }
                if (readyNotes[key] == 2) { runningNotes_2.Add(new TimeAndNote(note, key)); }
                if (readyNotes[key] == 3) { runningNotes_3.Add(new TimeAndNote(note, key)); }
                if (readyNotes[key] == 4) { runningNotes_4.Add(new TimeAndNote(note, key)); }
                if (readyNotes[key] == 5) { runningNotes_5.Add(new TimeAndNote(note, key)); }
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

    GameObject CreateNote(int position)
    {
        switch (position)
        {
            case 0:
                return Instantiate(note, new Vector3(135,677,0), Quaternion.identity);
            case 1:
                return Instantiate(note, new Vector3(332, 677, 0), Quaternion.identity);
            case 2:
                return Instantiate(note, new Vector3(529, 677, 0), Quaternion.identity);
            case 3:
                return Instantiate(note, new Vector3(728, 677, 0), Quaternion.identity);
            case 4:
                return Instantiate(note, new Vector3(933, 677, 0), Quaternion.identity);
            case 5:
                return Instantiate(note, new Vector3(1125, 677, 0), Quaternion.identity);
            default:
                return null;
        }
    }

    public void KeyDown(KeyCode key)
    {
        if(key == KeyCode.Z&&runningNotes_0.Count!=0)
        {
            if (audioSource.time < runningNotes_0[0].time+0.5&& audioSource.time > runningNotes_0[0].time - 0.5)
            {
                runningNotes_0[0].gameObject.SetActive(false);
            }
        }
        if (key == KeyCode.X && runningNotes_1.Count != 0)
        {
            if (audioSource.time < runningNotes_1[0].time + 0.5 && audioSource.time > runningNotes_1[0].time - 0.5)
            {
                runningNotes_1[0].gameObject.SetActive(false);
            }
        }
        if (key == KeyCode.C && runningNotes_2.Count != 0)
        {
            if (audioSource.time < runningNotes_2[0].time + 0.5 && audioSource.time > runningNotes_2[0].time - 0.5)
            {
                runningNotes_2[0].gameObject.SetActive(false);
            }
        }
        if (key == KeyCode.V && runningNotes_3.Count != 0)
        {
            if (audioSource.time < runningNotes_3[0].time + 0.5 && audioSource.time > runningNotes_3[0].time - 0.5)
            {
                runningNotes_3[0].gameObject.SetActive(false);
            }
        }
        if (key == KeyCode.B && runningNotes_4.Count != 0)
        {
            if (audioSource.time < runningNotes_4[0].time + 0.5 && audioSource.time > runningNotes_4[0].time - 0.5)
            {
                runningNotes_4[0].gameObject.SetActive(false);
            }
        }
        if (key == KeyCode.N && runningNotes_5.Count != 0)
        {
            if (audioSource.time < runningNotes_5[0].time + 0.5 && audioSource.time > runningNotes_5[0].time - 0.5)
            {
                runningNotes_5[0].gameObject.SetActive(false);
            }
        }

    }
}
