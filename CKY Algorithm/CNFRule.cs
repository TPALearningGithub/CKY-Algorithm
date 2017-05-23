using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKY_Algorithm
{
    class CNFRule
    {
        private string _left;

        public string Left
        {
            get { return _left; }
            private set { _left = value; }
        }

        private string _right;

        public string Right
        {
            get { return _right; }
            private set { _right = value; }
        }

        /// <summary>
        /// Creates new CNF Rule from a string with format "A -> B C"
        /// </summary>
        /// <param name="rule">string with format "a -> B C"</param>
        public CNFRule(string rule)
        {
            // Split rule into 2 part by token "->"
            List<string> Splited = rule.Split(new[] { '-', '>' }).ToList();
            Left = Splited.First().Trim();
            Right = Splited.Last().Trim();
        }

        /// <summary>
        /// Checks out a CNFRule contain dest in Right side or not.
        /// </summary>
        /// <param name="dest"></param>
        /// <returns></returns>
        public bool Contains(string dest)
        {
            return (Right == dest);
        }

        public override string ToString()
        {
            return Left + "->" + Right;
        }
    }
}
