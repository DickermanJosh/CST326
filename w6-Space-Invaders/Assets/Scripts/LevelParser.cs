using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LevelParser : MonoBehaviour
{
    public string filename;
    //public GameObject barrierPrefab;
    public GameObject SquidEnemy3Prefab;
    public GameObject BugEnemy2Prefab;
    public GameObject SkullEnemy1Prefab;
    // --------------------------------------------------------------------------
    
    void Start()
    {
        LoadLevel();
    }
    

    // --------------------------------------------------------------------------
    void Update()
    {
        if (this.transform.childCount == 0)
        {
            this.transform.position = new Vector3(0f, 2.7f, 0f);
            ReloadLevel();
        }
    }

    // --------------------------------------------------------------------------
    private void LoadLevel()
    {
        string fileToParse = $"{Application.dataPath}{"/TextFiles/"}{filename}.txt";
        Debug.Log($"Loading level file: {fileToParse}");

        Stack<string> levelRows = new Stack<string>();

        // Get each line of text representing blocks in our level
        using (StreamReader sr = new StreamReader(fileToParse))
        {
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                levelRows.Push(line);
            }

            sr.Close();
        }

        // Go through the rows from bottom to top
        int row = 0;
        while (levelRows.Count > 0)
        {
            string currentLine = levelRows.Pop();

            char[] letters = currentLine.ToCharArray();
            for (int column = 0; column < letters.Length; column++)
            {
                var letter = letters[column];
                if (letter == '3')
                {
                    Instantiate(SquidEnemy3Prefab, new Vector3(column-5f, row, -1f), Quaternion.identity).transform.SetParent(this.transform);
                }
                else if (letter == '2')
                {
                    Instantiate(BugEnemy2Prefab, new Vector3(column-5, row, -1f), Quaternion.identity).transform.SetParent(this.transform);
                }
                else if (letter == '1')
                {
                   Instantiate(SkullEnemy1Prefab, new Vector3(column-5, row, -1f), Quaternion.identity).transform.SetParent(this.transform);
                }
                // Todo - Instantiate a new GameObject that matches the type specified by letter
                // Todo - Position the new GameObject at the appropriate location by using row and column
                // Todo - Parent the new GameObject under levelRoot
                //column++;
            }

            row++;
        }
    }

    // --------------------------------------------------------------------------
    private void ReloadLevel()
    {
        foreach (Transform child in this.transform)
        {
           Destroy(child.gameObject);
        }
        LoadLevel();
    }
}
