using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Diagnostics;
using System.Threading;
using SlimDX;
using SlimDX.Direct3D9;
using FDK;
using System.Timers;

namespace DTXMania
{
	/// <summary>
	/// 演奏画面の共通クラス (ドラム演奏画面, ギター演奏画面の継承元)
	/// </summary>
	internal abstract class CStage演奏画面共通 : CStage
	{
		// プロパティ

		public bool bAUTOでないチップが１つでもバーを通過した	// 誰も参照していない？？
		{
			get;
			protected set;
		}

		// メソッド

		#region [ t演奏結果を格納する_ドラム() ]
		public void t演奏結果を格納する_ドラム( out CScoreIni.C演奏記録 Drums )
		{
			Drums = new CScoreIni.C演奏記録();

			//if (  )
			{
				Drums.nスコア = (long) this.actScore.Get( E楽器パート.DRUMS, 0 );
				Drums.dbゲーム型スキル値 = CScoreIni.tゲーム型スキルを計算して返す( CDTXMania.DTX.LEVEL.Drums, CDTXMania.DTX.n可視チップ数.Drums, this.nヒット数_Auto含まない.Drums.Perfect, this.actCombo.n現在のコンボ数.P1最高値, E楽器パート.DRUMS, bIsAutoPlay );
				Drums.db演奏型スキル値 = CScoreIni.t演奏型スキルを計算して返す( CDTXMania.DTX.n可視チップ数.Drums, this.nヒット数_Auto含まない.Drums.Perfect, this.nヒット数_Auto含まない.Drums.Great, this.nヒット数_Auto含まない.Drums.Good, this.nヒット数_Auto含まない.Drums.Poor, this.nヒット数_Auto含まない.Drums.Miss, E楽器パート.DRUMS, bIsAutoPlay );
				Drums.nPerfect数 = CDTXMania.ConfigIni.b太鼓パートAutoPlay ? this.nヒット数_Auto含む.Drums.Perfect : this.nヒット数_Auto含まない.Drums.Perfect;
				Drums.nGreat数 = CDTXMania.ConfigIni.b太鼓パートAutoPlay ? this.nヒット数_Auto含む.Drums.Great : this.nヒット数_Auto含まない.Drums.Great;
				Drums.nGood数 = CDTXMania.ConfigIni.b太鼓パートAutoPlay ? this.nヒット数_Auto含む.Drums.Good : this.nヒット数_Auto含まない.Drums.Good;
				Drums.nPoor数 = CDTXMania.ConfigIni.b太鼓パートAutoPlay ? this.nヒット数_Auto含む.Drums.Poor : this.nヒット数_Auto含まない.Drums.Poor;
				Drums.nMiss数 = CDTXMania.ConfigIni.b太鼓パートAutoPlay ? this.nヒット数_Auto含む.Drums.Miss : this.nヒット数_Auto含まない.Drums.Miss;
				Drums.nPerfect数_Auto含まない = this.nヒット数_Auto含まない.Drums.Perfect;
				Drums.nGreat数_Auto含まない = this.nヒット数_Auto含まない.Drums.Great;
