using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contactColour : MonoBehaviour
{
    [SerializeField] MeshRenderer m_meshRenderer; // Cache as GetComponent is expensive https://connect.unity.com/p/getcomponent-only-once
    private int m_shaderColourID;
    private PlayerID m_owningPlayer = PlayerID.None;

    public Action<PlayerID, PlayerID, float> OnScore;



    private void Awake()
    {
        if(m_meshRenderer == null)
        {
            Debug.LogWarning("Assign mesh renderer in inspector.");
            m_meshRenderer = gameObject.GetComponent<MeshRenderer>();
        }

        // Cache shader ID for "_Color", minor optimisation https://docs.unity3d.com/ScriptReference/Shader.PropertyToID.html
        m_shaderColourID = Shader.PropertyToID("_Color");
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player1" && m_owningPlayer != PlayerID.Red)
        {
            m_meshRenderer.material.SetColor(m_shaderColourID, Color.red);
            OnScore?.Invoke(PlayerID.Red, m_owningPlayer, 1.0f); // Call our delegate, this will call scoreCounter::OnAddScore since they subscribed in the awake call (contactColour.OnScore = OnAddScore)
            m_owningPlayer = PlayerID.Red;
            return; // Early out, to be safe and to save testing other cases
        }

        if (collision.gameObject.tag == "Player2" && m_owningPlayer != PlayerID.Blue)
        {
            m_meshRenderer.material.SetColor(m_shaderColourID, Color.blue);
            OnScore?.Invoke(PlayerID.Blue, m_owningPlayer, 1.0f); // Call our delegate, this will call scoreCounter::OnAddScore since they subscribed in the awake call (contactColour.OnScore = OnAddScore)
            m_owningPlayer = PlayerID.Blue;
            return; // Early out, to be safe and to save testing other cases
        }

        if (collision.gameObject.tag == "Player3" && m_owningPlayer != PlayerID.Green)
        {
            m_meshRenderer.material.SetColor(m_shaderColourID, Color.green);
            OnScore?.Invoke(PlayerID.Green, m_owningPlayer, 1.0f); // Call our delegate, this will call scoreCounter::OnAddScore since they subscribed in the awake call (contactColour.OnScore = OnAddScore)
            m_owningPlayer = PlayerID.Green;
            return; // Early out, to be safe and to save testing other cases
        }

        if (collision.gameObject.tag == "Player4" && m_owningPlayer != PlayerID.Yellow)
        {
            m_meshRenderer.material.SetColor(m_shaderColourID, Color.yellow);
            OnScore?.Invoke(PlayerID.Yellow, m_owningPlayer, 1.0f); // Call our delegate, this will call scoreCounter::OnAddScore since they subscribed in the awake call (contactColour.OnScore = OnAddScore)
            m_owningPlayer = PlayerID.Yellow;
            return; // Early out, to be safe and to save testing other cases
        }
    }
}
