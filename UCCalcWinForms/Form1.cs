namespace UCCalcWinForms
{
    public partial class Form1 : Form
    {
        public static decimal string2Dec(string text)
        {
            decimal result = 0;
            result = decimal.Parse(text);
            if (result.GetType() == typeof(decimal)) { return result; }
            else { Console.WriteLine("error, result not decimal"); return result; }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var UC = Class1.CalcUC(decimal.Parse(salaryInput.Text) ,decimal.Parse(RentInput.Text), WragInput.Checked, SupportInput.Checked, ageInput.Checked, coupleInput.Checked);
            textBox1.Text = UC.ToString();
        }
    }
}