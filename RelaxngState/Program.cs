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
using System.Linq;
using System.Text;
using System.Collections;
using System.Xml;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Diagnostics;
using RelaxngState;

namespace RelaxngState
{
    public class Program
    {
        public static void Main (string[] args)
        {

//            var dict = args
//                .Where (x => x.StartsWith ("--"))
//                .Where (x => x.Contains ('='))
//                .ToDictionary (x => x.Substring (2, x.IndexOf ('=') - 2),
//                           x => x.Substring (x.IndexOf ('=') + 1));
//
//            if (args.Length != 2 || dict.Count != 2 || !dict.ContainsKey ("srng") || !dict.ContainsKey ("out")) {
//                var self = Path.GetFileName (Process.GetCurrentProcess ().MainModule.FileName);
//                Console.Error.WriteLine ("-------------------------------------------------------------------------------");
//                Console.Error.WriteLine ("{0} turns RELAX NG schemas in the simple syntax into JSON. The simple", self);
//                Console.Error.WriteLine ("syntax is defined in <http://www.relaxng.org/spec-20011203.html#simple-syntax>.");
//                Console.Error.WriteLine ("Tools like http://www.kohsuke.org/relaxng/rng2srng/ convert from full syntax.");
//                Console.Error.WriteLine ("Note: data types and lists and mandatory or forbidden text, all not supported.");
//                Console.Error.WriteLine ("-------------------------------------------------------------------------------");
//                Console.Error.WriteLine ("  Usage: {0} --srng=path --out=path", self);
//                Console.Error.WriteLine ("-------------------------------------------------------------------------------");
//                Console.Error.WriteLine ("data:,404%20Not%20Found. - (c) 2010-2011 Bjoern Hoehrmann - bjoern@hoehrmann.de");
//                Console.Error.WriteLine ("-------------------------------------------------------------------------------");
//                return;
//            }

            var g = new Grammar ("/home/winslow/Documents/two-graves/lib/docbook-5.0/rng/docbookxi.rng", "/home/winslow/Documents/test.json");//dict ["srng"], dict ["out"]);
            g.SimulateAll ();
        }
    }
}
