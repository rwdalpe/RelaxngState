/*
 * Copyright (C) 2010-2011 Bjoern Hoehrmann <bjoern@hoehrmann.de>
 * Copyright (C) 2015 Robert Winslow Dalpe <rwdalpe@gmail.com
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 3
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 */

using System;
using System.Collections.Generic;

namespace RelaxngState
{
    public class Pattern
    {
        public Pattern p1;
        public Pattern p2;
        public bool Nullable;
        public PatternType Type;
        public string Name;
        public string Namespace;
        public int? Id;

        public override int GetHashCode ()
        {
            if (!Id.HasValue)
                this.Id =
                    (p1 != null ? p1.GetHashCode () : 0) ^
                (p2 != null ? p2.GetHashCode () : 0) ^
                (Nullable ? 1 : 0) ^
                (Name != null ? Name.GetHashCode () : 0) ^
                (Namespace != null ? Namespace.GetHashCode () : 0) ^
                Type.GetHashCode ();

            return Id.Value;
        }

        public override bool Equals (object obj)
        {
            var other = obj as Pattern;

            if (other == null)
                return false;

            return other.p1 == this.p1 &&
            other.p2 == this.p2 &&
            other.Nullable == this.Nullable &&
            other.Name == this.Name &&
            other.Namespace == this.Namespace &&
            other.Type == this.Type;
        }

        public IEnumerable<Pattern> DescendantNodesAndSelf ()
        {
            if (p1 != null)
                foreach (var p in p1.DescendantNodesAndSelf())
                    yield return p;

            if (p2 != null)
                foreach (var p in p2.DescendantNodesAndSelf())
                    yield return p;

            yield return this;
        }

        public IEnumerable<Pattern> Nodes ()
        {
            if (p1 != null)
                yield return p1;

            if (p2 != null)
                yield return p2;
        }

    }
}

