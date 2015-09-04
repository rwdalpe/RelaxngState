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

namespace RelaxngState
{
    public enum PatternType
    {
        NotAllowed,
        Empty,
        Ref,
        OneOrMore,
        Choice,
        Group,
        Text,
        Attribute,
        Interleave,
        Element,
        Define,
        And,
        Not,
        AnyName,
        LnName,
        NsName,
    }
}

