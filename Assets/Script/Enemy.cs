using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//レベルに応じたステータスの違うモンスターを生成するクラス
public class Enemy
{
    public int HP { get; set; }

    //使える技
    public List<Move> Moves { get; set; }

    EnemyBase _base;

    int _level;

    //敵の体力

    //コンストラクター:生成時の初期設定
    public Enemy(EnemyBase pBase, int pLevel)
    {
        _base = pBase;
        _level = pLevel;
        HP = pBase.MaxHP;

        //使える技の設定:使える技のレベル以上なら、Movesに追加
        foreach (LearnableMove learnableMove in pBase.LearnableMoves)
	    {
            //技を覚える
            if (_level >= learnableMove.Level)
            {
                Moves.Add(new Move(learnableMove.Base));
            }

            //4つ以上は覚えない
            if (Moves.Count >= 4)
            {
                break;
            }
	    }
    }


    //levelに応じたステータスを返すもの:プロパティ
    public int Attack => Mathf.FloorToInt((_base.Attack * _level) / 100f) + 5;

    public int Defense => Mathf.FloorToInt((_base.Defense * _level) / 100f) + 5;

    public int SpAttack => Mathf.FloorToInt((_base.SPAttack * _level) / 100f) + 5;

    public int SpDefense => Mathf.FloorToInt((_base.SPDefanse * _level) / 100f) + 5;

    public int Speed => Mathf.FloorToInt((_base.Speed * _level) / 100f) + 5;

    public int MaxHp => Mathf.FloorToInt((_base.MaxHP * _level) / 100f) + 10;
}
