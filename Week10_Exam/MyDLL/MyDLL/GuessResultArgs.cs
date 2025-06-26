using System;

namespace MyDLL
{
    public class GuessResultArgs:EventArgs
    {
        public string result;
        public string Answer;
        public string Input;
        public GuessResultArgs(string answer,string input)
        {
            Answer = answer;
            Input = input;
        }
    }
}