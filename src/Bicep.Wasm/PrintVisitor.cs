﻿using System;
using Bicep.Core.Parser;
using Bicep.Core.Syntax;
using Bicep.Core.Visitors;

namespace Bicep.Wasm
{
    class PrintVisitor : TokenVisitor
    {
        private readonly Action<string> printFunc;

        public PrintVisitor(Action<string> printFunc)
        {
            this.printFunc = printFunc;
        }

        protected override void VisitToken(Token token)
        {
            printFunc(token.LeadingTrivia);
            printFunc(token.Text);
            printFunc(token.TrailingTrivia);
        }
    }
}