﻿using System;
using System.Collections.Generic;

namespace Clausewitz.Dsl.SyntaxTree
{
    public class ClausewitzMap : IClausewitzValue
    {
        public ClausewitzMap()
        {
            AssignmentPairs = new Dictionary<string, ClausewitzAssignment>();
        }

        public ClausewitzMap(IEnumerable<ClausewitzAssignment> pairs)
        {
            AssignmentPairs = new Dictionary<string, ClausewitzAssignment>();
            if (pairs != null)
                foreach (var p in pairs)
                    AssignmentPairs.Add(p.Key, p);
        }

        /// <summary>
        ///     All the Clausewitz pair objects
        /// </summary>
        private Dictionary<string, ClausewitzAssignment> AssignmentPairs { get; }

        /// <summary>
        ///     Makes Pairs directly accessable
        /// </summary>
        /// <param name="key">The key of the IClausewitzValue</param>
        /// <returns>The IClausewitzValue at that key</returns>
        public IClausewitzValue this[string key]
        {
            get
            {
                if (AssignmentPairs.ContainsKey(key)) return AssignmentPairs[key].Value;
                throw new ArgumentException("Key not found: " + key);
            }
            set => throw new NotImplementedException("Cannot access ClausewitzMap by string.");
        }

        public IClausewitzValue this[int i]
        {
            get => throw new NotImplementedException("Cannot access ClausewitzMap by int.");
            set => throw new NotImplementedException("Cannot access ClausewitzMap by int.");
        }
    }
}