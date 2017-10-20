using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/PlayerStats")]
public class PlayerStats : ScriptableObject
{
    public int health;
    public float speed;
    public float scale;
}
