using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class scoreCounter : MonoBehaviour
{
    [SerializeField] contactColour[] m_contactColours;
    Dictionary<PlayerID, float> m_playerScores;

    private void Awake()
    {
        // Initialise the dictionary with empty values
        m_playerScores = new Dictionary<PlayerID, float>
        {
            { PlayerID.Red, 0.0f },
            { PlayerID.Blue, 0.0f },
            { PlayerID.Green, 0.0f },
            { PlayerID.Yellow, 0.0f }
        };


        if(m_contactColours == null || m_contactColours.Length == 0)
        {
            Debug.LogWarning("Contact colours not set in inspector.");
            m_contactColours = FindObjectsOfType<contactColour>(); // Bad
        }

        // Subscribe to all the callbacks
        foreach (contactColour contactColour in m_contactColours)
        {
            contactColour.OnScore = OnAddScore;
        }

        // We dont need reference to the other scripts anymore
        m_contactColours = null;
    }

    private void OnAddScore(PlayerID identifier, PlayerID previousOwner, float scoreToAdd)
    {
        m_playerScores[identifier] += scoreToAdd;
        if(previousOwner != PlayerID.None)
        {
            m_playerScores[previousOwner] -= scoreToAdd;
        }
    }

    private void OnGUI()
    {
        GUI.color = Color.red;
        GUILayout.Label($"{m_playerScores[PlayerID.Red]}");
        GUI.color = Color.blue;
        GUILayout.Label($"{m_playerScores[PlayerID.Blue]}");
        GUI.color = Color.green;
        GUILayout.Label($"{m_playerScores[PlayerID.Green]}");
        GUI.color = Color.yellow;
        GUILayout.Label($"{m_playerScores[PlayerID.Yellow]}");
    }
}

public enum PlayerID
{
    Red,
    Green,
    Blue,
    Yellow,
    None
}