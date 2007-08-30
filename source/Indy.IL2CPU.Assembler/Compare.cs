﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indy.IL2CPU.Assembler {
	public class Compare: Instruction {
		public readonly string Address1;
		public readonly string Address2;
		public Compare(string aAddress1, string aAddress2) {
			Address1 = aAddress1;
			Address2 = aAddress2;
		}
		public override string ToString() {
			return "cmp " + Address1 + "," + Address2;
		}
	}
}