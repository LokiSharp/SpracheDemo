﻿using System;
using System.Collections.Generic;

namespace Clausewitz.Dsl.SyntaxTree
{
    public class ClausewitzMap : IClausewitzValue
    {
        public ClausewitzMap()
        {
            Pairs = new Dictionary<string, IClausewitzValue>();
        }

        public ClausewitzMap(IEnumerable<ClausewitzAssignment> pairs)
        {
            Pairs = new Dictionary<string, IClausewitzValue>();
            if (pairs != null)
                foreach (var p in pairs)
                    Pairs.Add(p.Key, p.Value);
        }

        /// <summary>
        ///     All the Clausewitz pair objects
        /// </summary>
        private Dictionary<string, IClausewitzValue> Pairs { get; }

        /// <summary>
        ///     Makes Pairs directly accessable
        /// </summary>
        /// <param name="key">The key of the IClausewitzValue</param>
        /// <returns>The IClausewitzValue at that key</returns>
        public IClausewitzValue this[string key]
        {
            get
            {
                if (Pairs.ContainsKey(key)) return Pairs[key];
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