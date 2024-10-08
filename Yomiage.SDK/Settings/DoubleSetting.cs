﻿// <copyright file="DoubleSetting.cs" company="bisu">
// © 2021 bisu
// </copyright>

namespace Yomiage.SDK.Settings
{
    /// <summary>
    /// 実数値の設定
    /// </summary>
    public class DoubleSetting : SettingBase, ISetting<double>
    {
        /// <inheritdoc/>
        public double Value { get; set; }

        /// <inheritdoc/>
        public double DefaultValue { get; set; }

        /// <summary>
        /// 設定可能な最小値
        /// </summary>
        public double Min { get; set; }

        /// <summary>
        /// 設定可能な最大値
        /// </summary>
        public double Max { get; set; }

        /// <summary>
        /// GUIでの最小ステップ
        /// ただし、入力の最小値ではない。
        /// 例えば SmallStep = 2 としても、偶数のみ、奇数のみの入力になるわけではない。
        /// </summary>
        public double SmallStep { get; set; }

        /// <summary>
        /// 0.00 みたいな感じ
        /// </summary>
        public string StringFormat { get; set; }

        /// <inheritdoc/>
        public override void ResetValue()
        {
            Value = DefaultValue;
        }

        /// <inheritdoc/>
        public override void Fix()
        {
            Value = Value.Fix();
            DefaultValue = DefaultValue.Fix();
            Min = Min.Fix();
            Max = Max.Fix();
            SmallStep = SmallStep.Fix();
            StringFormat = StringFormat.Fix();
            if (Min > Max)
            {
                var temp = Min;
                Min = Max;
                Max = temp;
            }

            Value = Value.Clamp(Min, Max);
            DefaultValue = DefaultValue.Clamp(Min, Max);
            if (SmallStep <= 0)
            {
                SmallStep = (Max - Min) / 100;
            }
        }
    }
}
