namespace Supercalifragalistic
{
    public partial class Form1 : Form
    {
        BMIcheck bmicalc = new BMIcheck();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmicalc.GetInput(heightbox,weightbox);
            bmicalc.GiveBMI(ref outputlabel);

            
        }

        private void BMIUpdater_Click(object sender, EventArgs e)
        {
            bmicalc.PrintBMIList(BMIListBox);
        }
    }
}