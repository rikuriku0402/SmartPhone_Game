using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���x���ɉ������X�e�[�^�X�̈Ⴄ�����X�^�[�𐶐�����N���X
public class Enemy
{
    public int HP { get; set; }

    //�g����Z
    public List<Move> Moves { get; set; }

    EnemyBase _base;

    int _level;

    //�G�̗̑�

    //�R���X�g���N�^�[:�������̏����ݒ�
    public Enemy(EnemyBase pBase, int pLevel)
    {
        _base = pBase;
        _level = pLevel;
        HP = pBase.MaxHP;

        //�g����Z�̐ݒ�:�g����Z�̃��x���ȏ�Ȃ�AMoves�ɒǉ�
        foreach (LearnableMove learnableMove in pBase.LearnableMoves)
	    {
            //�Z���o����
            if (_level >= learnableMove.Level)
            {
                Moves.Add(new Move(learnableMove.Base));
            }

            //4�ȏ�͊o���Ȃ�
            if (Moves.Count >= 4)
            {
                break;
            }
	    }
    }


    //level�ɉ������X�e�[�^�X��Ԃ�����:�v���p�e�B
    public int Attack => Mathf.FloorToInt((_base.Attack * _level) / 100f) + 5;

    public int Defense => Mathf.FloorToInt((_base.Defense * _level) / 100f) + 5;

    public int SpAttack => Mathf.FloorToInt((_base.SPAttack * _level) / 100f) + 5;

    public int SpDefense => Mathf.FloorToInt((_base.SPDefanse * _level) / 100f) + 5;

    public int Speed => Mathf.FloorToInt((_base.Speed * _level) / 100f) + 5;

    public int MaxHp => Mathf.FloorToInt((_base.MaxHP * _level) / 100f) + 10;
}
