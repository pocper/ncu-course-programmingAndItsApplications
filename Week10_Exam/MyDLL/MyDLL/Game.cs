using System;

namespace MyDLL
{
    public class Game
    {
        public event EventHandler<GuessResultArgs> Checking;
        public void SetAnwser(string set_anwser,string set_input)
        {
            GuessResultArgs guessArgs = new GuessResultArgs(set_anwser,set_input);
            guessArgs.result=Game_Content(set_anwser, set_input);
            if (Checking != null)
            {
                Checking(this, guessArgs);
            }
        }

        public string Game_Content(string anwser,string input)
        {
            int A = 0,B = 0;

            for(int i=0;i<anwser.Length;i++)
            {
                if (input[i] == anwser[i])
                {
                    A++;
                }
                else
                {
                    for(int j=0; j<anwser.Length; j++)
                    {
                        if(input[j] == anwser[i])
                        {
                            B++;
                        }
                    }
                }
            }

            return string.Format("{0}A{1}B", A, B);
        }
    }
}
