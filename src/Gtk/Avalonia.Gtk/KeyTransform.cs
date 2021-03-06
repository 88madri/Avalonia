﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Input;
#if GTK3_PINVOKE
using Avalonia.Gtk3;
#else
using GdkKey = Gdk.Key;
#endif
namespace Avalonia.Gtk.Common
{
    static class KeyTransform
    {
        private static readonly Dictionary<GdkKey, Key> KeyDic = new Dictionary<GdkKey, Key>
        {
            { GdkKey.Cancel, Key.Cancel },
            { GdkKey.BackSpace, Key.Back },
            { GdkKey.Tab, Key.Tab },
            { GdkKey.Linefeed, Key.LineFeed },
            { GdkKey.Clear, Key.Clear },
            { GdkKey.Return, Key.Return },
            { GdkKey.Pause, Key.Pause },
            //{ GdkKey.?, Key.CapsLock }
            //{ GdkKey.?, Key.HangulMode }
            //{ GdkKey.?, Key.JunjaMode }
            //{ GdkKey.?, Key.FinalMode }
            //{ GdkKey.?, Key.KanjiMode }
            { GdkKey.Escape, Key.Escape },
            //{ GdkKey.?, Key.ImeConvert }
            //{ GdkKey.?, Key.ImeNonConvert }
            //{ GdkKey.?, Key.ImeAccept }
            //{ GdkKey.?, Key.ImeModeChange }
            { GdkKey.space, Key.Space },
            { GdkKey.Prior, Key.Prior },
            //{ GdkKey.?, Key.PageDown }
            { GdkKey.End, Key.End },
            { GdkKey.Home, Key.Home },
            { GdkKey.Left, Key.Left },
            { GdkKey.Up, Key.Up },
            { GdkKey.Right, Key.Right },
            { GdkKey.Down, Key.Down },
            { GdkKey.Select, Key.Select },
            { GdkKey.Print, Key.Print },
            { GdkKey.Execute, Key.Execute },
            //{ GdkKey.?, Key.Snapshot }
            { GdkKey.Insert, Key.Insert },
            { GdkKey.Delete, Key.Delete },
            { GdkKey.Help, Key.Help },
            //{ GdkKey.?, Key.D0 }
            //{ GdkKey.?, Key.D1 }
            //{ GdkKey.?, Key.D2 }
            //{ GdkKey.?, Key.D3 }
            //{ GdkKey.?, Key.D4 }
            //{ GdkKey.?, Key.D5 }
            //{ GdkKey.?, Key.D6 }
            //{ GdkKey.?, Key.D7 }
            //{ GdkKey.?, Key.D8 }
            //{ GdkKey.?, Key.D9 }
            { GdkKey.A, Key.A },
            { GdkKey.B, Key.B },
            { GdkKey.C, Key.C },
            { GdkKey.D, Key.D },
            { GdkKey.E, Key.E },
            { GdkKey.F, Key.F },
            { GdkKey.G, Key.G },
            { GdkKey.H, Key.H },
            { GdkKey.I, Key.I },
            { GdkKey.J, Key.J },
            { GdkKey.K, Key.K },
            { GdkKey.L, Key.L },
            { GdkKey.M, Key.M },
            { GdkKey.N, Key.N },
            { GdkKey.O, Key.O },
            { GdkKey.P, Key.P },
            { GdkKey.Q, Key.Q },
            { GdkKey.R, Key.R },
            { GdkKey.S, Key.S },
            { GdkKey.T, Key.T },
            { GdkKey.U, Key.U },
            { GdkKey.V, Key.V },
            { GdkKey.W, Key.W },
            { GdkKey.X, Key.X },
            { GdkKey.Y, Key.Y },
            { GdkKey.Z, Key.Z },
            { GdkKey.a, Key.A },
            { GdkKey.b, Key.B },
            { GdkKey.c, Key.C },
            { GdkKey.d, Key.D },
            { GdkKey.e, Key.E },
            { GdkKey.f, Key.F },
            { GdkKey.g, Key.G },
            { GdkKey.h, Key.H },
            { GdkKey.i, Key.I },
            { GdkKey.j, Key.J },
            { GdkKey.k, Key.K },
            { GdkKey.l, Key.L },
            { GdkKey.m, Key.M },
            { GdkKey.n, Key.N },
            { GdkKey.o, Key.O },
            { GdkKey.p, Key.P },
            { GdkKey.q, Key.Q },
            { GdkKey.r, Key.R },
            { GdkKey.s, Key.S },
            { GdkKey.t, Key.T },
            { GdkKey.u, Key.U },
            { GdkKey.v, Key.V },
            { GdkKey.w, Key.W },
            { GdkKey.x, Key.X },
            { GdkKey.y, Key.Y },
            { GdkKey.z, Key.Z },
            //{ GdkKey.?, Key.LWin }
            //{ GdkKey.?, Key.RWin }
            //{ GdkKey.?, Key.Apps }
            //{ GdkKey.?, Key.Sleep }
            //{ GdkKey.?, Key.NumPad0 }
            //{ GdkKey.?, Key.NumPad1 }
            //{ GdkKey.?, Key.NumPad2 }
            //{ GdkKey.?, Key.NumPad3 }
            //{ GdkKey.?, Key.NumPad4 }
            //{ GdkKey.?, Key.NumPad5 }
            //{ GdkKey.?, Key.NumPad6 }
            //{ GdkKey.?, Key.NumPad7 }
            //{ GdkKey.?, Key.NumPad8 }
            //{ GdkKey.?, Key.NumPad9 }
            { GdkKey.multiply, Key.Multiply },
            //{ GdkKey.?, Key.Add }
            //{ GdkKey.?, Key.Separator }
            //{ GdkKey.?, Key.Subtract }
            //{ GdkKey.?, Key.Decimal }
            //{ GdkKey.?, Key.Divide }
            { GdkKey.F1, Key.F1 },
            { GdkKey.F2, Key.F2 },
            { GdkKey.F3, Key.F3 },
            { GdkKey.F4, Key.F4 },
            { GdkKey.F5, Key.F5 },
            { GdkKey.F6, Key.F6 },
            { GdkKey.F7, Key.F7 },
            { GdkKey.F8, Key.F8 },
            { GdkKey.F9, Key.F9 },
            { GdkKey.F10, Key.F10 },
            { GdkKey.F11, Key.F11 },
            { GdkKey.F12, Key.F12 },
            { GdkKey.L3, Key.F13 },
            { GdkKey.F14, Key.F14 },
            { GdkKey.L5, Key.F15 },
            { GdkKey.F16, Key.F16 },
            { GdkKey.F17, Key.F17 },
            { GdkKey.L8, Key.F18 },
            { GdkKey.L9, Key.F19 },
            { GdkKey.L10, Key.F20 },
            { GdkKey.R1, Key.F21 },
            { GdkKey.R2, Key.F22 },
            { GdkKey.F23, Key.F23 },
            { GdkKey.R4, Key.F24 },
            //{ GdkKey.?, Key.NumLock }
            //{ GdkKey.?, Key.Scroll }
            //{ GdkKey.?, Key.LeftShift }
            //{ GdkKey.?, Key.RightShift }
            //{ GdkKey.?, Key.LeftCtrl }
            //{ GdkKey.?, Key.RightCtrl }
            //{ GdkKey.?, Key.LeftAlt }
            //{ GdkKey.?, Key.RightAlt }
            //{ GdkKey.?, Key.BrowserBack }
            //{ GdkKey.?, Key.BrowserForward }
            //{ GdkKey.?, Key.BrowserRefresh }
            //{ GdkKey.?, Key.BrowserStop }
            //{ GdkKey.?, Key.BrowserSearch }
            //{ GdkKey.?, Key.BrowserFavorites }
            //{ GdkKey.?, Key.BrowserHome }
            //{ GdkKey.?, Key.VolumeMute }
            //{ GdkKey.?, Key.VolumeDown }
            //{ GdkKey.?, Key.VolumeUp }
            //{ GdkKey.?, Key.MediaNextTrack }
            //{ GdkKey.?, Key.MediaPreviousTrack }
            //{ GdkKey.?, Key.MediaStop }
            //{ GdkKey.?, Key.MediaPlayPause }
            //{ GdkKey.?, Key.LaunchMail }
            //{ GdkKey.?, Key.SelectMedia }
            //{ GdkKey.?, Key.LaunchApplication1 }
            //{ GdkKey.?, Key.LaunchApplication2 }
            //{ GdkKey.?, Key.OemSemicolon }
            //{ GdkKey.?, Key.OemPlus }
            //{ GdkKey.?, Key.OemComma }
            //{ GdkKey.?, Key.OemMinus }
            //{ GdkKey.?, Key.OemPeriod }
            //{ GdkKey.?, Key.Oem2 }
            //{ GdkKey.?, Key.OemTilde }
            //{ GdkKey.?, Key.AbntC1 }
            //{ GdkKey.?, Key.AbntC2 }
            //{ GdkKey.?, Key.Oem4 }
            //{ GdkKey.?, Key.OemPipe }
            //{ GdkKey.?, Key.OemCloseBrackets }
            //{ GdkKey.?, Key.Oem7 }
            //{ GdkKey.?, Key.Oem8 }
            //{ GdkKey.?, Key.Oem102 }
            //{ GdkKey.?, Key.ImeProcessed }
            //{ GdkKey.?, Key.System }
            //{ GdkKey.?, Key.OemAttn }
            //{ GdkKey.?, Key.OemFinish }
            //{ GdkKey.?, Key.DbeHiragana }
            //{ GdkKey.?, Key.OemAuto }
            //{ GdkKey.?, Key.DbeDbcsChar }
            //{ GdkKey.?, Key.OemBackTab }
            //{ GdkKey.?, Key.Attn }
            //{ GdkKey.?, Key.DbeEnterWordRegisterMode }
            //{ GdkKey.?, Key.DbeEnterImeConfigureMode }
            //{ GdkKey.?, Key.EraseEof }
            //{ GdkKey.?, Key.Play }
            //{ GdkKey.?, Key.Zoom }
            //{ GdkKey.?, Key.NoName }
            //{ GdkKey.?, Key.DbeEnterDialogConversionMode }
            //{ GdkKey.?, Key.OemClear }
            //{ GdkKey.?, Key.DeadCharProcessed }
        };

        public static Key ConvertKey(GdkKey key)
        {
            Key result;
            return KeyDic.TryGetValue(key, out result) ? result : Key.None;
        }
    }
}
