using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKY_Algorithm
{
    class CNFGrammar
    {
        private List<CNFRule> _rules = new List<CNFRule>();

        public List<CNFRule> Rules
        {
            get { return new List<CNFRule>(_rules); }
            private set { _rules = value; }
        }

        /// <summary>
        /// Builds a CNFGrammar from text 
        /// </summary>
        /// <param name="gramma">all rules as a string (all text in a text file)</param>
        public CNFGrammar(string gramma)
        {
            List<string> lines = gramma.Split( new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries ).ToList();
            foreach (var line in lines)
            {
                _rules.Add(new CNFRule(line));
            }
        }

#region CKY Algorithm
        /// <summary>
        /// Build CKY Matrix for a  sentence with this (gramma).
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        List<string>[,] BuildCKYMatrixFor(string sentence)
        {
            List<string>[,] result = InitializeCKYMatrixFor(sentence);
            if (result == null)
                return null;
            int NoRows = result.GetLength(0);
            int NoCols = NoRows + 1;
            for (int k = 2; k < NoCols ; k++)
            {
                for (int i = k - 2; i >= 0; i--)
                {
                    for (int j = 1; j < k; j++)
                    {
                        // skip empty square.
                        if(result[i, j].Any() && result [j, k].Any())
                        {
                            var temp = FindInRightSide(result[i, j], result[j, k]);
                            result[i, k].AddRange(temp.Where(x => !result[i,k].Contains(x)));
                        }
                    }
                }
            }
            return result;
        }

        private List<string> FindInRightSide(List<string> list1, List<string> list2)
        {
            List<string> result = new List<string>();
            foreach (var item1 in list1)
            {
                foreach (var item2 in list2)
                {
                    result.AddRange(FindInRightSide(item1 + " " + item2));
                }
            }
            return result;
        }

        /// <summary>
        /// Initialize CKY Matrix for CKY algorithm.
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        private List<string>[,] InitializeCKYMatrixFor(string sentence)
        {
            List<string> words = sentence.Split(' ').ToList();
            int length = words.Count;
            List<string>[,] result = new List<string>[length, length + 1];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length + 1; j++)
                {
                    result[i, j] = new List<string>();
                }
            }
            for (int i = 0; i < length; i++)
            {
                List<string> foundRule = FindInRightSide(words[i]);
                if (foundRule.Any())
                    result[i, i + 1] = foundRule;
                else
                    return null;
            }
            return result;
        }

        /// <summary>
        /// Finds rule that contains key in Right side.
        /// </summary>
        /// <param name="key"></param>
        /// <returns> Left side of all rules contains key or null</returns>
        private List<string> FindInRightSide(string key)
        {
            List<string> result = new List<string>();
            foreach (var rule in _rules)
            {
                if (rule.Contains(key))
                {
                    result.Add(rule.Left);
                }
            }
            return result;
        }

        public string GetCKYMatrixAsStringFor(string sentence)
        {
            List<string>[,] matrix = BuildCKYMatrixFor(sentence);
            if (matrix == null)
                return "matrix is null.";
            string result = string.Empty;
            int length = matrix.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                for (int j = 1; j < length + 1; j++)
                {
                    if (matrix[i, j].Any())
                    {
                        foreach (var item in matrix[i, j])
                        {
                            result += item + @"/";
                        }
                        result = result.Remove(result.Count() - 1);
                    }
                    else
                    {
                        result += "---";
                    }
                    result += '\t';
                }
                result += Environment.NewLine;
            }
            return result;
        }
        #endregion

        public override string ToString()
        {
            string text = string.Empty;
            foreach (var rule in _rules)
            {
                text += rule.ToString() + Environment.NewLine;
            }
            return text;
        }
    }
}
