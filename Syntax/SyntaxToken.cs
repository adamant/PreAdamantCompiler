﻿using System;
using System.Collections.Generic;
using PreAdamant.Compiler.Core;

namespace PreAdamant.Compiler.Syntax
{
	public class SyntaxToken : ISyntax
	{
		public ISourceText Source { get; }
		public TextSpan SourceSpan { get; }
		public string Text { get; }
		public bool IsPoisoned { get; private set; }
		public bool IsTrivia { get; }
		public IReadOnlyList<ISyntax> Children => Syntax.NoChildren;

		protected SyntaxToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
		{
			Source = source;
			SourceSpan = new TextSpan(startIndex, stopIndex - startIndex);
			switch(channel)
			{
				case PreAdamantLexer.Channel.Main:
					IsTrivia = false;
					break;
				case PreAdamantLexer.Channel.Trivia:
					IsTrivia = true;
					break;
				default:
					throw new NotSupportedException($"Channel '{channel}' not supported");
			}
			Text = text;
		}

		public void Poison()
		{
			IsPoisoned = true;
		}
	}
}
