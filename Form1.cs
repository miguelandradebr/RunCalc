using System.Diagnostics;

namespace RunCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //executa comando para abrir a calculadora
            
            Process.Start("calc.exe");


        }
    }
}