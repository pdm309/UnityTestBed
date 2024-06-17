using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BracketGenerator : MonoBehaviour
{

    [SerializeField] public int BracketSize = 32;

    public string[] entrants;
    private string[] fighters;
    // Start is called before the first frame update
    void Start()
    {
        entrants = new string[BracketSize];
        fighters = new string[]{"Mario","Donkey Kong","Link","Samus","Dark Samus","Yoshi","Kirby","Fox","Pikachu","Luigi","Ness","Captain Falcon","Jigglypuff","Peach","Daisy","Bowser","Ice Climbers","Sheik","Zelda","Dr. Mario","Pichu","Falco","Marth","Lucina","Young Link","Ganondorf","Mewtwo","Roy","Chrom","Mr. Game &amp Watch","Meta Knight","Pit","Dark Pit","Zero Suit Samus","Wario","Snake","Ike","Pokemon Trainer","Diddy Kong","Lucas","Sonic","King Dedede","Olimar","Lucario","R.O.B.","Toon Link","Wolf","Villager","Megaman","Wii Fit TRAINER","Rosalina &amp Luma","Little Mac","Greninja","Mii Brawler","Mii Swordfighter","Mii Gunner","Palutena","Pac-Man","Robin","Shulk","Bowser Jr.","Duck Hunt","Ryu","Ken","Cloud","Corrin","Bayonetta","Inkling","Ridley","Simon","Richter","King K. Rool","Isabelle","Incineroar","Piranha Plant","Joker","Hero","Banjo &amp Kazooie","Terry","Byleth","Min Min","Steve","Sephiroth","Pyra/Mythra","Kazuya","Sora"};
        StartCoroutine(ChooseCharacters());
    }

    void Awake(){
        
    }

    // Update is called once per frame
    void Update()
    {
        //todo draw a tree that can be recursively iterated upon to simulate a single elim bracket using line renderer
        
    }

    IEnumerator ChooseCharacters(){
        for (int i = 0; i < entrants.Length; i++){
            entrants[i] = fighters[UnityEngine.Random.Range (0, fighters.Length)];            
        }
        yield return null;
    }
}
