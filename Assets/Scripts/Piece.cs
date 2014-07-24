using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    public class Piece
    {
        public int OriginalI { get; set; }
        public int OriginalJ { get; set; }

        public int CurrentI { get; set; }
        public int CurrentJ { get; set; }

        public GameObject GameObject { get; set; }
    }
}
