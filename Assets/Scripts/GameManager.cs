using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState GameState;

    public static event Action<GameState> OnGameStateChanged;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(gameObject);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateGameState(GameState state)
    {
        GameState = state;

        switch (state)
        {
            case 0:
                break;
        }

        OnGameStateChanged?.Invoke(state);
    }
}

public enum GameState
{
    Start,
    Flying,
    Exploring,
    Victory,
    Defeat
}
