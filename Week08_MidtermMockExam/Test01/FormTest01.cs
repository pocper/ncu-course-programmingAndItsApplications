using System;
using System.Windows.Forms;

namespace Test01
{
    public partial class FormTest01 : Form
    {
        public FormTest01()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            float[,] A = new float[3, 3];
            float[,] B = new float[3, 3];
            float[,] C = null;

            CollectDataFromGUI(A, B);
            C = Multiply(A, B);
            DisplayResultToGUI(C);
        }

        private void CollectDataFromGUI(float[,] MatrixA, float[,] MatrixB)
        {
            //Create textbox buffers
            TextBox[,] tbA = new TextBox[3, 3]
            {
                {tbA11, tbA12, tbA13 },
                {tbA21, tbA22, tbA23 },
                {tbA31, tbA32, tbA33 }
            };
            TextBox[,] tbB = new TextBox[3, 3]
            {
                { tbB11, tbB12, tbB13 },
                { tbB21, tbB22, tbB23 },
                { tbB31, tbB32, tbB33 }
            };

            //Convert contents in textboxs into values in matrices
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    float vA = 0;
                    float vB = 0;
                    if (float.TryParse(tbA[i, j].Text, out vA)
                        && float.TryParse(tbB[i, j].Text, out vB))
                    {
                        MatrixA[i, j] = vA;
                        MatrixB[i, j] = vB;
                    }
                    else
                    {
                        throw new ArithmeticException("Cannot convert inputting text into a numerical value");
                    }
                }
            }
        }

        private float[,] Multiply(float[,] lhs, float[,] rhs)
        {
            //initialize 
            float[,] C = new float[3, 3];
            C.Initialize();

            //calculate
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        C[r, c] += lhs[r, i] * rhs[i, c];
                    }
                }
            }
            return C;
        }

        private void DisplayResultToGUI(float[,] result)
        {
            TextBox[,] tbC = new TextBox[3, 3]
            {
                {tbC11,tbC12,tbC13 }, {tbC21,tbC22,tbC23 }, {tbC31,tbC32,tbC33 }
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tbC[i, j].Text = result[i, j].ToString();
                }
            }
        }
    }
}
