﻿// This code is distributed under MIT license.
// Copyright (c) 2015 George Mamaladze
// See license.txt or http://opensource.org/licenses/mit-license.php

using System;

namespace Gma.System.MouseKeyHook.WinApi
{
    internal struct CallbackData
    {
        private readonly IntPtr m_LParam;
        private readonly IntPtr m_WParam;
        public Action CallBase { get; }

        public CallbackData(IntPtr wParam, IntPtr lParam, Action callBase)
        {
            m_WParam = wParam;
            m_LParam = lParam;
            this.CallBase = callBase;
        }

        public IntPtr WParam
        {
            get { return m_WParam; }
        }

        public IntPtr LParam
        {
            get { return m_LParam; }
        }
    }
}