using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnemyBase : ScriptableObject
{
    public int MaxHP => _maxHP;

    public int Attack => _attack;

    public int Defense => _defense;

    public int SPAttack => _spAttack;

    public int SPDefanse => _spDefense;

    public int Speed => _speed;

    //名前、説明、タイプ、ステータス、画像

    [SerializeField]
    string _name;

    [SerializeField]
    string _description;

    [SerializeField]
    Sprite _frontSprite;

    [SerializeField]
    Sprite _backSprite;

    [SerializeField]
    EnemyType _type1;

    [SerializeField]
    EnemyType _type2;

    //ステータス:hp,at,df,sAT,sDF,sp
    [SerializeField]
    int _maxHP;

    [SerializeField]
    int _attack;

    [SerializeField]
    int _defense;

    [SerializeField]
    int _spAttack;

    [SerializeField]
    int _spDefense;

    [SerializeField]
    int _speed;
}

public enum EnemyType
{
    None,
    Fire,
    Water,
    Electric,
    Grass,
    Ice,
    Fighting,
    Poison,
    Ground,
    Flying,
    Psychic,
    Bug,
    Rock,
    Ghost,
    Dragon,
}