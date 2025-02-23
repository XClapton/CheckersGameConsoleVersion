﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace checkersLogic
{

    public enum eEntity
    {
        Player1,
        Player2,
        Empty,
        Inaccessible
    }

    public class Cell
    {
        private eEntity m_Entity;

        private bool m_isKing;

        public Cell(eEntity i_Entity)
        {
            m_Entity = i_Entity;
            m_isKing = false;
        }

        public eEntity Entity
        {
            get { return m_Entity; }
            set { m_Entity = value; }
        }

        public bool    IsKing
        {
            get { return m_isKing; }
            set { m_isKing = value; }
        }
    }
}
