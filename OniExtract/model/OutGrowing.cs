﻿using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;

namespace OniExtract2
{
    public class OutGrowing
    {
        public bool shouldGrowOld = true;
        public float maxAge = 2400f;

        public OutGrowing(Growing tv)
        {
            this.shouldGrowOld = tv.shouldGrowOld;
            this.maxAge = tv.maxAge;
        }
    }
}
