// Exception.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Collections;
using System.Runtime.CompilerServices;

namespace System {
	[Imported(ObeysTypeSystem = true)]
	[ScriptNamespace("ss")]
	public class Exception {
		[ScriptName("")]
		public Exception() {
		}

		[ScriptName("")]
		public Exception(string message) {
		}

		[ScriptName("")]
		public Exception(string message, Exception innerException) {
		}

		public virtual string Message {
			get { return null; }
		}

		public virtual Exception InnerException {
			get { return null; }
		}

		/// <summary>
		/// The call stack of the construction of this Exception.
		/// If call stacks are not available on the current platform, this will be null.
		/// </summary>
		public virtual string Stack {
			get { return null; }
		}
	}
}
