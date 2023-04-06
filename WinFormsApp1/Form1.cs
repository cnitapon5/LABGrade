namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = this.tbName.Text;
            int year = int.Parse(this.tbBirthYear.Text);
            double grade = double.Parse(this.textBox1.Text);

            Person persons = new Person(name, year, grade);
            this.classroom.addPerson(persons);

            tbListofPerson.Text = this.classroom.ShowPerson();
            tbTotal.Text = this.classroom.ShowAllAge().ToString();
            this.classroom.SetGrade();
            this.textBox2.Text = this.classroom.ShowMaxGrade().ToString();
            this.textBox3.Text = this.classroom.ShowMinGrade().ToString();
            this.textBox5.Text = this.classroom.ShowMaxGradeName();
            this.textBox6.Text = this.classroom.ShowMinGradeName();
        }
    }
}