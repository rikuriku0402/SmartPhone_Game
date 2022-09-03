using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MoveBase : ScriptableObject
{
    public string Name => _name;

    public string Description => _description;

    public EnemyType Type => _type;

    public int Power => _power;

    public int Accuracy => _accuracy;

    public int PP => _pp;


    //�Z�f�[�^

    //���O�A�ڍׁA�^�C�v�A�З́A���m���APP(����|�C���g)

    [SerializeField]
    string _name;

    [TextArea]
    [SerializeField]
    string _description;

    [SerializeField]
    EnemyType _type;

    [SerializeField]
    int _power;

    [SerializeField]
    int _accuracy;

    [SerializeField]
    int _pp;
}
