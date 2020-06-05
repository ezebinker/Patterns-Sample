using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace patrones_comportamiento
{
    class Program3
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main3()
        {
            dContext context = new dContext();

            // Usually a tree 
            ArrayList list = new ArrayList();

            // Populate 'abstract syntax tree' 
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            // Interpret
            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Context' class
    /// </summary>
    class dContext
    {
    }

    /// <summary>
    /// The 'AbstractExpression' abstract class
    /// </summary>
    abstract class AbstractExpression
    {
        public abstract void Interpret(dContext context);
    }

    /// <summary>
    /// The 'TerminalExpression' class
    /// </summary>
    class TerminalExpression : AbstractExpression
    {
        public override void Interpret(dContext context)
        {
            Console.WriteLine("Called Terminal.Interpret()");
        }
    }

    /// <summary>
    /// The 'NonterminalExpression' class
    /// </summary>
    class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(dContext context)
        {
            Console.WriteLine("Called Nonterminal.Interpret()");
        }
    }
}

