﻿// <copyright file="SettingsBase.cs" company="bisu">
// © 2021 bisu
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace Yomiage.SDK.Settings
{
    /// <summary>
    /// プラグイン（音声合成エンジン、音声ライブラリのこと）の設定内容。
    /// つまり、プラグインの開発者が決めた設定項目であり、
    /// Hide を False にしておけばGUIからも変更可能で、ユーザーに設定内容を任せることもできる。
    /// </summary>
    public abstract class SettingsBase : Common.IFixAble
    {
        /// <summary>
        /// 真偽値の設定値
        /// </summary>
        public SettingList<BoolSetting, bool> Bools { get; set; } = new SettingList<BoolSetting, bool>();

        /// <summary>
        /// 整数値の設定値
        /// </summary>
        public SettingList<IntSetting, int> Ints { get; set; } = new SettingList<IntSetting, int>();

        /// <summary>
        /// 実数値の設定値
        /// </summary>
        public SettingList<DoubleSetting, double> Doubles { get; set; } = new SettingList<DoubleSetting, double>();

        /// <summary>
        /// 文字列の設定値
        /// </summary>
        public SettingList<StringSetting, string> Strings { get; set; } = new SettingList<StringSetting, string>();

        /// <summary>
        /// 初期値を設定値に代入
        /// </summary>
        public void ResetAllValues()
        {
            Bools.ResetValues();
            Ints.ResetValues();
            Doubles.ResetValues();
            Strings.ResetValues();
        }

        /// <inheritdoc/>
        public void Fix()
        {
            Bools.Fix();
            Ints.Fix();
            Doubles.Fix();
            Strings.Fix();
        }
    }
}
