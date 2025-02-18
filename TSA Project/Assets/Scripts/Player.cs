// using UnityEngine;
// using System;
// using System.Collections.Generic;

// public class Player : MonoBehaviour
// {
//     private static int characterCount = 0; 
//     private Rigidbody2D rb;
//     private Dictionary<string, int> stats;
//     private Dictionary<string, int> relationships;
//     public static List<string> characters = new List<string>();
//     private string name;

//     public Player(string name, int tiredness, int illness, int sanity, int esteem, int fitness)
//     {
//         this.name = name; 
//         characterCount++; 
//         stats = new Dictionary<string, int>
//         {
//             { "Tiredness", tiredness},
//             {"Illness", illness},
//             {"Sanity", sanity},
//             {"Self-Esteem", esteem},
//             {"Fitness", fitness}
//         };
//         characters.Add(name);
//         characters[name] = name;

//         relationshipManager = new Relationship();
//     }
//     public void Start()
//     {
//         rb = GetComponent<Rigidbody2D>();
//     }
//     public void Update()
//     {
//         //Add code if you need to 
        
//     }

//     public Dictionary<string, int> getStats()
//     {
//         return stats; 
//     }
    
//     public void changeStats(string statName, int statValue)
//     {
//         if(stats.ContainsKey(statName))
//         {
//             stats[statName] = statValue;
//         }
//     }

//     public void setRelationship(string character, int relationship)
//     {
//          relationshipManager.SetRelationship(character, relationshipValue);
//     }

//     public void addRelationship(string character, int relationship)
//     {
//          relationshipManager.AddRelationship(character, increase);
       
//     }

//     public static int getCharacterCount()
//     {
//         return characterCount;
//     }

//     public static List<string> GetCharacters()
//     {
//         return characters;
//     }

// }

