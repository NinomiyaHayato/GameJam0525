using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="EnemyData", menuName ="Data/Enemy")]
public class EnemyData : ScriptableObject
{
    [SerializeField] int _speed;

    public int Speed { get => _speed; set => _speed = value; }
}
