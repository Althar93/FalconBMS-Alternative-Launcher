﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconBMS_Alternative_Launcher_Cs
{
    /// <summary>
    /// Means each actual POV switches on a joystick.
    /// </summary>
    public class PovAssgn
    {
        /// <summary>
        /// One POV switch has 8 directions.
        /// </summary>
        public DirAssgn[] direction = new DirAssgn[8];

        // Constructor
        public PovAssgn() { }
        public PovAssgn(DirAssgn[] direction)
        {
            for (int i = 0; i < 8; i++)
            {
                this.direction[i] = direction[i].Clone();
            }
        }

        // Method
        public void Assign(int GetPointofView, string callback, Pinky pinky, int soundID)
        {
            if (GetPointofView > 7)
                GetPointofView = GetPointofView / 4500;
            this.direction[GetPointofView].Assign(callback, pinky, soundID);
        }

        public string GetDirection(int GetPointOfView)
        {
            string direction = "";
            if (GetPointOfView > 7)
                GetPointOfView = GetPointOfView / 4500;
            switch (GetPointOfView)
            {
                case 0:
                    direction = "UP";
                    break;
                case 1:
                    direction = "UPRIGHT";
                    break;
                case 2:
                    direction = "RIGHT";
                    break;
                case 3:
                    direction = "DOWNRIGHT";
                    break;
                case 4:
                    direction = "DOWN";
                    break;
                case 5:
                    direction = "DOWNLEFT";
                    break;
                case 6:
                    direction = "LEFT";
                    break;
                case 7:
                    direction = "UPLEFT";
                    break;
            }
            return direction;
        }

        public PovAssgn Clone()
        {
            return new PovAssgn(this.direction);
        }
    }

    /// <summary>
    /// Means each direction on a POV switch,
    /// </summary>
    public class DirAssgn
    {
        // Member
        protected string[] callback = new string[2] { "SimDoNothing", "SimDoNothing" };
        protected int[] soundID = new int[2] { 0, 0 };
        // [0]=PRESS
        // [1]=PRESS + SHIFT

        // Property for XML
        public string[] Callback { get { return this.callback; } set { this.callback = value; } }
        public int[] SoundID { get { return this.soundID; } set { this.soundID = value; } }

        // Constructor
        public DirAssgn() { }
        public DirAssgn(string[] callback, int[] soundID)
        {
            this.callback = callback;
            this.soundID = soundID;
        }

        // Method
        public string GetCallback(Pinky pinky) { return this.callback[(int)pinky]; }
        public int GetSoundID(Pinky pinky) { return this.soundID[(int)pinky]; }

        public void Assign(string callback, Pinky pinky, int soundID)
        {
            this.callback[(int)pinky] = callback;
            this.soundID[(int)pinky] = soundID;
        }

        public void UnAssign(Pinky pinky)
        {
            this.callback[(int)pinky] = "SimDoNothing";
            this.soundID[(int)pinky] = 0;
        }

        public DirAssgn Clone()
        {
            return new DirAssgn(this.callback, this.soundID);
        }
    }
}
