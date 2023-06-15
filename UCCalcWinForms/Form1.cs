using System.Diagnostics;

namespace UCCalcWinForms
{
    [DebuggerDisplay($@"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public partial class Form1 : Form
    {
        List<Children> childrenList = new List<Children>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal salary;
            decimal rent;
            bool salaryResult;
            bool rentResult;
            salaryResult = decimal.TryParse(salaryInput.Text, out salary);
            rentResult = decimal.TryParse(RentInput.Text, out rent);
            if (salaryResult == true && rentResult == true)
            {
                var UC = UCCalculation.CalcUC(salary, rent, WragInput.Checked, SupportInput.Checked, ageInput.Checked, coupleInput.Checked, childrenList);
                var totalIncome = UC + salary;
                textBox1.Text = " your UC is " + UC.ToString();
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText("you have a salary of " + salary);
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText(" this gives you a total income of " + totalIncome);
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText("This application is a personal project for practice only. Results may be inaccurate");
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText("this application should not be used for real world Universal Credit Calculations");
            }
            else { textBox1.Text = "error, salary and/or rent not decimal"; }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void AddChildButton_Click(object sender, EventArgs e)
        {
            var child = new Children(childName.Text, DOBPicker.Value);
            childrenList.Add(child);
            textBox1.Text = (child.dateOfBirth.ToString("MM/dd/yyyy"));
            childName.Text = "";
            DOBPicker.Value = DateTime.Now;
            var childrenCount = childrenList.Count;
            ChildrenAddedLabel.Text = childrenCount.ToString() + "children added";
        }

        private void DOBPicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}