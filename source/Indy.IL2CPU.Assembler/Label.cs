﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indy.IL2CPU.Assembler {
	public class Label: Instruction {
		public readonly string Name;
		public Label(string aName) {
			Name = aName;
		}
		public override string ToString() {
			return Name + ":";
		}
	}
}
