using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState gameState;

    public PlanetCard[] PlanetCards;

    public static event Action<GameState> OnGameStateChanged;

    private Planet planet;

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
        UpdateGameState(GameState.Menu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateGameState(GameState state)
    {
        gameState = state;

        switch (state)
        {
            case GameState.Exploring:
                planet = FindFirstObjectByType<Planet>();
                break;
        }

        OnGameStateChanged?.Invoke(state);
    }
}

public enum GameState
{
    Menu,
    Start,
    Pause,
    Flying,
    Selecting,
    Exploring,
    Victory,
    Defeat
}
