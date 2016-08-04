﻿using System.Collections.Generic;
using PreAdamant.Compiler.Core.Diagnostics;
using PreAdamant.Compiler.Syntax;

namespace PreAdamant.Compiler.Semantics
{
	/// <summary>
	/// A compiled package
	/// </summary>
	public class Package
	{
		public string Name => Syntax.Name;
		public PackageSyntax Syntax { get; }
		//	public Symbol<PackageContext> Symbol { get; set; }
		public IReadOnlyList<Diagnostic> Diagnostics => Syntax.Diagnostics; // TODO have semantic errors too

		public Package(PackageSyntax syntax)
		{
			Syntax = syntax;
		}
	}
}