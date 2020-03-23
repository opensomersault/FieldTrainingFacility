﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FieldTrainingFacility
{
    class Log
    {
        /// <summary>
        /// sends the specific message to ingame mail and screen if Debug is defined
        /// For debugging use only.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        /// <param name="params">The parameters.</param>
        [ConditionalAttribute("DEBUG")]
        internal static void dbg(string msg, params object[] @params)
        {
            if (0 != @params.Length) msg = string.Format(msg, @params);
            ScreenMessages.PostScreenMessage(msg, 1, ScreenMessageStyle.UPPER_CENTER, true);
            //Logg.Info(msg);
            //? UnityEngine.Debug.Log("[FTF] " + msg);
        }
    }
}
