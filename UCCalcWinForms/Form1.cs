using System.Diagnostics;

namespace UCCalcWinForms
{
    [DebuggerDisplay($@"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public partial class Form1 : Form
    {
        List<person> children = new List<person>();
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
                var UC = Class1.CalcUC(salary, rent, WragInput.Checked, SupportInput.Checked, ageInput.Checked, coupleInput.Checked, children);
                textBox1.Text = " your UC is " + UC.ToString();
            }
            else { textBox1.Text = "error, salary and/or rent not decimal"; }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void AddChildButton_Click(object sender, EventArgs e)
        {
            var child = new person(childName.Text, DOBPicker.Value);
            children.Add(child);
            textBox1.Text = (child.dateOfBirth.ToString("MM/dd/yyyy"));
            childName.Text = "";
            DOBPicker.Value = DateTime.Now;
            var childrenCount = children.Count;
            ChildrenAddedLabel.Text = childrenCount.ToString() + "children added";
        }

        private void DOBPicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}