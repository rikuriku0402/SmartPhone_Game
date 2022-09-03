using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu]
public class EnemyBase : ScriptableObject
{
    public int MaxHP => _maxHP;

    public int Attack => _attack;

    public int Defense => _defense;

    public int SPAttack => _spAttack;

    public int SPDefanse => _spDefense;

    public int Speed => _speed;

    public List <LearnableMove> LearnableMoves => _learnableMoves;

    //���O�A�����A�^�C�v�A�X�e�[�^�X�A�摜

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

    //�X�e�[�^�X:hp,at,df,sAT,sDF,sp
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

    //�o����Z�ꗗ
    [SerializeField]
    List<LearnableMove> _learnableMoves;
}

//�o����Z:���x���ɉ����Ċo���čs��
[Serializable]
public class LearnableMove
{
    public MoveBase Base => _base;
    public int Level => _level;

    [SerializeField]
    MoveBase _base;

    [SerializeField]
    int _level;
}

public enum EnemyType
{
    None,
    Normal,
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